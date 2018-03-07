// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WorkbookPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WorkbookPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the WorkbookPart OpenXmlType
        /// </summary>
        internal protected WorkbookPart()
        {
        }

        /// <summary>
        /// Gets the CalculationChainPart of the WorkbookPart
        /// </summary>
        public CalculationChainPart CalculationChainPart => GetSubPartOfType<CalculationChainPart>();

        /// <summary>
        /// Gets the CellMetadataPart of the WorkbookPart
        /// </summary>
        public CellMetadataPart CellMetadataPart => GetSubPartOfType<CellMetadataPart>();

        /// <summary>
        /// Gets the ChartsheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<ChartsheetPart> ChartsheetParts => GetPartsOfType<ChartsheetPart>();

        /// <summary>
        /// Gets the ConnectionsPart of the WorkbookPart
        /// </summary>
        public ConnectionsPart ConnectionsPart => GetSubPartOfType<ConnectionsPart>();

        /// <summary>
        /// Gets the CustomDataPropertiesParts of the WorkbookPart
        /// </summary>
        public IEnumerable<CustomDataPropertiesPart> CustomDataPropertiesParts => GetPartsOfType<CustomDataPropertiesPart>();

        /// <summary>
        /// Gets the CustomXmlMappingsPart of the WorkbookPart
        /// </summary>
        public CustomXmlMappingsPart CustomXmlMappingsPart => GetSubPartOfType<CustomXmlMappingsPart>();

        /// <summary>
        /// Gets the CustomXmlParts of the WorkbookPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the DialogsheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<DialogsheetPart> DialogsheetParts => GetPartsOfType<DialogsheetPart>();

        /// <summary>
        /// Gets the ExcelAttachedToolbarsPart of the WorkbookPart
        /// </summary>
        public ExcelAttachedToolbarsPart ExcelAttachedToolbarsPart => GetSubPartOfType<ExcelAttachedToolbarsPart>();

        /// <summary>
        /// Gets the ExternalWorkbookParts of the WorkbookPart
        /// </summary>
        public IEnumerable<ExternalWorkbookPart> ExternalWorkbookParts => GetPartsOfType<ExternalWorkbookPart>();

        /// <summary>
        /// Gets the InternationalMacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<InternationalMacroSheetPart> InternationalMacroSheetParts => GetPartsOfType<InternationalMacroSheetPart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <summary>
        /// Gets the MacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<MacroSheetPart> MacroSheetParts => GetPartsOfType<MacroSheetPart>();

        /// <summary>
        /// Gets the PivotTableCacheDefinitionParts of the WorkbookPart
        /// </summary>
        public IEnumerable<PivotTableCacheDefinitionPart> PivotTableCacheDefinitionParts => GetPartsOfType<PivotTableCacheDefinitionPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SharedStringTablePart of the WorkbookPart
        /// </summary>
        public SharedStringTablePart SharedStringTablePart => GetSubPartOfType<SharedStringTablePart>();

        /// <summary>
        /// Gets the SlicerCacheParts of the WorkbookPart
        /// </summary>
        public IEnumerable<SlicerCachePart> SlicerCacheParts => GetPartsOfType<SlicerCachePart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "workbook";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "xl";

        /// <summary>
        /// Gets the ThemePart of the WorkbookPart
        /// </summary>
        public ThemePart ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the ThumbnailPart of the WorkbookPart
        /// </summary>
        public ThumbnailPart ThumbnailPart => GetSubPartOfType<ThumbnailPart>();

        /// <summary>
        /// Gets the TimeLineCacheParts of the WorkbookPart
        /// </summary>
        public IEnumerable<TimeLineCachePart> TimeLineCacheParts => GetPartsOfType<TimeLineCachePart>();

        /// <summary>
        /// Gets the VbaProjectPart of the WorkbookPart
        /// </summary>
        public VbaProjectPart VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the VolatileDependenciesPart of the WorkbookPart
        /// </summary>
        public VolatileDependenciesPart VolatileDependenciesPart => GetSubPartOfType<VolatileDependenciesPart>();

        /// <summary>
        /// Gets the WorkbookRevisionHeaderPart of the WorkbookPart
        /// </summary>
        public WorkbookRevisionHeaderPart WorkbookRevisionHeaderPart => GetSubPartOfType<WorkbookRevisionHeaderPart>();

        /// <summary>
        /// Gets the WorkbookStylesPart of the WorkbookPart
        /// </summary>
        public WorkbookStylesPart WorkbookStylesPart => GetSubPartOfType<WorkbookStylesPart>();

        /// <summary>
        /// Gets the WorkbookUserDataPart of the WorkbookPart
        /// </summary>
        public WorkbookUserDataPart WorkbookUserDataPart => GetSubPartOfType<WorkbookUserDataPart>();

        /// <summary>
        /// Gets the WorksheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<WorksheetPart> WorksheetParts => GetPartsOfType<WorksheetPart>();

        /// <summary>
        /// Adds a CustomXmlPart to the WorkbookPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the WorkbookPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType, string id)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the WorkbookPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the WorkbookPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType);
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WorkbookPart
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(string contentType)
        {
            var childPart = new ThumbnailPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WorkbookPart
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(string contentType, string id)
        {
            var childPart = new ThumbnailPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WorkbookPart
        /// </summary>
        /// <param name="partType">The part type of the ThumbnailPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType, string id)
        {
            var contentType = ThumbnailPartTypeInfo.GetContentType(partType);
            var partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddThumbnailPart(contentType, id);
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WorkbookPart
        /// </summary>
        /// <param name="partType">The part type of the ThumbnailPart</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
        {
            var contentType = ThumbnailPartTypeInfo.GetContentType(partType);
            var partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddThumbnailPart(contentType);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
                case CalculationChainPart.RelationshipTypeConstant:
                    return new CalculationChainPart();
                case CellMetadataPart.RelationshipTypeConstant:
                    return new CellMetadataPart();
                case ConnectionsPart.RelationshipTypeConstant:
                    return new ConnectionsPart();
                case CustomXmlMappingsPart.RelationshipTypeConstant:
                    return new CustomXmlMappingsPart();
                case SharedStringTablePart.RelationshipTypeConstant:
                    return new SharedStringTablePart();
                case WorkbookRevisionHeaderPart.RelationshipTypeConstant:
                    return new WorkbookRevisionHeaderPart();
                case WorkbookUserDataPart.RelationshipTypeConstant:
                    return new WorkbookUserDataPart();
                case WorkbookStylesPart.RelationshipTypeConstant:
                    return new WorkbookStylesPart();
                case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();
                case ThumbnailPart.RelationshipTypeConstant:
                    return new ThumbnailPart();
                case VolatileDependenciesPart.RelationshipTypeConstant:
                    return new VolatileDependenciesPart();
                case ChartsheetPart.RelationshipTypeConstant:
                    return new ChartsheetPart();
                case DialogsheetPart.RelationshipTypeConstant:
                    return new DialogsheetPart();
                case ExternalWorkbookPart.RelationshipTypeConstant:
                    return new ExternalWorkbookPart();
                case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
                    return new PivotTableCacheDefinitionPart();
                case WorksheetPart.RelationshipTypeConstant:
                    return new WorksheetPart();
                case ExcelAttachedToolbarsPart.RelationshipTypeConstant:
                    return new ExcelAttachedToolbarsPart();
                case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();
                case MacroSheetPart.RelationshipTypeConstant:
                    return new MacroSheetPart();
                case InternationalMacroSheetPart.RelationshipTypeConstant:
                    return new InternationalMacroSheetPart();
                case CustomDataPropertiesPart.RelationshipTypeConstant:
                    return new CustomDataPropertiesPart();
                case SlicerCachePart.RelationshipTypeConstant:
                    return new SlicerCachePart();
                case TimeLineCachePart.RelationshipTypeConstant:
                    return new TimeLineCachePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
                        new PartConstraintRule(nameof(CustomXmlPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain",
                        new PartConstraintRule(nameof(CalculationChainPart), CalculationChainPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata",
                        new PartConstraintRule(nameof(CellMetadataPart), CellMetadataPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections",
                        new PartConstraintRule(nameof(ConnectionsPart), ConnectionsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps",
                        new PartConstraintRule(nameof(CustomXmlMappingsPart), CustomXmlMappingsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings",
                        new PartConstraintRule(nameof(SharedStringTablePart), SharedStringTablePart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders",
                        new PartConstraintRule(nameof(WorkbookRevisionHeaderPart), WorkbookRevisionHeaderPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames",
                        new PartConstraintRule(nameof(WorkbookUserDataPart), WorkbookUserDataPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                        new PartConstraintRule(nameof(WorkbookStylesPart), WorkbookStylesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
                        new PartConstraintRule(nameof(ThemePart), ThemePart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",
                        new PartConstraintRule(nameof(ThumbnailPart), null, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies",
                        new PartConstraintRule(nameof(VolatileDependenciesPart), VolatileDependenciesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet",
                        new PartConstraintRule(nameof(ChartsheetPart), ChartsheetPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet",
                        new PartConstraintRule(nameof(DialogsheetPart), DialogsheetPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink",
                        new PartConstraintRule(nameof(ExternalWorkbookPart), ExternalWorkbookPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition",
                        new PartConstraintRule(nameof(PivotTableCacheDefinitionPart), PivotTableCacheDefinitionPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
                        new PartConstraintRule(nameof(WorksheetPart), WorksheetPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars",
                        new PartConstraintRule(nameof(ExcelAttachedToolbarsPart), ExcelAttachedToolbarsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
                        new PartConstraintRule(nameof(VbaProjectPart), VbaProjectPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet",
                        new PartConstraintRule(nameof(MacroSheetPart), MacroSheetPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet",
                        new PartConstraintRule(nameof(InternationalMacroSheetPart), InternationalMacroSheetPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/customDataProps",
                        new PartConstraintRule(nameof(CustomDataPropertiesPart), CustomDataPropertiesPart.ContentTypeConstant, false, true, FileFormatVersions.Office2010.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/slicerCache",
                        new PartConstraintRule(nameof(SlicerCachePart), SlicerCachePart.ContentTypeConstant, false, true, FileFormatVersions.Office2010.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2011/relationships/timelineCache",
                        new PartConstraintRule(nameof(TimeLineCachePart), TimeLineCachePart.ContentTypeConstant, false, true, FileFormatVersions.Office2013.AndLater())
                    }
                };
            }

            return _partConstraint;
        }
    }
}
