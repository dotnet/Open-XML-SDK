// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml;

namespace DocumentFormat.OpenXml.Office2021.Word.CommentsExt
{
    public partial class CommentExtensible
    {
        /// <summary>
        /// Gets or sets the <see cref="CommentExtensibleExtensionList"/> value. It is only available for backwards compatibility
        /// until the next major version change. The <see cref="CommentExtensibleExtensionList"/> property should be used instead.
        /// </summary>
        [Obsolete("Please use the property 'CommentExtensibleExtensionList' as this property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ExtensionList? ExtensionList
        {
            get
            {
                return CopyExtensionListFromNewMember(CommentExtensibleExtensionList);
            }

            set
            {
                CopyExtensionListToNewMember(value, CommentExtensibleExtensionList);
            }
        }

        private void CopyExtensionListToNewMember(ExtensionList value, OpenXmlCompositeElement? newMember)
        {
            if (value != null)
            {
                if (newMember == null)
                {
                    newMember = (OpenXmlCompositeElement)Activator.CreateInstance(newMember.GetType());
                }

                foreach (PropertyInfo prop in value.GetType().GetProperties())
                {
                    PropertyInfo? newMemberProp = newMember?.GetType().GetProperty(prop.Name);

                    if (newMemberProp != null && newMemberProp.PropertyType == prop.PropertyType)
                    {
                        if (newMemberProp.GetSetMethod() != null)
                        {
                            PropertyInfo? valProp = value.GetType()?.GetProperty(prop.Name);

                            if (valProp != null && valProp.CanRead)
                            {
                                newMemberProp.SetValue(newMember, valProp.GetValue(value));
                            }
                            else if (valProp != null && !valProp.CanRead && valProp.Name == "InnerXml")
                            {
                                XmlDocument xmlDocument = new XmlDocument();
                                xmlDocument.LoadXml(value.OuterXml);
                                XmlElement? root = xmlDocument.DocumentElement;

                                if (root != null && root.InnerXml != null && newMember != null)
                                {
                                    newMember.InnerXml = root.InnerXml;
                                }
                            }
                        }
                    }
                }
            }
        }

        private ExtensionList? CopyExtensionListFromNewMember(OpenXmlCompositeElement newMember)
        {
            ExtensionList? extLst = null;

            if (newMember != null)
            {
                extLst = new ExtensionList(newMember.OuterXml);

                foreach (PropertyInfo prop in newMember.GetType().GetProperties())
                {
                    PropertyInfo? exProp = extLst.GetType().GetProperty(prop.Name);

                    if (exProp != null && exProp.PropertyType == prop.PropertyType)
                    {
                        if (exProp.GetSetMethod() != null)
                        {
                            PropertyInfo? valProp = newMember.GetType().GetProperty(prop.Name);

                            if (valProp != null && valProp.CanRead)
                            {
                                exProp.SetValue(extLst, valProp.GetValue(newMember));
                            }
                            else if (valProp != null && !valProp.CanRead && valProp.Name == "InnerXml")
                            {
                                XmlDocument xmlDocument = new XmlDocument();
                                xmlDocument.LoadXml(extLst.OuterXml);
                                XmlElement? root = xmlDocument.DocumentElement;

                                if (root != null && root.InnerXml != null)
                                {
                                    extLst.InnerXml = root.InnerXml;
                                }
                            }
                        }
                    }
                }
            }

            return extLst;
        }
    }
}
