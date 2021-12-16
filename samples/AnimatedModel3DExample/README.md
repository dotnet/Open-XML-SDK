# Animated Model 3D

This sample code shows how to add an Animated Model 3D to a PowerPoint file. When adding an Animated Model 3D to a presentation, the SDK needs a .png file of the 3D image and a .glb file, which is a 3D file format for rendering in 3D.

The important method in Program.cs is:
```csharp
public static void InsertAnimatedModel3D(string pptxPath, string pngPath, string glbPath)
```
