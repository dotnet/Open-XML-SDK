// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    /// <summary>
    /// Translate Strict attributes to Transitional
    /// </summary>
    internal static class AttributeTranslator
    {
        private static TagAttributeTranslator translator;
        private static Dictionary<string, TagAttributeTranslator> dicOfTranslators = null;

        private static Dictionary<string, TagAttributeTranslator> DicOfTranslators
        {
            get
            {
                if (dicOfTranslators == null)
                {
                    dicOfTranslators = new Dictionary<string, TagAttributeTranslator>();

                    // Add all the tags we handle.
                    dicOfTranslators["document"] = null;
                    dicOfTranslators["cnfStyle"] = null;
                    dicOfTranslators["tblLook"] = null;
                    dicOfTranslators["ind"] = null;
                    dicOfTranslators["tab"] = null; // "tab" and "jc"
                    dicOfTranslators["stylePaneSortMethod"] = null;
                    dicOfTranslators["textDirection"] = null;
                }

                return dicOfTranslators;
            }
        }

        /// <summary>
        /// Translate Strict attribute to Transitional
        /// </summary>
        /// <param name="strTag"></param>
        /// <param name="strLocalName"></param>
        /// <param name="strValue"></param>
        /// <returns>The translator</returns>
        internal static TagAttributeTranslator Translate(string strTag, string strLocalName, string strValue)
        {
            translator = null;

            if (strTag != null && strLocalName != null && strValue != null)
            {
                try
                {
                    if (DicOfTranslators.ContainsKey(strTag))
                    {
                        translator = DicOfTranslators[strTag];

                        if (translator == null)
                        {
                            switch (strTag)
                            {
                                case "document":
                                    translator = new DocumentTagAttributeTranslator();
                                    break;

                                case "cnfStyle":
                                    translator = new CnfStyleTagAttributeTranslator();
                                    break;

                                case "tblLook":
                                    translator = new TblLookTagAttributeTranslator();
                                    break;

                                case "ind":
                                    translator = new IndTagAttributeTranslator();
                                    break;

                                case "jc": // falls through...
                                case "tab":
                                    translator = new JcTabTagAttributeTranslator();
                                    break;

                                case "stylePaneSortMethod":
                                    translator = new StylePaneSortMethodTagAttributeTranslator();
                                    break;

                                case "textDirection":
                                    translator = new TextDirectionTagAttributeTranslator();
                                    break;

                                default:
                                    break;
                            }

                            Debug.Assert(translator != null, "AttributeTranslator.Translate() can't initialize a translator.");

                            DicOfTranslators[strTag] = translator;
                        }
                    }

                    if (translator != null)
                    {
                        translator.SetLocalNameAndValue(strLocalName, strValue);

                        if (translator.Index == (int)TagAttributeTranslator.State.NotInitialized)
                        {
                            translator = null;
                        }
                    }
                }
                catch
                {
                    Debug.Assert(true, "AttributeTranslator.Translate() failed.");

                    translator = null;
                }
            }

            return translator;
        }
    }
}
