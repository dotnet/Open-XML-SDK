// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
    /// <summary>
    /// Defines AdditionalCharacteristics.
    /// </summary>
    public partial class AdditionalCharacteristicsInfo : OpenXmlPartRootElement
    {
        /// <summary>
        /// AdditionalCharacteristics constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the AdditionalCharacteristics.</param>
        internal AdditionalCharacteristicsInfo(CustomXmlPart ownerPart)
            : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomXmlPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomXmlPart openXmlPart)
        {
            SaveToPart(openXmlPart);
        }
    }
}
