// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:b="http://schemas.openxmlformats.org/officeDocument/2006/bibliography" namespace.
    /// </summary>
    public static class B
    {
        /// <summary>
        /// Defines the XML namespace associated with the b prefix.
        /// </summary>
        public static readonly XNamespace b = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography";

        /// <summary>
        /// Represents the b:AbbreviatedCaseNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbbreviatedCaseNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AbbreviatedCaseNumber = b + "AbbreviatedCaseNumber";

        /// <summary>
        /// Represents the b:AlbumTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlbumTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AlbumTitle = b + "AlbumTitle";

        /// <summary>
        /// Represents the b:Artist XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Artist.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Artist = b + "Artist";

        /// <summary>
        /// Represents the b:Author XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />, <see cref="Source" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Artist" />, <see cref="Author" />, <see cref="BookAuthor" />, <see cref="Compiler" />, <see cref="Composer" />, <see cref="Conductor" />, <see cref="Corporate" />, <see cref="Counsel" />, <see cref="Director" />, <see cref="Editor" />, <see cref="Interviewee" />, <see cref="Interviewer" />, <see cref="Inventor" />, <see cref="NameList" />, <see cref="Performer" />, <see cref="ProducerName" />, <see cref="Translator" />, <see cref="Writer" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Author, AuthorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Author = b + "Author";

        /// <summary>
        /// Represents the b:BookAuthor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookAuthor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName BookAuthor = b + "BookAuthor";

        /// <summary>
        /// Represents the b:BookTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName BookTitle = b + "BookTitle";

        /// <summary>
        /// Represents the b:Broadcaster XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Broadcaster.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Broadcaster = b + "Broadcaster";

        /// <summary>
        /// Represents the b:BroadcastTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BroadcastTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName BroadcastTitle = b + "BroadcastTitle";

        /// <summary>
        /// Represents the b:CaseNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CaseNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName CaseNumber = b + "CaseNumber";

        /// <summary>
        /// Represents the b:ChapterNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChapterNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ChapterNumber = b + "ChapterNumber";

        /// <summary>
        /// Represents the b:City XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: City.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName City = b + "City";

        /// <summary>
        /// Represents the b:Comments XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comments.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Comments = b + "Comments";

        /// <summary>
        /// Represents the b:Compiler XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Compiler.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Compiler = b + "Compiler";

        /// <summary>
        /// Represents the b:Composer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Composer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Composer = b + "Composer";

        /// <summary>
        /// Represents the b:Conductor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Conductor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Conductor = b + "Conductor";

        /// <summary>
        /// Represents the b:ConferenceName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConferenceName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ConferenceName = b + "ConferenceName";

        /// <summary>
        /// Represents the b:Corporate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />, <see cref="Performer" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Corporate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Corporate = b + "Corporate";

        /// <summary>
        /// Represents the b:Counsel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Counsel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Counsel = b + "Counsel";

        /// <summary>
        /// Represents the b:CountryRegion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CountryRegion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName CountryRegion = b + "CountryRegion";

        /// <summary>
        /// Represents the b:Court XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Court.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Court = b + "Court";

        /// <summary>
        /// Represents the b:Day XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Day.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Day = b + "Day";

        /// <summary>
        /// Represents the b:DayAccessed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DayAccessed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DayAccessed = b + "DayAccessed";

        /// <summary>
        /// Represents the b:Department XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Department.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Department = b + "Department";

        /// <summary>
        /// Represents the b:Director XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Director.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Director = b + "Director";

        /// <summary>
        /// Represents the b:Distributor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Distributor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Distributor = b + "Distributor";

        /// <summary>
        /// Represents the b:Edition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Edition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Edition = b + "Edition";

        /// <summary>
        /// Represents the b:Editor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Editor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Editor = b + "Editor";

        /// <summary>
        /// Represents the b:First XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: First.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName First = b + "First";

        /// <summary>
        /// Represents the b:Guid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GuidString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Guid = b + "Guid";

        /// <summary>
        /// Represents the b:Institution XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Institution.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Institution = b + "Institution";

        /// <summary>
        /// Represents the b:InternetSiteTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InternetSiteTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName InternetSiteTitle = b + "InternetSiteTitle";

        /// <summary>
        /// Represents the b:Interviewee XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Interviewee.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Interviewee = b + "Interviewee";

        /// <summary>
        /// Represents the b:Interviewer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Interviewer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Interviewer = b + "Interviewer";

        /// <summary>
        /// Represents the b:Inventor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Inventor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Inventor = b + "Inventor";

        /// <summary>
        /// Represents the b:Issue XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Issue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Issue = b + "Issue";

        /// <summary>
        /// Represents the b:JournalName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: JournalName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName JournalName = b + "JournalName";

        /// <summary>
        /// Represents the b:Last XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Last.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Last = b + "Last";

        /// <summary>
        /// Represents the b:LCID XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LcId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LCID = b + "LCID";

        /// <summary>
        /// Represents the b:Medium XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Medium.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Medium = b + "Medium";

        /// <summary>
        /// Represents the b:Middle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Middle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Middle = b + "Middle";

        /// <summary>
        /// Represents the b:Month XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Month.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Month = b + "Month";

        /// <summary>
        /// Represents the b:MonthAccessed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MonthAccessed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MonthAccessed = b + "MonthAccessed";

        /// <summary>
        /// Represents the b:NameList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Artist" />, <see cref="Author" />, <see cref="BookAuthor" />, <see cref="Compiler" />, <see cref="Composer" />, <see cref="Conductor" />, <see cref="Counsel" />, <see cref="Director" />, <see cref="Editor" />, <see cref="Interviewee" />, <see cref="Interviewer" />, <see cref="Inventor" />, <see cref="Performer" />, <see cref="ProducerName" />, <see cref="Translator" />, <see cref="Writer" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NameList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName NameList = b + "NameList";

        /// <summary>
        /// Represents the b:NumberVolumes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberVolumes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName NumberVolumes = b + "NumberVolumes";

        /// <summary>
        /// Represents the b:Pages XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Pages = b + "Pages";

        /// <summary>
        /// Represents the b:PatentNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PatentNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName PatentNumber = b + "PatentNumber";

        /// <summary>
        /// Represents the b:Performer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Corporate" />, <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Performer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Performer = b + "Performer";

        /// <summary>
        /// Represents the b:PeriodicalTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PeriodicalTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName PeriodicalTitle = b + "PeriodicalTitle";

        /// <summary>
        /// Represents the b:Person XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="First" />, <see cref="Last" />, <see cref="Middle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Person.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Person = b + "Person";

        /// <summary>
        /// Represents the b:ProducerName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProducerName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ProducerName = b + "ProducerName";

        /// <summary>
        /// Represents the b:ProductionCompany XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProductionCompany.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ProductionCompany = b + "ProductionCompany";

        /// <summary>
        /// Represents the b:PublicationTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PublicationTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName PublicationTitle = b + "PublicationTitle";

        /// <summary>
        /// Represents the b:Publisher XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Publisher.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Publisher = b + "Publisher";

        /// <summary>
        /// Represents the b:RecordingNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecordingNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName RecordingNumber = b + "RecordingNumber";

        /// <summary>
        /// Represents the b:RefOrder XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ReferenceOrder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName RefOrder = b + "RefOrder";

        /// <summary>
        /// Represents the b:Reporter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Reporter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Reporter = b + "Reporter";

        /// <summary>
        /// Represents the b:ShortTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShortTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ShortTitle = b + "ShortTitle";

        /// <summary>
        /// Represents the b:Source XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Sources" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="AbbreviatedCaseNumber" />, <see cref="AlbumTitle" />, <see cref="Author" />, <see cref="BookTitle" />, <see cref="Broadcaster" />, <see cref="BroadcastTitle" />, <see cref="CaseNumber" />, <see cref="ChapterNumber" />, <see cref="City" />, <see cref="Comments" />, <see cref="ConferenceName" />, <see cref="CountryRegion" />, <see cref="Court" />, <see cref="Day" />, <see cref="DayAccessed" />, <see cref="Department" />, <see cref="Distributor" />, <see cref="Edition" />, <see cref="Guid" />, <see cref="Institution" />, <see cref="InternetSiteTitle" />, <see cref="Issue" />, <see cref="JournalName" />, <see cref="LCID" />, <see cref="Medium" />, <see cref="Month" />, <see cref="MonthAccessed" />, <see cref="NumberVolumes" />, <see cref="Pages" />, <see cref="PatentNumber" />, <see cref="PeriodicalTitle" />, <see cref="ProductionCompany" />, <see cref="PublicationTitle" />, <see cref="Publisher" />, <see cref="RecordingNumber" />, <see cref="RefOrder" />, <see cref="Reporter" />, <see cref="ShortTitle" />, <see cref="SourceType" />, <see cref="StandardNumber" />, <see cref="StateProvince" />, <see cref="Station" />, <see cref="Tag" />, <see cref="Theater" />, <see cref="ThesisType" />, <see cref="Title" />, <see cref="Type" />, <see cref="URL" />, <see cref="Version" />, <see cref="Volume" />, <see cref="Year" />, <see cref="YearAccessed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Source.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Source = b + "Source";

        /// <summary>
        /// Represents the b:Sources XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="Source" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.SelectedStyle" />, <see cref="NoNamespace.StyleName_" />, <see cref="NoNamespace.URI_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sources.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Sources = b + "Sources";

        /// <summary>
        /// Represents the b:SourceType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SourceType = b + "SourceType";

        /// <summary>
        /// Represents the b:StandardNumber XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StandardNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName StandardNumber = b + "StandardNumber";

        /// <summary>
        /// Represents the b:StateProvince XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StateProvince.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName StateProvince = b + "StateProvince";

        /// <summary>
        /// Represents the b:Station XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Station.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Station = b + "Station";

        /// <summary>
        /// Represents the b:Tag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Tag = b + "Tag";

        /// <summary>
        /// Represents the b:Theater XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Theater.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Theater = b + "Theater";

        /// <summary>
        /// Represents the b:ThesisType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThesisType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ThesisType = b + "ThesisType";

        /// <summary>
        /// Represents the b:Title XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Title.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Title = b + "Title";

        /// <summary>
        /// Represents the b:Translator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Translator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Translator = b + "Translator";

        /// <summary>
        /// Represents the b:Type XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PatentType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Type = b + "Type";

        /// <summary>
        /// Represents the b:URL XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UrlString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName URL = b + "URL";

        /// <summary>
        /// Represents the b:Version XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Version.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Version = b + "Version";

        /// <summary>
        /// Represents the b:Volume XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Volume.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Volume = b + "Volume";

        /// <summary>
        /// Represents the b:Writer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Author" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="NameList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Writer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Writer = b + "Writer";

        /// <summary>
        /// Represents the b:Year XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Year.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Year = b + "Year";

        /// <summary>
        /// Represents the b:YearAccessed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Source" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: YearAccessed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName YearAccessed = b + "YearAccessed";
    }
}
