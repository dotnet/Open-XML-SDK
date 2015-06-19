Open-XML-SDK
============

The Open XML SDK provides open-source libraries for working with Open XML
Documents (DOCX, XLSX, and PPTX).  It supports scenarios such as:

- High-performance generation of word-processing documents, spreadsheets,
  and presentations
- Document modification, such as removing tracked revisions or removing
  unacceptable content from documents
- Data and content querying and extraction, such as transformation from
  DOCX to HTML, or extraction of data from spreadsheets

Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.
Licensed under the Apache License, Version 2.0.
See License.txt in the project root for license information.

Documentation
=============

This source-code is similar to the release of the 2.5 SDK and the documentation
available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the
conceptual documentation for public review / contributions.  A copy of
the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

The official repository for this SDK made the build a bit complicated. Only a
few small changes to make the SDK solution build with either Visual Studio on
Windows or using xbuild provided by Mono.