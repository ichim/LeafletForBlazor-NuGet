# StreamLegend

StreamLegend is a beta component (starting with 2.0.0.6) that allows the display of symbols applied through the Appearance() method. This component displays only the symbols of the StreamPoint elements added on the RealTime.Geometric.Points class.

1. Add the LeafletForBlazor namespace to the project, using the @using directive

For this, add

        @using LeafletForBlazor.Components

in the **_Imports.razor** file of the project.

2. In the Blazor page, add StreamLegend as RealTimeMap child:


        <RealTimeMap height="88vh" width="80hw">
            <StreamLegend/>
        </RealTimeMap>


![StreamLegend](https://github.com/user-attachments/assets/63bbeab9-5b55-4f37-8470-9c64931a0296)
