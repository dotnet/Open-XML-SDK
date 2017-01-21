using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    internal abstract class OfficeStaticSchemaDatas : SdbSchemaDatas
    {
        protected abstract FileFormatVersions Version { get; }

        public void Initialize()
        {
            SetFileFormat(SimpleTypeRestrictions.SimpleTypes, Version);
        }

        private static void SetFileFormat(SimpleTypeRestriction[] simpleTypes, FileFormatVersions fileFormat)
        {
            if (simpleTypes == null)
            {
                return;
            }

            foreach (var simpleType in simpleTypes)
            {
                SetFileFormat(simpleType, fileFormat);
            }
        }

        private static void SetFileFormat(SimpleTypeRestriction simpleType, FileFormatVersions fileFormat)
        {
            if (simpleType == null)
            {
                return;
            }

            simpleType.FileFormat = fileFormat;

            SetFileFormat((simpleType as UnionValueRestriction)?.UnionTypes, fileFormat);
            SetFileFormat((simpleType as RedirectedRestriction)?.TargetRestriction, fileFormat);
            SetFileFormat((simpleType as ListValueRestriction)?.ListItemType, fileFormat);
        }
    }

    internal partial class Office2007Schema : OfficeStaticSchemaDatas
    {
        protected override FileFormatVersions Version { get; } = FileFormatVersions.Office2007;
    }

    internal partial class Office2010Schema : OfficeStaticSchemaDatas
    {
        protected override FileFormatVersions Version { get; } = FileFormatVersions.Office2010;
    }

    internal partial class Office2013Schema : OfficeStaticSchemaDatas
    {
        protected override FileFormatVersions Version { get; } = FileFormatVersions.Office2013;
    }
}
