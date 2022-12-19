# Rich Data

This sample code shows how to add [Rich Data](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/4f1ecded-a988-4361-a6ca-62a789f3e095) to a document with the SDK. In `Program.cs` the required parts and their elements are added with a method defined for each part.

## Rich Data Requires These Parts

- [RdRichValueWebImagePart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/4f3a80fd-1776-407f-8807-2497a4692dea)
- [RdRichValuePart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/896934fd-8df7-43f4-b154-2d39371c270d)
- [RdRichValueStructurePart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/d90f6d91-d868-4b94-9d26-ec3b1492cec6)
- [RdArrayPart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/53fe3b74-080d-4a70-b578-c3d7e2df6c4a)
- [RichStylesPart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/a7ffcfda-157f-4a62-8679-5de74e306c5a)
- [RdSupportingPropertyBagStructurePart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/f8960ea7-5c9d-4126-90bf-3a115f380de5)
- [RdSupportingPropertyBagPart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/f2242845-5252-4a95-82de-a71a0110bdb9)
- [RdRichValueTypesPart](https://learn.microsoft.com/en-us/openspecs/office_standards/ms-xlsx/5d213b66-3196-4516-b63c-eef80d926f4a)
- [CellMetadataPart](https://learn.microsoft.com/en-us/dotnet/api/documentformat.openxml.spreadsheet.cellmetadata?view=openxml-2.8.1)

To run the sample, pass the absolute path of the file you want to add Rich Data to as the first argument. The sample will add geographic Rich Data to cell `A1` for Seattle. You can learn more about the Rich Data types available in this post [What linked data types are available in Excel?](https://support.microsoft.com/en-us/office/what-linked-data-types-are-available-in-excel-6510ab58-52f6-4368-ba0f-6a76c0190772)
