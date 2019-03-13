// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WorkbookPart
    /// </summary>
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    [PartConstraint(typeof(CustomXmlPart), false, true)]
    [PartConstraint(typeof(CalculationChainPart), false, false)]
    [PartConstraint(typeof(CellMetadataPart), false, false)]
    [PartConstraint(typeof(ConnectionsPart), false, false)]
    [PartConstraint(typeof(CustomXmlMappingsPart), false, false)]
    [PartConstraint(typeof(SharedStringTablePart), false, false)]
    [PartConstraint(typeof(WorkbookRevisionHeaderPart), false, false)]
    [PartConstraint(typeof(WorkbookUserDataPart), false, false)]
    [PartConstraint(typeof(WorkbookStylesPart), false, false)]
    [PartConstraint(typeof(ThemePart), false, false)]
    [PartConstraint(typeof(ThumbnailPart), false, false)]
    [PartConstraint(typeof(VolatileDependenciesPart), false, false)]
    [PartConstraint(typeof(ChartsheetPart), false, true)]
    [PartConstraint(typeof(DialogsheetPart), false, true)]
    [PartConstraint(typeof(ExternalWorkbookPart), false, true)]
    [PartConstraint(typeof(PivotTableCacheDefinitionPart), false, true)]
    [PartConstraint(typeof(WorksheetPart), false, true)]
    [PartConstraint(typeof(ExcelAttachedToolbarsPart), false, false)]
    [PartConstraint(typeof(VbaProjectPart), false, false)]
    [PartConstraint(typeof(MacroSheetPart), false, true)]
    [PartConstraint(typeof(InternationalMacroSheetPart), false, true)]
    [PartConstraint(typeof(CustomDataPropertiesPart), false, true)]
    [PartConstraint(typeof(SlicerCachePart), false, true)]
    [PartConstraint(typeof(TimeLineCachePart), false, true)]
    public partial class WorkbookPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private DocumentFormat.OpenXml.Spreadsheet.Workbook _rootElement;

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

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.Workbook;
            }
        }

        /// <summary>
        /// Gets the InternationalMacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<InternationalMacroSheetPart> InternationalMacroSheetParts => GetPartsOfType<InternationalMacroSheetPart>();

        /// <summary>
        /// Gets the MacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<MacroSheetPart> MacroSheetParts => GetPartsOfType<MacroSheetPart>();

        internal override OpenXmlPartRootElement PartRootElement => Workbook;

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
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.Workbook Workbook
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.Workbook>();
                }

                return _rootElement;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

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
    }
}
