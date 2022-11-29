using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;

var file = @"C:\Users\tasou\OneDrive - Microsoft\Documents\MainLiveDoc.pptx";


using var doc = PresentationDocument.Open(file, false);

var parts = doc.GetAllParts();

var validator = new OpenXmlValidator();

var result = validator.Validate(doc);

foreach (var part in result)
{
    Console.WriteLine(part.Description);
}