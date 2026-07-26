# Map with LeafletForBlazor Nuget package

## Configuring Blazor project

Install package

    NuGet\Install-Package LeafletForBlazor

Add namespace into _Imports.razor project file:

    @using LeafletForBlazor

Add Map into Blazor page

    <Map 
        width="600px" 
        height="600px"
    ></Map>
