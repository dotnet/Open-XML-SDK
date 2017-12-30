// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal class PackageSchemaPreProcessor
    {
        private readonly XmlSchema _schema;

        public PackageSchemaPreProcessor(XmlSchema schema)
        {
            _schema = schema;
        }

        public void PreProcessSom()
        {
            // First loop, replace element group ref and attribute group ref
            foreach (XmlSchemaType type in _schema.SchemaTypes.Values)
            {
                if (type is XmlSchemaComplexType cType)
                {
                    if (cType.Particle is XmlSchemaGroupRef sGroupRef)
                    {
                        //replace the group ref
                        //note: here only replace the first level group ref, don't set the group ref replaced flag
                        if (_schema.Groups[sGroupRef.RefName] is XmlSchemaGroup sGroup)
                        {
                            if (sGroup.Particle is XmlSchemaGroupBase particle)
                            {
                                cType.Particle = particle;
                                cType.Particle.MaxOccurs = sGroupRef.MaxOccurs;
                                cType.Particle.MinOccurs = sGroupRef.MinOccurs;

                                ReplaceGroupReference(particle);
                            }
                            else
                            {
                                throw new XmlSchemaException("elment in group is not the type of XmlSchemaGroupBase");
                            }
                        }
                        else
                        {
                            throw new XmlSchemaException("Schema groups should not contain non-group element");
                        }
                    }
                    else if (cType.Particle is XmlSchemaGroupBase groupBase)
                    {
                        ReplaceGroupReference(groupBase);
                    }

                    ExpandAttrGroup(cType);
                }
            }

            // Second loop, process the type extension
            foreach (XmlSchemaType type in _schema.SchemaTypes.Values)
            {
                ExpandContentModel(type as XmlSchemaComplexType);
            }
        }

        private void ExpandContentModel(XmlSchemaComplexType cType)
        {
            if (cType == null || cType.ContentModel == null)
            {
                return;
            }

            if (cType.ContentModel is XmlSchemaComplexContent)
            {
                if (cType.ContentModel.Content is XmlSchemaComplexContentExtension)
                {
                    var content = GetComplexExtensionContent((XmlSchemaComplexContentExtension)cType.ContentModel.Content);

                    // Replace ComplexContentExtension with Particle
                    cType.ContentModel = null;
                    cType.Particle = content.Elements;

                    foreach (XmlSchemaObject obj in content.Attributes)
                    {
                        cType.Attributes.Add(obj);
                    }
                }
                else if (cType.ContentModel.Content is XmlSchemaComplexContentRestriction)
                {
                    //TBD  office schemas don't contain complexcontentrestriction
                    throw new InvalidOperationException("Cannot process XmlSchemaComplexContentRestriction");
                }
            }
            else if (cType.ContentModel is XmlSchemaSimpleContent)
            {
                if (cType.ContentModel.Content is XmlSchemaSimpleContentExtension ext)
                {
                    var attrCollection = GetSimpleExtensionContent(ext, out bool attrAdded);

                    if (attrAdded)
                    {
                        ext.Attributes.Clear();

                        foreach (XmlSchemaObject o in attrCollection)
                        {
                            ext.Attributes.Add(o);
                        }
                    }
                }
                else if (cType.ContentModel.Content is XmlSchemaSimpleContentRestriction)
                {
                    throw new InvalidOperationException("Cannot process XmlSchemaSimpleContentRestriction");
                }
            }
        }

        private void ReplaceGroupReference(XmlSchemaGroupBase groupBase)
        {
            if (groupBase == null)
            {
                return;
            }

            for (int i = 0; i < groupBase.Items.Count; i++)
            {
                if (groupBase.Items[i] is XmlSchemaGroupRef sGroupRef)
                {
                    if (_schema.Groups[sGroupRef.RefName] is XmlSchemaGroup sGroup)
                    {
                        groupBase.Items.RemoveAt(i);
                        groupBase.Items.Insert(i, sGroup.Particle);
                        i--;//process the replaced node
                    }
                    else
                    {
                        throw new XmlSchemaException("schema groups containing non-group element");
                    }
                }
                else if (groupBase.Items[i] is XmlSchemaGroupBase sGroupBase)
                {
                    ReplaceGroupReference(sGroupBase);
                }
            }
        }

        private void ExpandAttrGroup(XmlSchemaComplexType cType)
        {
            var expanded = false;
            var attrs = new XmlSchemaObjectCollection();

            foreach (XmlSchemaObject obj in cType.Attributes)
            {
                if (obj is XmlSchemaAttribute attr)
                {
                    attrs.Add(attr);
                }
                else
                {
                    if (obj is XmlSchemaAttributeGroupRef gRef)
                    {
                        foreach (XmlSchemaObject o in GetAttributesFromGroupRef(gRef))
                        {
                            attrs.Add(o);
                        }

                        expanded = true;
                    }
                }
            }

            if (expanded)
            {
                cType.Attributes.Clear();

                foreach (XmlSchemaObject o in attrs)
                {
                    cType.Attributes.Add(o);
                }
            }
        }

        private XmlSchemaObjectCollection GetAttributesFromGroupRef(XmlSchemaAttributeGroupRef groupRef)
        {
            if (_schema.AttributeGroups[groupRef.RefName] is XmlSchemaAttributeGroup group)
            {
                var result = new XmlSchemaObjectCollection();

                foreach (XmlSchemaObject obj in group.Attributes)
                {
                    if (obj is XmlSchemaAttribute)
                    {
                        result.Add(obj);
                    }
                    else if (obj is XmlSchemaAttributeGroupRef gRef)
                    {
                        var collection = GetAttributesFromGroupRef(gRef);

                        foreach (var o in collection)
                        {
                            result.Add(o);
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new XmlSchemaException($"Invaid attribute group ref, group {groupRef.RefName} not found");
            }
        }

        private XmlSchemaObjectCollection GetSimpleExtensionContent(XmlSchemaSimpleContentExtension ext, out bool attrAdded)
        {
            attrAdded = false;

            if (_schema.SchemaTypes[ext.BaseTypeName] is XmlSchemaComplexType baseType)
            {
                if (baseType.ContentModel.Content is XmlSchemaSimpleContentExtension contentExtension)
                {
                    var parentAttrs = GetSimpleExtensionContent(contentExtension, out attrAdded);

                    if (parentAttrs.Count > 0)
                    {
                        foreach (XmlSchemaObject o in parentAttrs)
                        {
                            ext.Attributes.Add(o);
                        }

                        attrAdded = true;
                    }
                }
                else if (baseType.ContentModel.Content is XmlSchemaSimpleContentRestriction)
                {
                    throw new InvalidOperationException("Cannot process XmlSchemaSimpleContentRestriction");
                }
            }

            return ext.Attributes;
        }

        private ComplexExtensionContent GetComplexExtensionContent(XmlSchemaComplexContentExtension ext)
        {
            var baseType = _schema.SchemaTypes[ext.BaseTypeName] as XmlSchemaComplexType;

            if (baseType == null)
            {
                throw new XmlSchemaException($"Complex type {((XmlSchemaComplexType)ext.Parent).Name} has no base type {ext.BaseTypeName} defined");
            }

            if (baseType.Particle != null)
            {
                // Base type has contents and not is inherit from other complex type construct an outter sequence
                var seq = new XmlSchemaSequence();

                // Add base type elements to the seqenece
                seq.Items.Add(baseType.Particle);
                seq.Items.Add(ext.Particle);

                var attrs = new XmlSchemaObjectCollection();

                foreach (XmlSchemaObject baseAttr in baseType.Attributes)
                {
                    attrs.Add(baseAttr);
                }

                foreach (XmlSchemaObject curAttr in ext.Attributes)
                {
                    attrs.Add(curAttr);
                }

                return new ComplexExtensionContent(seq, attrs);
            }
            else if (baseType.ContentModel != null)
            {
                if (baseType.ContentModel.Content is XmlSchemaComplexContentExtension extention)
                {
                    // Base class is an extension to another class recursion, get the base type's content first
                    ComplexExtensionContent content = GetComplexExtensionContent(extention);

                    // Then merge the current type's child
                    var seq = new XmlSchemaSequence();

                    foreach (XmlSchemaObject obj in content.Elements.Items)
                    {
                        seq.Items.Add(obj);
                    }

                    seq.Items.Add(ext.Particle);

                    var attrs = new XmlSchemaObjectCollection();

                    foreach (var baseAttr in content.Attributes)
                    {
                        attrs.Add(baseAttr);
                    }

                    foreach (var curAttr in ext.Attributes)
                    {
                        attrs.Add(curAttr);
                    }

                    return new ComplexExtensionContent(seq, attrs);
                }

                if (baseType.ContentModel.Content is XmlSchemaComplexContentRestriction rst)
                {
                    throw new InvalidOperationException("Cannot process XmlSchemaComplexContentRestriction");
                }
            }

            return null;
        }
    }
}
