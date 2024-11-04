# StreamLegend

StreamLegend is a beta component (starting with 2.2.0.6) that allows the display of symbols applied through the Appearance() method. This component displays only the symbols of the StreamPoint elements added on the RealTime.Geometric.Points class.

1. Add the LeafletForBlazor namespace to the project, using the @using directive

For this, add

        @using LeafletForBlazor.Components

in the **_Imports.razor** file of the project.

2. In the Blazor page, add StreamLegend as RealTimeMap child:


        <RealTimeMap height="88vh" width="80hw">
            <StreamLegend/>
        </RealTimeMap>

![streamLegend@basic22](https://github.com/user-attachments/assets/4de7a0a0-ad00-4efc-ab6f-7bf1f9524335)

## Initialization Parameters

The StreamLegend can be customized using the contentStyleInitialization parameter:

        <StreamLegend contentStyleInitialization="@contentStyle" />

Where:

        @code{
            StreamLegend.ContentStyle contentStyle = new StreamLegend.ContentStyle(){};
            }


**contentStyleInitialization** parameter allows customizing the legend labels and their position on the canvas (padding).

### Padding (position on the canvas)

The items of the legend can be displayed at customizable distances from the edges of the canvas:

| Paramerer | Default value | Description |
|----|----|----|
| paddingLeft | 10 | padding from the left canvas edge |
| paddingRight | 10 | padding from the right canvas edge |
| paddingTop | 10 | padding from the top canvas edge |
_values ​​are in pixels_


            StreamLegend.ContentStyle contentStyle = new StreamLegend.ContentStyle()
            {
                 contentPadding = new StreamLegend.ContentPadding()
                 {
                     paddingLeft = 20,  //values ​​in pixels, default value is 10px
                     paddingRight = 20, //values ​​in pixels, default value is 10px
                     paddingTop = 15    //values ​​in pixels, default value is 10px
                 }
            };

        
