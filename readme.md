# Gorilla Tag Mod Template

.NET Core Project Template for PCVR Gorilla Tag Mods

## Usage

To install the template, run
`dotnet new --install Graic.Template.GorillaTagModTemplate.nuspec` from the command line.
The template can be used from the command line by running `dotnet new gtmod -A [Authorname]`. Command line help for the template can be found by running `dotnet new gtmod -h`.

To enable the template to be used in Visual Studio, open Visual Studio without code and navigate to `Tools/Options/Environment/Preview Features`.
Make sure that "Show all .NET Core Templates in the New Project Dialog" is checked.
The template should then appear in Visual Studio Templates, under "Gorilla Tag Mod".

## Parameters

- **Project Name** is used as the name of the mod. Do not put spaces in the project name, as it will prevent the mod from loading.
- **Author Name** is the name of the author, used for the plugin info.
- **Gorilla Tag Location** is the path to the place where Gorilla Tag is installed. By default, it is `C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag`. This is used for copying the mod on build and for referencing game files.
