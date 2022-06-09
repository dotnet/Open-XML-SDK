// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons;

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    internal class SchematronDataParser
    {
        private readonly Dictionary<string, Func<SchematronEntry, IEnumerable<ISchematron>>> _lookup = new()
        {
            { "1.1", Schematron1_1.Parse },
            { "1.2", Schematron1_2.Parse },
            { "1.3", Schematron1_3.Parse },
            { "1.4", Schematron1_4.Parse },
            { "1.10", Schematron1_10.Parse },
            { "1.12", Schematron1_12.Parse },
            { "1.14", Schematron1_14.Parse },
            { "1.15", Schematron1_15.Parse },
            { "1.16", Schematron1_16.Parse },
            { "1.17", Schematron1_17.Parse },
            { "1.18", Schematron1_18.Parse },
            { "1.19", Schematron1_19.Parse },
            { "2.1", Schematron2_1.Parse },
            { "2.2", Schematron2_2.Parse },
            { "2.3", Schematron2_3.Parse },
            { "3.1", Schematron3_1.Parse },
            { "3.2", Schematron3_2.Parse },
            { "3.3", Schematron3_3.Parse },
        };

        public IEnumerable<ISchematron> Parse(SchematronEntry schematron)
        {
            var category = CategoryIdentifier.Identify(schematron.Test);

            return _lookup[category](schematron).ToArray();
        }
    }
}
