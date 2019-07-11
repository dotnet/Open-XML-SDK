IsolatedStorage exception
========================

In scenarios where the OpenXML SDK is used in a hosted environment (such as add-ins or extensions), the AppDomain may not be set up to allow for IsolatedStorage. This will cause an exception similar to the following:

```
System.IO.IsolatedStorage.IsolatedStorageException: Unable to determine the identity of domain.
   at System.IO.IsolatedStorage.IsolatedStorage._GetAccountingInfo(Evidence evidence, Type evidenceType, IsolatedStorageScope fAssmDomApp, Object& oNormalized)
   at System.IO.IsolatedStorage.IsolatedStorage.GetAccountingInfo(Evidence evidence, Type evidenceType, IsolatedStorageScope fAssmDomApp, String& typeName, String& instanceName)
   at System.IO.IsolatedStorage.IsolatedStorage._InitStore(IsolatedStorageScope scope, Evidence domainEv, Type domainEvidenceType, Evidence assemEv, Type assemblyEvidenceType, Evidence appEv, Type appEvidenceType)
   at System.IO.IsolatedStorage.IsolatedStorage.InitStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
   at System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
   at MS.Internal.IO.Packaging.PackagingUtilities.ReliableIsolatedStorageFileFolder.GetCurrentStore()
   at MS.Internal.IO.Packaging.PackagingUtilities.ReliableIsolatedStorageFileFolder..ctor()
   at MS.Internal.IO.Packaging.PackagingUtilities.GetDefaultIsolatedStorageFile()
   at MS.Internal.IO.Packaging.PackagingUtilities.CreateUserScopedIsolatedStorageFileStreamWithRandomName(Int32 retryCount, String& fileName)
   at MS.Internal.IO.Packaging.SparseMemoryStream.SwitchModeIfNecessary()
   at MS.Internal.IO.Packaging.SparseMemoryStream.Write(Byte[] buffer, Int32 offset, Int32 count)
   at MS.Internal.IO.Packaging.CompressEmulationStream.Write(Byte[] buffer, Int32 offset, Int32 count)
   at MS.Internal.IO.Packaging.CompressStream.Write(Byte[] buffer, Int32 offset, Int32 count)
   at MS.Internal.IO.Zip.ProgressiveCrcCalculatingStream.Write(Byte[] buffer, Int32 offset, Int32 count)
   at MS.Internal.IO.Zip.ZipIOModeEnforcingStream.Write(Byte[] buffer, Int32 offset, Int32 count)
   at System.Xml.XmlUtf8RawTextWriter.FlushBuffer()
   at System.Xml.XmlUtf8RawTextWriter.WriteElementTextBlock(Char* pSrc, Char* pSrcEnd)
   at System.Xml.XmlUtf8RawTextWriter.WriteString(String text)
   at System.Xml.XmlWellFormedWriter.WriteString(String text)
   at DocumentFormat.OpenXml.OpenXmlElement.WriteTo(XmlWriter xmlWriter)
   at DocumentFormat.OpenXml.OpenXmlCompositeElement.WriteContentTo(XmlWriter w)
   at DocumentFormat.OpenXml.OpenXmlElement.WriteTo(XmlWriter xmlWriter)
   at DocumentFormat.OpenXml.OpenXmlCompositeElement.WriteContentTo(XmlWriter w)
   at DocumentFormat.OpenXml.OpenXmlElement.WriteTo(XmlWriter xmlWriter)
   at DocumentFormat.OpenXml.OpenXmlCompositeElement.WriteContentTo(XmlWriter w)
   at DocumentFormat.OpenXml.OpenXmlElement.WriteTo(XmlWriter xmlWriter)
   at DocumentFormat.OpenXml.OpenXmlCompositeElement.WriteContentTo(XmlWriter w)
   at DocumentFormat.OpenXml.OpenXmlPartRootElement.WriteTo(XmlWriter xmlWriter)
   at DocumentFormat.OpenXml.OpenXmlPartRootElement.Save(Stream stream)
   at DocumentFormat.OpenXml.OpenXmlPartRootElement.SaveToPart(OpenXmlPart openXmlPart)
   at DocumentFormat.OpenXml.Packaging.OpenXmlPackage.TrySavePartContent(OpenXmlPart part)
   at DocumentFormat.OpenXml.Packaging.OpenXmlPackage.SavePartContents(Boolean save)
   at DocumentFormat.OpenXml.Packaging.OpenXmlPackage.Dispose(Boolean disposing)
   at DocumentFormat.OpenXml.Packaging.OpenXmlPackage.Dispose()
   at IsolatedStorageExceptionWorkaround.Program.Extension.Run()
```

In scenarios like this, a simple work around is to create your own AppDomain with sufficient evidence:

```csharp
internal interface IExtension
{
    void Run();
}

internal class Extension : MarshalByRefObject, IExtension
{
    public void Run()
    {
    }
}

internal class ExtensionWithAppDomain : MarshalByRefObject, IExtension
{
    private readonly IExtension _other;

    public ExtensionWithAppDomain()
    {
        var evidence = new Evidence();
        evidence.AddHostEvidence(new Zone(SecurityZone.MyComputer));

        var domain = AppDomain.CreateDomain($"{AppDomain.CurrentDomain.FriendlyName}_Evidence", evidence);
        _other = (IExtension)domain.CreateInstanceAndUnwrap(typeof(Extension).Assembly.FullName, typeof(Extension).FullName);
    }

    public void Run() => _other.Run();
}
```

This does have a potential performance impact as any data accessed in the extension will be serialized across the AppDomain boundary unless
the data derives from MarshalByRefObject. In order to mitigate this, do as much work with OpenXML in the same AppDomain to minimize this data transfer.
