# DevOps.Primitives.SourceGraph.Templates

Source-code generation template abstractions

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-primitives-sourcegraph-templates.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-primitives-sourcegraph-templates)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Primitives.SourceGraph.Templates.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Primitives.SourceGraph.Templates)

## Description

Contains template abstractions for source-code generation

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Primitives.SourceGraph](https://github.com/CDorst/DevOps.Primitives.SourceGraph) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-primitives-sourcegraph.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-primitives-sourcegraph) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Primitives.SourceGraph.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Primitives.SourceGraph)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Primitives.SourceGraph.Templates](https://www.nuget.org/packages/CDorst.DevOps.Primitives.SourceGraph.Templates)

## Version

1.0.0
