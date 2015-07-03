/***************************************************************************

Copyright (c) Microsoft Corporation 2012-2013.

This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:

http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx

Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx

Developer: Eric White
Blog: http://www.ericwhite.com
Twitter: @EricWhiteDev
Email: eric@ericwhite.com

Version: 2.6.00
 * Enhancements to support HtmlConverter.cs

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace OpenXmlPowerTools
{
    public static class PtUtils
    {
        public static string NormalizeDirName(string dirName)
        {
            var d = dirName.Replace('\\', '/');
            if (d[dirName.Length - 1] != '/' && d[dirName.Length - 1] != '\\')
                return d + "/";
            else
                return d;
        }

        public static string MakeValidXml(string p)
        {
            if (!p.Any(c => c < 0x20))
                return p;
            var newP = p
                .Select(c =>
                {
                    if (c < 0x20)
                        return string.Format("_{0:X}_", (int)c);
                    return c.ToString();
                })
                .StringConcatenate();
            return newP;
        }
    }

    public class FileUtils
    {
        public static DirectoryInfo GetDateTimeStampedDirectoryInfo(string prefix)
        {
            DateTime now = DateTime.Now;
            var dirName = prefix + string.Format("-{0:00}-{1:00}-{2:00}-{3:00}{4:00}{5:00}",
                now.Year - 2000,
                now.Month,
                now.Day,
                now.Hour,
                now.Minute,
                now.Second);
            return new DirectoryInfo(dirName);
        }

        public static FileInfo GetDateTimeStampedFileInfo(string prefix, string suffix)
        {
            DateTime now = DateTime.Now;
            var fileName = prefix + string.Format("-{0:00}-{1:00}-{2:00}-{3:00}{4:00}{5:00}",
                now.Year - 2000,
                now.Month,
                now.Day,
                now.Hour,
                now.Minute,
                now.Second) + suffix;
            return new FileInfo(fileName);
        }

        public static void ThreadSafeCreateDirectory(DirectoryInfo dir)
        {
            while (true)
            {
                if (dir.Exists)
                    break;
                try
                {
                    dir.Create();
                    break;
                }
                catch (IOException)
                {
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        public static void ThreadSafeCopy(FileInfo sourceFile, FileInfo destFile)
        {
            while (true)
            {
                if (destFile.Exists)
                    break;
                try
                {
                    File.Copy(sourceFile.FullName, destFile.FullName);
                    break;
                }
                catch (IOException)
                {
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        public static void ThreadSafeCreateEmptyTextFileIfNotExist(FileInfo file)
        {
            while (true)
            {
                if (file.Exists)
                    break;
                try
                {
                    File.WriteAllText(file.FullName, "");
                    break;
                }
                catch (IOException)
                {
                    System.Threading.Thread.Sleep(50);
                }
            }
        }


        internal static void ThreadSafeAppendAllLines(FileInfo file, string[] strings)
        {
            while (true)
            {
                try
                {
                    File.AppendAllLines(file.FullName, strings);
                    break;
                }
                catch (IOException)
                {
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        public static List<string> GetFilesRecursive(DirectoryInfo dir, string searchPattern)
        {
            List<string> fileList = new List<string>();
            GetFilesRecursiveInternal(dir, searchPattern, fileList);
            return fileList;
        }

        private static void GetFilesRecursiveInternal(DirectoryInfo dir, string searchPattern, List<string> fileList)
        {
            foreach (var file in dir.GetFiles(searchPattern))
                fileList.Add(file.FullName);
            foreach (var subdir in dir.GetDirectories())
                GetFilesRecursiveInternal(subdir, searchPattern, fileList);
        }

        public static List<string> GetFilesRecursive(DirectoryInfo dir)
        {
            List<string> fileList = new List<string>();
            GetFilesRecursiveInternal(dir, fileList);
            return fileList;
        }

        private static void GetFilesRecursiveInternal(DirectoryInfo dir, List<string> fileList)
        {
            foreach (var file in dir.GetFiles())
                fileList.Add(file.FullName);
            foreach (var subdir in dir.GetDirectories())
                GetFilesRecursiveInternal(subdir, fileList);
        }

        public static void CopyStream(Stream source, Stream target)
        {
            const int bufSize = 0x4096;
            byte[] buf = new byte[bufSize];
            int bytesRead = 0;
            while ((bytesRead = source.Read(buf, 0, bufSize)) > 0)
                target.Write(buf, 0, bytesRead);
        }
    }

    public static class PtExtensions
    {
        public static XElement GetXElement(this XmlNode node)
        {
            XDocument xDoc = new XDocument();
            using (XmlWriter xmlWriter = xDoc.CreateWriter())
                node.WriteTo(xmlWriter);
            return xDoc.Root;
        }

        public static XmlNode GetXmlNode(this XElement element)
        {
            using (XmlReader xmlReader = element.CreateReader())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                return xmlDoc;
            }
        }

        public static XDocument GetXDocument(this XmlDocument document)
        {
            XDocument xDoc = new XDocument();
            using (XmlWriter xmlWriter = xDoc.CreateWriter())
                document.WriteTo(xmlWriter);
            XmlDeclaration decl =
                document.ChildNodes.OfType<XmlDeclaration>().FirstOrDefault();
            if (decl != null)
                xDoc.Declaration = new XDeclaration(decl.Version, decl.Encoding,
                    decl.Standalone);
            return xDoc;
        }

        public static XmlDocument GetXmlDocument(this XDocument document)
        {
            using (XmlReader xmlReader = document.CreateReader())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                if (document.Declaration != null)
                {
                    XmlDeclaration dec = xmlDoc.CreateXmlDeclaration(document.Declaration.Version,
                        document.Declaration.Encoding, document.Declaration.Standalone);
                    xmlDoc.InsertBefore(dec, xmlDoc.FirstChild);
                }
                return xmlDoc;
            }
        }

        public static string StringConcatenate(this IEnumerable<string> source)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in source)
                sb.Append(s);
            return sb.ToString();
        }

        public static string StringConcatenate<T>(
            this IEnumerable<T> source,
            Func<T, string> projectionFunc)
        {
            return source.Aggregate(
                new StringBuilder(),
                (s, i) => s.Append(projectionFunc(i)),
                s => s.ToString());
        }

        public static IEnumerable<TResult> PtZip<TFirst, TSecond, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            Func<TFirst, TSecond, TResult> func)
        {
            var ie1 = first.GetEnumerator();
            var ie2 = second.GetEnumerator();
            while (ie1.MoveNext() && ie2.MoveNext())
                yield return func(ie1.Current, ie2.Current);
        }

        public static IEnumerable<IGrouping<TKey, TSource>> GroupAdjacent<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            TKey last = default(TKey);
            bool haveLast = false;
            List<TSource> list = new List<TSource>();

            foreach (TSource s in source)
            {
                TKey k = keySelector(s);
                if (haveLast)
                {
                    if (!k.Equals(last))
                    {
                        yield return new GroupOfAdjacent<TSource, TKey>(list, last);
                        list = new List<TSource>();
                        list.Add(s);
                        last = k;
                    }
                    else
                    {
                        list.Add(s);
                        last = k;
                    }
                }
                else
                {
                    list.Add(s);
                    last = k;
                    haveLast = true;
                }
            }
            if (haveLast)
                yield return new GroupOfAdjacent<TSource, TKey>(list, last);
        }

        private static void InitializeSiblingsReverseDocumentOrder(XElement element)
        {
            XElement prev = null;
            foreach (XElement e in element.Elements())
            {
                e.AddAnnotation(new SiblingsReverseDocumentOrderInfo { PreviousSibling = prev });
                prev = e;
            }
        }

        public static IEnumerable<XElement> SiblingsBeforeSelfReverseDocumentOrder(
            this XElement element)
        {
            if (element.Annotation<SiblingsReverseDocumentOrderInfo>() == null)
                InitializeSiblingsReverseDocumentOrder(element.Parent);
            XElement current = element;
            while (true)
            {
                XElement previousElement = current
                    .Annotation<SiblingsReverseDocumentOrderInfo>()
                    .PreviousSibling;
                if (previousElement == null)
                    yield break;
                yield return previousElement;
                current = previousElement;
            }
        }

        private static void InitializeDescendantsReverseDocumentOrder(XElement element)
        {
            XElement prev = null;
            foreach (XElement e in element.Descendants())
            {
                e.AddAnnotation(new DescendantsReverseDocumentOrderInfo { PreviousElement = prev });
                prev = e;
            }
        }

        public static IEnumerable<XElement> DescendantsBeforeSelfReverseDocumentOrder(
            this XElement element)
        {
            if (element.Annotation<DescendantsReverseDocumentOrderInfo>() == null)
                InitializeDescendantsReverseDocumentOrder(element.AncestorsAndSelf().Last());
            XElement current = element;
            while (true)
            {
                XElement previousElement = current
                    .Annotation<DescendantsReverseDocumentOrderInfo>()
                    .PreviousElement;
                if (previousElement == null)
                    yield break;
                yield return previousElement;
                current = previousElement;
            }
        }

        private static void InitializeDescendantsTrimmedReverseDocumentOrder(XElement element, XName trimName)
        {
            XElement prev = null;
            foreach (XElement e in element.DescendantsTrimmed(trimName))
            {
                e.AddAnnotation(new DescendantsTrimmedReverseDocumentOrderInfo { PreviousElement = prev });
                prev = e;
            }
        }

        public static IEnumerable<XElement> DescendantsTrimmedBeforeSelfReverseDocumentOrder(
            this XElement element, XName trimName)
        {
            if (element.Annotation<DescendantsTrimmedReverseDocumentOrderInfo>() == null)
            {
                var ances = element.AncestorsAndSelf(W.txbxContent).FirstOrDefault();
                if (ances == null)
                    ances = element.AncestorsAndSelf().Last();
                InitializeDescendantsTrimmedReverseDocumentOrder(ances, trimName);
            }
                
            XElement current = element;
            while (true)
            {
                XElement previousElement = current
                    .Annotation<DescendantsTrimmedReverseDocumentOrderInfo>()
                    .PreviousElement;
                if (previousElement == null)
                    yield break;
                yield return previousElement;
                current = previousElement;
            }
        }

        public static string ToStringNewLineOnAttributes(this XElement element)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            StringBuilder stringBuilder = new StringBuilder();
            using (StringWriter stringWriter = new StringWriter(stringBuilder))
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                element.WriteTo(xmlWriter);
            return stringBuilder.ToString();
        }

        public static IEnumerable<XElement> DescendantsTrimmed(this XElement element,
            XName trimName)
        {
            return DescendantsTrimmed(element, e => e.Name == trimName);
        }

        public static IEnumerable<XElement> DescendantsTrimmed(this XElement element,
            Func<XElement, bool> predicate)
        {
            Stack<IEnumerator<XElement>> iteratorStack = new Stack<IEnumerator<XElement>>();
            iteratorStack.Push(element.Elements().GetEnumerator());
            while (iteratorStack.Count > 0)
            {
                while (iteratorStack.Peek().MoveNext())
                {
                    XElement currentXElement = iteratorStack.Peek().Current;
                    if (predicate(currentXElement))
                    {
                        yield return currentXElement;
                        continue;
                    }
                    yield return currentXElement;
                    iteratorStack.Push(currentXElement.Elements().GetEnumerator());
                }
                iteratorStack.Pop();
            }
        }

        public static IEnumerable<TResult> Rollup<TSource, TResult>(
            this IEnumerable<TSource> source,
            TResult seed,
            Func<TSource, TResult, TResult> projection)
        {
            TResult nextSeed = seed;
            foreach (TSource src in source)
            {
                TResult projectedValue = projection(src, nextSeed);
                nextSeed = projectedValue;
                yield return projectedValue;
            }
        }

        public static IEnumerable<TSource> SequenceAt<TSource>(this TSource[] source, int index)
        {
            int i = index;
            while (i < source.Length)
                yield return source[i++];
        }

        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source,
            int count)
        {
            Queue<T> saveList = new Queue<T>();
            int saved = 0;
            foreach (T item in source)
            {
                if (saved < count)
                {
                    saveList.Enqueue(item);
                    ++saved;
                    continue;
                }
                saveList.Enqueue(item);
                yield return saveList.Dequeue();
            }
            yield break;
        }

        public static bool? ToBoolean(this XAttribute a)
        {
            if (a == null)
                return null;
            string s = ((string)a).ToLower();
            if (s == "1") return true;
            if (s == "0") return false;
            if (s == "true") return true;
            if (s == "false") return false;
            if (s == "on") return true;
            if (s == "off") return false;
            return (bool)a;
        }

        private static string GetQName(XElement xe)
        {
            string prefix = xe.GetPrefixOfNamespace(xe.Name.Namespace);
            if (xe.Name.Namespace == XNamespace.None || prefix == null)
                return xe.Name.LocalName.ToString();
            else
                return prefix + ":" + xe.Name.LocalName.ToString();
        }

        private static string GetQName(XAttribute xa)
        {
            string prefix =
                xa.Parent.GetPrefixOfNamespace(xa.Name.Namespace);
            if (xa.Name.Namespace == XNamespace.None || prefix == null)
                return xa.Name.ToString();
            else
                return prefix + ":" + xa.Name.LocalName;
        }

        private static string NameWithPredicate(XElement el)
        {
            if (el.Parent != null && el.Parent.Elements(el.Name).Count() != 1)
                return GetQName(el) + "[" +
                    (el.ElementsBeforeSelf(el.Name).Count() + 1) + "]";
            else
                return GetQName(el);
        }

        public static string StrCat<T>(this IEnumerable<T> source,
            string separator)
        {
            return source.Aggregate(new StringBuilder(),
                       (sb, i) => sb
                           .Append(i.ToString())
                           .Append(separator),
                       s => s.ToString());
        }

        public static string GetXPath(this XObject xobj)
        {
            if (xobj.Parent == null)
            {
                XDocument doc = xobj as XDocument;
                if (doc != null)
                    return ".";
                XElement el = xobj as XElement;
                if (el != null)
                    return "/" + NameWithPredicate(el);
                XText xt = xobj as XText;
                if (xt != null)
                    return null;
                //
                //the following doesn't work because the XPath data
                //model doesn't include white space text nodes that
                //are children of the document.
                //
                //return
                //    "/" +
                //    (
                //        xt
                //        .Document
                //        .Nodes()
                //        .OfType<XText>()
                //        .Count() != 1 ?
                //        "text()[" +
                //        (xt
                //        .NodesBeforeSelf()
                //        .OfType<XText>()
                //        .Count() + 1) + "]" :
                //        "text()"
                //    );
                //
                XComment com = xobj as XComment;
                if (com != null)
                    return
                        "/" +
                        (
                            com
                            .Document
                            .Nodes()
                            .OfType<XComment>()
                            .Count() != 1 ?
                            "comment()[" +
                            (com
                            .NodesBeforeSelf()
                            .OfType<XComment>()
                            .Count() + 1) +
                            "]" :
                            "comment()"
                        );
                XProcessingInstruction pi = xobj as XProcessingInstruction;
                if (pi != null)
                    return
                        "/" +
                        (
                            pi.Document.Nodes()
                            .OfType<XProcessingInstruction>()
                            .Count() != 1 ?
                            "processing-instruction()[" +
                            (pi
                            .NodesBeforeSelf()
                            .OfType<XProcessingInstruction>()
                            .Count() + 1) +
                            "]" :
                            "processing-instruction()"
                        );
                return null;
            }
            else
            {
                XElement el = xobj as XElement;
                if (el != null)
                {
                    return
                        "/" +
                        el
                        .Ancestors()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        NameWithPredicate(el);
                }
                XAttribute at = xobj as XAttribute;
                if (at != null)
                    return
                        "/" +
                        at
                        .Parent
                        .AncestorsAndSelf()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        "@" + GetQName(at);
                XComment com = xobj as XComment;
                if (com != null)
                    return
                        "/" +
                        com
                        .Parent
                        .AncestorsAndSelf()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        (
                            com
                            .Parent
                            .Nodes()
                            .OfType<XComment>()
                            .Count() != 1 ?
                            "comment()[" +
                            (com
                            .NodesBeforeSelf()
                            .OfType<XComment>()
                            .Count() + 1) + "]" :
                            "comment()"
                        );
                XCData cd = xobj as XCData;
                if (cd != null)
                    return
                        "/" +
                        cd
                        .Parent
                        .AncestorsAndSelf()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        (
                            cd
                            .Parent
                            .Nodes()
                            .OfType<XText>()
                            .Count() != 1 ?
                            "text()[" +
                            (cd
                            .NodesBeforeSelf()
                            .OfType<XText>()
                            .Count() + 1) + "]" :
                            "text()"
                        );
                XText tx = xobj as XText;
                if (tx != null)
                    return
                        "/" +
                        tx
                        .Parent
                        .AncestorsAndSelf()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        (
                            tx
                            .Parent
                            .Nodes()
                            .OfType<XText>()
                            .Count() != 1 ?
                            "text()[" +
                            (tx
                            .NodesBeforeSelf()
                            .OfType<XText>()
                            .Count() + 1) + "]" :
                            "text()"
                        );
                XProcessingInstruction pi = xobj as XProcessingInstruction;
                if (pi != null)
                    return
                        "/" +
                        pi
                        .Parent
                        .AncestorsAndSelf()
                        .InDocumentOrder()
                        .Select(e => NameWithPredicate(e))
                        .StrCat("/") +
                        (
                            pi
                            .Parent
                            .Nodes()
                            .OfType<XProcessingInstruction>()
                            .Count() != 1 ?
                            "processing-instruction()[" +
                            (pi
                            .NodesBeforeSelf()
                            .OfType<XProcessingInstruction>()
                            .Count() + 1) + "]" :
                            "processing-instruction()"
                        );
                return null;
            }
        }
    }

    public class ExecutableRunner
    {
        public class RunResults
        {
            public int ExitCode;
            public Exception RunException;
            public StringBuilder Output;
            public StringBuilder Error;
        }

        public static RunResults RunExecutable(string executablePath, string arguments, string workingDirectory)
        {
            RunResults runResults = new RunResults
            {
                Output = new StringBuilder(),
                Error = new StringBuilder(),
                RunException = null
            };
            try
            {
                if (File.Exists(executablePath))
                {
                    using (Process proc = new Process())
                    {
                        proc.StartInfo.FileName = executablePath;
                        proc.StartInfo.Arguments = arguments;
                        proc.StartInfo.WorkingDirectory = workingDirectory;
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.RedirectStandardOutput = true;
                        proc.StartInfo.RedirectStandardError = true;
                        proc.OutputDataReceived +=
                            (o, e) => runResults.Output.Append(e.Data).Append(Environment.NewLine);
                        proc.ErrorDataReceived +=
                            (o, e) => runResults.Error.Append(e.Data).Append(Environment.NewLine);
                        proc.Start();
                        proc.BeginOutputReadLine();
                        proc.BeginErrorReadLine();
                        proc.WaitForExit();
                        runResults.ExitCode = proc.ExitCode;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid executable path.", "exePath");
                }
            }
            catch (Exception e)
            {
                runResults.RunException = e;
            }
            return runResults;
        }
    }

    public class SiblingsReverseDocumentOrderInfo
    {
        public XElement PreviousSibling;
    }

    public class DescendantsReverseDocumentOrderInfo
    {
        public XElement PreviousElement;
    }

    public class DescendantsTrimmedReverseDocumentOrderInfo
    {
        public XElement PreviousElement;
    }

    public class GroupOfAdjacent<TSource, TKey> : IEnumerable<TSource>, IGrouping<TKey, TSource>
    {
        public TKey Key { get; set; }
        private List<TSource> GroupList { get; set; }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<TSource>)this).GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TSource>
            System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
        {
            foreach (var s in GroupList)
                yield return s;
        }

        public GroupOfAdjacent(List<TSource> source, TKey key)
        {
            GroupList = source;
            Key = key;
        }
    }

    public static class PtBucketTimer
    {
        private class BucketInfo
        {
            public int Count;
            public TimeSpan Time;
        }

        private static string LastBucket = null;
        private static DateTime LastTime;
        private static Dictionary<string, BucketInfo> Buckets;

        public static void Bucket(string bucket)
        {
            DateTime now = DateTime.Now;
            if (LastBucket != null)
            {
                TimeSpan d = now - LastTime;
                if (Buckets.ContainsKey(LastBucket))
                {
                    Buckets[LastBucket].Count = Buckets[LastBucket].Count + 1;
                    Buckets[LastBucket].Time += d;
                }
                else
                {
                    Buckets.Add(LastBucket, new BucketInfo()
                    {
                        Count = 1,
                        Time = d,
                    });
                }
            }
            LastBucket = bucket;
            LastTime = now;
        }

        public static string DumpBuckets()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var bucket in Buckets.OrderBy(b => b.Key))
            {
                string ts = bucket.Value.Time.ToString();
                if (ts.Contains('.'))
                    ts = ts.Substring(0, ts.Length - 5);
                string s = bucket.Key.PadRight(60,'-') + "  " + string.Format("{0:00000000}", bucket.Value.Count) + "  " + ts;
                sb.Append(s + Environment.NewLine);
            }
            TimeSpan total = Buckets
                .Aggregate(TimeSpan.Zero, (t, b) => t + b.Value.Time);
            var tz = total.ToString();
            sb.Append(string.Format("Total: {0}", tz.Substring(0, tz.Length - 5)));
            return sb.ToString();
        }

        public static void Init()
        {
            Buckets = new Dictionary<string, BucketInfo>();
        }
    }

    public class XEntity : XText
    {
        public override void WriteTo(XmlWriter writer)
        {
            if (this.Value.Substring(0, 1) == "#")
            {
                string e = string.Format("&{0};", this.Value);
                writer.WriteRaw(e);
            }
            else
                writer.WriteEntityRef(this.Value);
        }
        public XEntity(string value) : base(value) { }
    }
}
