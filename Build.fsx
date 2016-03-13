// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------
#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.ReleaseNotesHelper
open Fake.Testing
open System
open System.IO
open System.Text.RegularExpressions

// Read additional information from the release notes document
Environment.CurrentDirectory <- __SOURCE_DIRECTORY__
let release = parseReleaseNotes (IO.File.ReadAllLines "RELEASE_NOTES.md")

// Replace assembly and file versions with the right version
Target "AssemblyInfo" (fun _ ->
  let fileName = "DocumentFormat.OpenXml/src/ofapi/Properties/AssemblyInfo.cs"
  let fileContent = File.ReadAllText(fileName)

  let regex = new Regex(@"Assembly.*Version\(""(?<version>(\d+\.?){4})""\)");
  let result = regex.Replace(fileContent, fun m ->
    m.ToString().Replace(m.Groups.["version"].ToString(), release.AssemblyVersion))

  if result <> fileContent
    then File.WriteAllText(fileName, result)
)

// Copies binaries from default VS location to  bin folder
Target "CopyBinaries" (fun _ ->
    let targerDir = "bin/lib"
    CreateDir targerDir

    !! "DocumentFormat.OpenXml/bin/Release/*.dll"
    |> Seq.iter (CopyFile targerDir)
)


// --------------------------------------------------------------------------------------
// Clean build results & restore NuGet packages

Target "RestorePackages" RestorePackages

Target "Clean" (fun _ ->
    CleanDirs ["bin"]
)

// --------------------------------------------------------------------------------------
// Build library & test project

Target "Build" (fun _ ->
    !! ("Open-XML-SDK.sln")
#if MONO
    |> MSBuildReleaseExt "" [ ("DefineConstants","MONO") ] "Rebuild"
#else
    |> MSBuildRelease "" "Rebuild"
#endif
    |> ignore
)

// --------------------------------------------------------------------------------------
// Run the unit tests using test runner

Target "RunTests" (fun _ ->
    !! "**/bin/Release/*.Tests.dll"
    |> xUnit2 (fun p ->
        { p with
            Silent  = false
            TimeOut = TimeSpan.FromMinutes 30.
        })
)

// --------------------------------------------------------------------------------------
// Build a NuGet package

Target "NuGet" (fun _ ->
    NuGet (fun p ->
        { p with
            Version = release.NugetVersion
            ReleaseNotes = String.Join(Environment.NewLine, release.Notes)
            WorkingDir = "bin"
            OutputPath = "bin" })
        ("Open-XML-SDK.nuspec")
)


// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build <Target>' to override

Target "All" DoNothing
Target "Release" DoNothing

"Clean"
  ==> "RestorePackages"
  ==> "AssemblyInfo"
  ==> "Build"
  ==> "CopyBinaries"
  ==> "RunTests"
  ==> "All"

"All"
  ==> "NuGet"
  ==> "Release"

RunTargetOrDefault "All"
