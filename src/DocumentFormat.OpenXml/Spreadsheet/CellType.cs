// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    public partial class CellType : IValidator
    {
        void IValidator.Validate(ValidationContext context)
        {
            if (DataType is null || !DataType.HasValue)
            {
                return;
            }

            if (CellValue is CellValue value)
            {
                var success = DataType.Value switch
                {
                    CellValues.Boolean => value.TryGetBoolean(out _),
                    CellValues.Date => value.TryGetDateTimeOffset(out _) || value.TryGetDateTime(out _),
                    CellValues.Number => value.TryGetInt(out _) || value.TryGetDouble(out _) || value.TryGetDecimal(out _),
                    _ => true,
                };

                if (!success)
                {
                    context.CreateError(
                        id: "Sem_CellValue",
                        errorType: ValidationErrorType.Semantic,
                        description: string.Format(ValidationResources.Sem_CellValue, value.InnerText, DataType.Value)
                    );
                }
            }
        }
    }
}
