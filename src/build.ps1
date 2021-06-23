function Reset-Templates{
    [cmdletbinding()]
    param(
        [string]$templateEngineUserDir = (join-path -Path $env:USERPROFILE -ChildPath .templateengine)
    )
    process{
        'resetting dotnet new templates. folder: "{0}"' -f $templateEngineUserDir | Write-host
        get-childitem -path $templateEngineUserDir -directory | Select-Object -ExpandProperty FullName | remove-item -recurse -force
        &dotnet new --debug:reinit
    }
}

Reset-Templates
nuget.exe pack .\GorillaTagModTemplate.nuspec -NoDefaultExcludes -OutputDirectory .\nupkg
dotnet new --install C:\Users\craig\source\repos\GorillaTagModTemplate\src\nupkg\Graic.Template.GorillaTagModTemplate.nuspec.1.0.0.nupkg