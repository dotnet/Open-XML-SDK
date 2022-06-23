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
                ExtensionList? extLst = null;

                if (CommentExtensibleExtensionList != null)
                {
                    extLst = new ExtensionList(CommentExtensibleExtensionList.OuterXml);

                    foreach (PropertyInfo prop in CommentExtensibleExtensionList.GetType().GetProperties())
                    {
                        PropertyInfo? exProp = extLst.GetType().GetProperty(prop.Name);

                        if (exProp != null && exProp.PropertyType == prop.PropertyType)
                        {
                            if (exProp.GetSetMethod() != null)
                            {
                                PropertyInfo? valProp = CommentExtensibleExtensionList.GetType().GetProperty(prop.Name);

                                if (valProp != null && valProp.CanRead)
                                {
                                    exProp.SetValue(extLst, valProp.GetValue(CommentExtensibleExtensionList));
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

            set
            {
                if (value != null)
                {
                    if (CommentExtensibleExtensionList == null)
                    {
                        CommentExtensibleExtensionList = new CommentExtensibleExtensionList();
                    }

                    foreach (PropertyInfo prop in value.GetType().GetProperties())
                    {
                        PropertyInfo? cmtExtListProp = CommentExtensibleExtensionList?.GetType().GetProperty(prop.Name);

                        if (cmtExtListProp != null && cmtExtListProp.PropertyType == prop.PropertyType)
                        {
                            if (cmtExtListProp.GetSetMethod() != null)
                            {
                                PropertyInfo? valProp = value.GetType()?.GetProperty(prop.Name);

                                if (valProp != null && valProp.CanRead)
                                {
                                    cmtExtListProp.SetValue(CommentExtensibleExtensionList, valProp.GetValue(value));
                                }
                                else if (valProp != null && !valProp.CanRead && valProp.Name == "InnerXml")
                                {
                                    XmlDocument xmlDocument = new XmlDocument();
                                    xmlDocument.LoadXml(value.OuterXml);
                                    XmlElement? root = xmlDocument.DocumentElement;

                                    if (root != null && root.InnerXml != null && CommentExtensibleExtensionList != null)
                                    {
                                        CommentExtensibleExtensionList.InnerXml = root.InnerXml;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
