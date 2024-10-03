Open XML Package Editor Power Tool for Visual Studio
=============
This Power Tool is a Visual Studio add-in that provides an easy way to parse and edit Open Packaging Conventions files, including Word, Excel, PowerPoint and Visio documents. This Power Tool enables you to do the following tasks:

* Open any Open XML Package file or XPS Package file directly in Visual Studio 2010SP1/2012/2013/2015
* Browse the contents of Package files in a tree view
* Open any XML part directly in Visual Studio's rich XML editor
* Add or remove parts and relationships directly in the user interface
* Import and export part contents to and from files
* Detect when a Package file that is opened in Visual Studio is modified externally. The Power Tool prompts the user to reload the file without having to close any open XML part editors
* Create new Office Packages from a set of templates using Visual Studio's File > New dialog

The project is designed to be edited in VS2010SP1, but can be one-way converted to VS2012, VS2013 or 2015.

To compile this Visual Studio add-on you need the [SDK for Visual Studio 2010 SP1] (http://www.microsoft.com/en-us/download/details.aspx?id=21835). **If you are getting mysterious errors about loading the csproj, you most likely haven't installed the SDK**.

The compiled version of this Power Tool is available for [download on the Visual Studio Gallery] (http://visualstudiogallery.msdn.microsoft.com/450a00e3-5a7d-4776-be2c-8aa8cec2a75b) - please note that currently downloadable VSIX version does not support VS2015; update is in progress.


This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
