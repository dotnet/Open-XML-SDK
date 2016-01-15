// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
    using LogUtil;

    public class TestEntities
    {
        #region Property
        /// <summary>
        /// URI attribute value of PresentationPropertiesExtension
        /// </summary>
        private string ChartTrackingReferenceBasedExtUri { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// Get URI attribute value of PresentationPropertiesExtension
        /// </summary>
        /// <param name="filePath">Generated file path</param>
        public TestEntities(string filePath)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                //Get Extension Uri value
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();
                PresentationPropertiesExtension presentationPropertiesExtension = (PresentationPropertiesExtension)chartTrackingReferenceBased.Parent;
                this.ChartTrackingReferenceBasedExtUri = presentationPropertiesExtension.Uri;

                if (string.IsNullOrEmpty(this.ChartTrackingReferenceBasedExtUri))
                    throw new Exception("Uri attribute value in Extension element is not set.");
            }
        }

        /// <summary>
        /// Editing chartTrackingReferenceBased element
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();
                chartTrackingReferenceBased.Val.Value = true;

                log.Pass("Edited ChartTrackingReferenceBase value.");
            }
        }

        /// <summary>
        /// Verifying the chartTrackingReferenceBased element the existence
        /// </summary>
        /// <param name="filePath">Target faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Single();

                log.Verify(chartTrackingReferenceBased.Val.Value == true, "UnChanged in the ChartTrackingReferenceBase element.");
            }
        }

        /// <summary>
        /// Deleting chartTrackingReferenceBased element
        /// </summary>
        /// <param name="filePath">Target faile path</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                PresentationPropertiesExtension presentationPropertiesExtension = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == this.ChartTrackingReferenceBasedExtUri).Single();
                P15.ChartTrackingReferenceBased chartTrackingReferenceBased = presentationPropertiesExtension.Descendants<P15.ChartTrackingReferenceBased>().Single();

                chartTrackingReferenceBased.Remove();
                presentationPropertiesExtension.Remove();

                log.Pass("Deleted chartTrackingReferenceBased element.");
            }
        }

        /// <summary>
        /// Verifying the chartTrackingReferenceBased element the deleting
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeleteElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                int chartTrackingReferenceBasedExtCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == this.ChartTrackingReferenceBasedExtUri).Count();
                log.Verify(chartTrackingReferenceBasedExtCount == 0, "ChartTrackingReferenceBased extension element is not deleted.");

                int chartTrackingReferenceBasedCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Count();
                log.Verify(chartTrackingReferenceBasedCount == 0, "ChartTrackingReferenceBased element is not deleted.");
            }
        }

        /// <summary>
        /// Append the chartTrackingReferenceBased element
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void AddElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, true))
            {
                PresentationPropertiesExtension presentationPropertiesExtension = new PresentationPropertiesExtension() { Uri = this.ChartTrackingReferenceBasedExtUri };
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
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddElements(string filePath, VerifiableLog log)
        {
            using (PresentationDocument package = PresentationDocument.Open(filePath, false))
            {
                int chartTrackingReferenceBasedExtCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<PresentationPropertiesExtension>().Where(e => e.Uri == this.ChartTrackingReferenceBasedExtUri).Count();

                log.Verify(chartTrackingReferenceBasedExtCount == 1, "chartTrackingReferenceBased extension element is not added.");

                int chartTrackingReferenceBasedCount = package.PresentationPart.PresentationPropertiesPart.PresentationProperties.PresentationPropertiesExtensionList.Descendants<P15.ChartTrackingReferenceBased>().Count();
                log.Verify(chartTrackingReferenceBasedCount == 1, "ChartTrackingReferenceBased element is not added.");
            }
        }
    }
}
