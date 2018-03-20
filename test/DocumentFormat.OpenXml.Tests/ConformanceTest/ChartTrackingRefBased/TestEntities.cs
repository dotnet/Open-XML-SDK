// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using LogUtil;
using System;
using System.IO;
using System.Linq;

using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    public class TestEntities
    {
        /// <summary>
        /// Gets or sets URI attribute value of PresentationPropertiesExtension
        /// </summary>
        private string ChartTrackingReferenceBasedExtUri { get; set; }

        /// <summary>
        /// Constructor
        /// Get URI attribute value of PresentationPropertiesExtension
        /// </summary>
        public TestEntities(Stream stream)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                //Get Extension Uri value
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();
                PresentationPropertiesExtension presentationPropertiesExtension = (PresentationPropertiesExtension)chartTrackingReferenceBased.Parent;
                ChartTrackingReferenceBasedExtUri = presentationPropertiesExtension.Uri;

                if (string.IsNullOrEmpty(ChartTrackingReferenceBasedExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set.");
            }
        }

        /// <summary>
        /// Editing chartTrackingReferenceBased element
        /// </summary>
        public void EditElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();
                chartTrackingReferenceBased.Val.Value = true;

                log.Pass("Edited ChartTrackingReferenceBase value.");
            }
        }

        /// <summary>
        /// Verifying the chartTrackingReferenceBased element the existence
        /// </summary>
        public void VerifyElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();

                log.Verify(chartTrackingReferenceBased.Val.Value == true, "UnChanged in the ChartTrackingReferenceBase element.");
            }
        }

        /// <summary>
        /// Deleting chartTrackingReferenceBased element
        /// </summary>
        public void DeleteElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                PresentationPropertiesExtension presentationPropertiesExtension = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == ChartTrackingReferenceBasedExtUri).Single();
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = presentationPropertiesExtension.Descendants<P15.ChartTrackingReferenceBased>().Single();

                chartTrackingReferenceBased.Remove();
                presentationPropertiesExtension.Remove();

                log.Pass("Deleted chartTrackingReferenceBased element.");
            }
        }

        /// <summary>
        /// Verifying the chartTrackingReferenceBased element the deleting
        /// </summary>
        public void VerifyDeleteElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                int chartTrackingReferenceBasedExtCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == ChartTrackingReferenceBasedExtUri).Count();
                log.Verify(chartTrackingReferenceBasedExtCount == 0, "ChartTrackingReferenceBased extension element is not deleted.");

                int chartTrackingReferenceBasedCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Count();
                log.Verify(chartTrackingReferenceBasedCount == 0, "ChartTrackingReferenceBased element is not deleted.");
            }
        }

        /// <summary>
        /// Append the chartTrackingReferenceBased element
        /// </summary>
        public void AddElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, true))
            {
                PresentationPropertiesExtension presentationPropertiesExtension = new PresentationPropertiesExtension() { Uri = ChartTrackingReferenceBasedExtUri };
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = new P15.ChartTrackingReferenceBased();
                chartTrackingReferenceBased.Val = true;

                presentationPropertiesExtension.AppendChild<P15.ChartTrackingReferenceBased>(chartTrackingReferenceBased);
                package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.AppendChild<PresentationPropertiesExtension>(presentationPropertiesExtension);

                log.Pass("Added ChartTrackingReferenceBased element.");
            }
        }

        /// <summary>
        /// Verifying the chartTrackingReferenceBased element the appending
        /// </summary>
        public void VerifyAddElements(Stream stream, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(stream, false))
            {
                int chartTrackingReferenceBasedExtCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == ChartTrackingReferenceBasedExtUri).Count();

                log.Verify(chartTrackingReferenceBasedExtCount == 1, "chartTrackingReferenceBased extension element is not added.");

                int chartTrackingReferenceBasedCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Count();
                log.Verify(chartTrackingReferenceBasedCount == 1, "ChartTrackingReferenceBased element is not added.");
            }
        }
    }
}
