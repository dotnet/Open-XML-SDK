// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons;

#nullable disable

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    internal class SchematronVisitor<T>
    {
        public T Visit(ISchematron schematron)
        {
            if (schematron is Schematron1_1 a1_1)
            {
                return Visit(a1_1);
            }
            else if (schematron is Schematron1_2 a1_2)
            {
                return Visit(a1_2);
            }
            else if (schematron is Schematron1_3 a1_3)
            {
                return Visit(a1_3);
            }
            else if (schematron is Schematron1_4 a1_4)
            {
                return Visit(a1_4);
            }
            else if (schematron is Schematron1_10 a1_10)
            {
                return Visit(a1_10);
            }
            else if (schematron is Schematron1_12 a1_12)
            {
                return Visit(a1_12);
            }
            else if (schematron is Schematron1_14 a1_14)
            {
                return Visit(a1_14);
            }
            else if (schematron is Schematron1_15 a1_15)
            {
                return Visit(a1_15);
            }
            else if (schematron is Schematron1_16 a1_16)
            {
                return Visit(a1_16);
            }
            else if (schematron is Schematron1_17 a1_17)
            {
                return Visit(a1_17);
            }
            else if (schematron is Schematron1_18 a1_18)
            {
                return Visit(a1_18);
            }
            else if (schematron is Schematron1_19 a1_19)
            {
                return Visit(a1_19);
            }
            else if (schematron is Schematron2_1 a2_1)
            {
                return Visit(a2_1);
            }
            else if (schematron is Schematron2_2 a2_2)
            {
                return Visit(a2_2);
            }
            else if (schematron is Schematron2_3 a2_3)
            {
                return Visit(a2_3);
            }
            else if (schematron is Schematron3_1 a3_1)
            {
                return Visit(a3_1);
            }
            else if (schematron is Schematron3_2 a3_2)
            {
                return Visit(a3_2);
            }
            else if (schematron is Schematron3_3 a3_3)
            {
                return Visit(a3_3);
            }

            throw new ArgumentOutOfRangeException(nameof(schematron), schematron, "Unknown schematron type");
        }

        public virtual T Visit(Schematron1_1 schematron) => default;

        public virtual T Visit(Schematron1_2 schematron) => default;

        public virtual T Visit(Schematron1_3 schematron) => default;

        public virtual T Visit(Schematron1_4 schematron) => default;

        public virtual T Visit(Schematron1_10 schematron) => default;

        public virtual T Visit(Schematron1_12 schematron) => default;

        public virtual T Visit(Schematron1_14 schematron) => default;

        public virtual T Visit(Schematron1_15 schematron) => default;

        public virtual T Visit(Schematron1_16 schematron) => default;

        public virtual T Visit(Schematron1_17 schematron) => default;

        public virtual T Visit(Schematron1_18 schematron) => default;

        public virtual T Visit(Schematron1_19 schematron) => default;

        public virtual T Visit(Schematron2_1 schematron) => default;

        public virtual T Visit(Schematron2_2 schematron) => default;

        public virtual T Visit(Schematron2_3 schematron) => default;

        public virtual T Visit(Schematron3_1 schematron) => default;

        public virtual T Visit(Schematron3_2 schematron) => default;

        public virtual T Visit(Schematron3_3 schematron) => default;
    }
}
