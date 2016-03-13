@echo off
cls
if not exist packages\FAKE\tools\Fake.exe (
  .nuget\nuget.exe install FAKE -OutputDirectory packages -ExcludeVersion -Source "https://nuget.org/api/v2/"
)
packages\FAKE\tools\FAKE.exe build.fsx %*
