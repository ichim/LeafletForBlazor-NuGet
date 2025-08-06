# ![LealletForBlazor32](https://user-images.githubusercontent.com/8348463/224698821-8768d8af-46ea-462a-a603-a7adf9095594.png) Leaflet Map for Blazor

 > You can quickly add a map to the blazor page. 
 > Starting with version 2.0.0, LeafletForBlazor provide you a new control (RealTimeMap) for real time data displaying and analysis. Data can come from various (provided by various) tracking devices: router (static) and mobile phone, GPS of the fleet (dynamic) etc. 

[NuGet Package](https://www.nuget.org/packages/LeafletForBlazor#versions-body-tab)

This package is under development, but I will keep the code compatible from one version to another.

You can find more information:

 - [LeafletForBlazor GitHub](https://github.com/ichim/LeafletForBlazor-NuGet)
 - [Youtube channel](https://www.youtube.com/@step-by-step-cs)
 - [Youtube LeafletForBlazor playlist](https://youtube.com/playlist?list=PLDpzfV5MtMji-wml7dm5S80hOc1Nzywtc)


 _____________

# What's New


| Title | News Description |
| ---- | ---- |
| [Clustering StreamPoint Collection](#clustering) | Displaying clusters for a StreamPoint Collection |


>working with charts
![chart06](https://github.com/user-attachments/assets/cc768477-69e3-432e-9750-2000b221130b)
[_Configuring charts on tooltips / GeoJSON files_](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/tooltips%20Chart#readme)

# New examples code

<table>
    <tr>
        <td> <b>Example</b> </td>
        <td><b>Description</b></td>
    </tr>
    <tr>
        <td colspan="2"><font color = "green"><b>Real Time Data/StreamPoint collection</b></font></td>
    </tr>
     <tr>
        <td><a href = "https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Query%20RealTimeMap/Click%20and%20Query%20StreamPoint%20collection">Click and Query StreamPoint Collection</a></td>
        <td><font size = "2px">Displays the attributes of a StreamPoint from RealTimeMap selected by clicking. Query StreamPoint collection based on distance</font></td>
    </tr>
    <tr>
        <td><a href = "https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/more%20about%20Appearance/changeAppearanceOnZoom#readme">Appearance and Zoom Level - Simplify</a></td>
        <td><font size = "2px">The symbols used in displaying the points must be correlated with the zoom level. Thus, we can use icons when displaying a small area and points when displaying an extended area</font></td>
    </tr>
    <tr>
        <td><a href = "https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/StreamPoint%20tooltip/RTM%20tooltip%20hierarchical%20attr#readme">Tooltips and custom properties</a></td>
        <td><font size = "2px">A StreamPoint can use custom properties stored on value. These custom properties can be used to define tooltips.</font></td>
    </tr>
   <tr>
        <td colspan="2"><font color = "green"><b>Analisys</b></font></td>
    </tr>
    <tr>
        <td><a href="https://github.com/ichim/LeafletForBlazorTracking">Tracking and Monitoring points position</a></td>
        <td><font size = "2px">Highlighting, displaying information and alert when points from the map are close to each other at distances less than or equal to a threshold value.</font></td>
    </tr>
      <tr>
        <td colspan="2"><font color = "green"><b>GeoJSON file</b></font></td>
    </tr>
    <tr>
        <td><a href="https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/config%20tooltip%20from%20file">Configuring custom tooltips</a></td>
        <td><font size = "2px">We can configure the content of the tooltips based on the custom properties of a GeoJSON items</font></td>
    </tr>
    <tr>
        <td><a href="https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20case">Appearance and switch/cases</a></td>
        <td><font size = "2px">You can create distinct symbolization classes based on the properties of GeoJSON file items. Apply zoom levels visibility.</font></td>
    </tr>
     <tr>
        <td><a href="https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20icons">png.* Icons, switch/cases and vesibility zoom levels</a></td>
        <td><font size = "2px">You can create distinct symbolization classes based on the properties of GeoJSON file items. When the shape is point type, you can icons (*.png) for display in the map. Apply zoom levels visibility.</font></td>
    </tr>
    <tr>
        <td><a href="https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/tooltips%20Chart">Configuring charts on tooltips</a></td>
        <td><font size = "2px">LeafletForBlazor's GeoJSON files allow you to configure charts to be displayed on map tooltips.</font></td>
    </tr>
    <tr>
        <td colspan="2"><font color = "green"><b>RealTimeMap components</b></font></td>
    </tr>
	<tr>
        <td><a href="https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20Components/StreamLegend">StreamLegend component</a></td>
        <td><font size = "2px">StreamLegend is a component (starting with 2.2.0.6) that allows the display of symbols applied through the Appearance() method. This component displays only the symbols of the StreamPoint elements added on the RealTime.Geometric.Points class.</font></td>
    </tr>
</table>


![GeoJSON@appearance20](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/81f4ea40-55b5-4dd5-9270-c2643aa47dd6)



-------------------------

# RealTimeMap Blazor component tutorial

> RealTimeMap control is optimized for working with streaming data. This control will load data using multiple concurrent calls (separate threads of execution).


## Basic configuration

1. add LeafletForBlazor NuGet package:

Using Visual Studio _interface_:

 - Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...
 
 > Search for "LeafletForBlazor" and add the package to the project or solution.

 Or using Visual Studio _console_:

 - Tools -> NuGet Package Manager -> Package Manager Console

       NuGet\Install-Package LeafletForBlazor

2. add the LeafletForBlazor namespace to the project, using the @using directive

For this, add

        @using LeafletForBlazor

in the **_Imports.razor** file of the project.

3. add RealTimeMap control into Blazor Page:

                <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"></RealTimeMap>

## Working with loading parameters

Map loading parameters can be defined using the **LoadParameters** class. This class allows you to define: the location of the center of the view (default) of the map, the zoom level and others.

1. add in code block loading parameters:


        @code{
            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()  //general map settings
                {
                    location = new RealTimeMap.Location()
                    {
                        latitude = 44.4501715,      
                        longitude = 26.1107672,
                    },
                    zoomLevel = 18
                };
            }

2. set the loading parameters (default map parameters) to the **RealTimeMap** control:

       <RealTimeMap Parameters="parameters" height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"></RealTimeMap>


## RealTimeMap and basemap

You can add various basemaps to the list of map layers.

Blazor page

    <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" Parameters="@parameters"></RealTimeMap>

Code block

    @code{
        static string openCycleMapAPIKey = "";
        RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            {
                basemap = new RealTimeMap.Basemap()
                {
                    basemapLayers = new List<RealTimeMap.BasemapLayer>()
                    {
                        new RealTimeMap.BasemapLayer()
                        {
                            url = "http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png",
                            attribution = "©Open Street Map",
                            title = "Open Street Map",
                            detectRetina = true
                        },
                        new RealTimeMap.BasemapLayer()
                        {
                            url = "https://tile.opentopomap.org/{z}/{x}/{y}.png",
                            attribution = "Open Topo",
                            title = "Open Topo",
                            detectRetina = true
                        },
                        new RealTimeMap.BasemapLayer()
                        {
                            url = "https://tile.thunderforest.com/cycle/{z}/{x}/{y}.png?apikey=" + openCycleMapAPIKey,
                            attribution = "©Open Cycle Map",
                            title = "Open Cycle Map"
                        },

                    }

                },
           }


## RealTimeMap and default map attribution

You can set what the default attribution of the map is.

Example code

        <RealTimeMap Parameters="@parameters" />

        @code {
            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
                {
                    defaultAttribution = new RealTimeMap.DefaultAttribution()
                    {
                        has = true,
                       defaultHtmlContent = "<img src = \"http://localhost:5236/favicon.png\"></img>"
                    }

                };
            }



## RealTimeMap and interaction options

You can change the behavior of the map to various mouse actions:

Blazor page

    <RealTimeMap height="462px" width="462px" Parameters="@parameters" Options="options"></RealTimeMap>

Code block

    @code{
        RealTimeMap.MapOptions options = new RealTimeMap.MapOptions()
            {
                interactionOptions = new RealTimeMap.InteractionOptions()
                {
                    doubleClickZoom = true,
                    shiftBoxZoom = false
                }
            };
        }

## View class

This class allows you to modify and read the RealTimeMap loading parameters:

| **Property** | **Direction** | **Description** |
| --------- | ----------- | -------- |
| setZoomLevel | to | set RealTimeMap zoom level |
| setMinZoomLevel | to | set RealTimeMap minimum zoom level |
| setMaxZoomLevel | to | set RealTimeMap maximum zoom level |
| setCenter | to | set RealTimeMap center of map view (location) |
| setBounds | to | set maxim bounds (extent) of map view |


### Exemple code

Blazor page

    <RealTimeMap @ref="realTimeMap" height="460px" width="460px"></RealTimeMap>

Code block

    @code{
        RealTimeMap realTimeMap = new RealTimeMap();
        public void onZoomLevel()
        {
            realTimeMap.View.setZoomLevel = 10;
        }

        public void onLocation()
        {
            realTimeMap.View.setCenter = new RealTimeMap.Location()
            {
                    latitude = 40.712,
                    longitude = -74.227
            };
        }

        public void onBounds()
        {
            realTimeMap.View.setBounds = new RealTimeMap.Bounds()
                {
                    northEast = new RealTimeMap.Location() { latitude = 44.119016922388475, longitude = 25.5423343754357 },
                    southWest = new RealTimeMap.Location() { latitude = 44.06574292386291, longitude = 25.67686807545283 }
                };
        }
   
    }

## Map class

### Attributions class

It is a child class of the Map class that provides access to Map Attribution.

Example code

1. Add attribution 

        public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
        {
            args.sender.Map.Attributions.add("<img src = \"http://localhost:5236/favicon.png\"></img>");
        }

2. Remove existing attribution

        public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
        {
            args.sender.Map.Attributions.add("<img src = \"http://localhost:5236/favicon.png\"></img>");
        }

## RealTimeMap control events

| **Events**   | **Description**                                              |
| ---------------- | ---------------------------------------------------- |
| [**OnAfterMapLoaded**](#onaftermaploaded) | triggered after the _map has been completely loaded_ on the Blazor page|
| [**OnClickMap**](#onclickmap) |event is triggered after the user clicks left on the map. This control will return the **location** of the clicked point|
| [**OnDoubleClickMap**](#ondoubleclickmap) | event is triggered after the user double clicks (left) on the map. This control will return the **location** of the double clicked point|
| [**OnMouseDownMap**](#onmousedownmap) | event is triggered when the left button is pressed (contact open). This control will return the **location** of the clicked down (left pressed) point|
| [**OnMouseUpMap**](#onmouseupmap) | event is triggered after the left button is released (contact close). This control will return the **location** of the clicked up (left released) point|
| [**OnZoomLevelEndChange**](#onzoomlevelendchange) | event is triggered after the map has been zoom change ended|
| [**OnMouseMove**](#onmousemove) | event is triggered when mouse move and return the **location** of pointer in map|
| [**OnStreamPointAppearanceChange**](#onstreampointappearancechange) | event is triggered every time the Appearance() method from the Geometric.Points class is called|

### OnAfterMapLoaded

> **OnAfterMapLoaded (MapEventArgs value)** event is triggered after the map has been completely loaded on the blazor page. This event can be used when loading geometric elements (e.g. points), setting the appearance, configuring analyzes, etc.

#### **OnAfterMapLoaded** event arguments

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._zoomLevel_**: is the value of the zoom level of the loaded **RealTimeMap**
1. **value._centerOfView_**: is the location of the center of the current view in coordinates (latitude, longitude)
1. **value._bounds_**: the coordinates of the northeast (upper right) and southwest (lower left) corners of the displayed map extent


       public async Task onAfterMapLoaded(RealTimeMap.MapEventArgs value)
        {
            Console.WriteLine(value.bounds.northEast.latitude);
            Console.WriteLine(value.bounds.northEast.longitude);
            Console.WriteLine(value.bounds.southWest.latitude);
            Console.WriteLine(value.bounds.southWest.longitude);
        }


#### Example code

        //Blazor Page
        <RealTimeMap height="620px" width="820px" OnAfterMapLoaded="onLoadControl" ></RealTimeMap>
        //Code block
        @code{
                public async Task onLoadControl(RealTimeMap.MapEventArgs value)
                {
                    //where value.sender is RealTimeMap control reference
                }
            }


### OnClickMap

> **OnClickMap** event is triggered after the user clicks left on the map. This control will return the **location** of the clicked point.

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._location_**: location of point

#### Example code

        //Blazor Page
        <RealTimeMap height="620px" width="820px" OnClickMap="onClickMap"></RealTimeMap>
        //Code block
        @code{
                public void onClickMap(RealTimeMap.ClicksMapArgs value)
                {
                    //where value.sender is RealTimeMap control reference
                    Console.WriteLine(value.location.latitude);
                    Console.WriteLine(value.location.longitude);
                }
            }

### OnDoubleClickMap

> **OnDoubleClickMap** event is triggered after the user double clicks (left) on the map. This control will return the **location** of the double clicked point.

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._location_**: location of point

#### Example code

        //Blazor Page
        <RealTimeMap height="620px" width="820px" OnDoubleClickMap="onDoubleClickMap"></RealTimeMap>
        //Code block
        @code{
                public void onDoubleClickMap(RealTimeMap.ClicksMapArgs value)
                {
                    //where value.sender is RealTimeMap control reference
                    Console.WriteLine(value.location.latitude);
                    Console.WriteLine(value.location.longitude);
                }
            }


### OnMouseDownMap

> **OnMouseDownMap** event is triggered when the left button is pressed (contact open). This control will return the **location** of the clicked down (left pressed) point.

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._location_**: location of point

#### Example code

        //Blazor Page
        <RealTimeMap height="620px" width="820px" OnMouseDownMap="onMouseDownMap"></RealTimeMap>
        //Code block
        @code{
                public void onMouseDownMap(RealTimeMap.ClicksMapArgs value)
                {
                    //where value.sender is RealTimeMap control reference
                    Console.WriteLine(value.location.latitude);
                    Console.WriteLine(value.location.longitude);
                }
            }

### OnMouseUpMap

> **OnMouseUpMap** event is triggered after the left button is released (contact close). This control will return the **location** of the clicked up (left released) point.

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._location_**: location of point

#### Example code

        //Blazor Page
        <RealTimeMap height="620px" width="820px" OnMouseUpMap="onMouseUpMap"></RealTimeMap>
        //Code block
        @code{
                public void onMouseUpMap(RealTimeMap.ClicksMapArgs value)
                {
                    //where value.sender is RealTimeMap control reference
                    Console.WriteLine(value.location.latitude);
                    Console.WriteLine(value.location.longitude);
                }
            }

### OnZoomLevelEndChange

> **OnZoomLevelEndChange (MapZoomEventArgs value)** event is triggered after the map has been zoom change ended. 

**OnZoomLevelEndChange** event arguments

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._zoomLevel_**: is the value of the zoom level of the loaded **RealTimeMap**
1. **value._centerOfView_**: is the location of the center of the current view in coordinates (latitude, longitude)

#### Example code


    //Blazor Page
    <RealTimeMap  OnZoomLevelEndChange="@OnZoomLevel" width="460px" height="462px" />
    //Code block
    @code{
        public async Task OnZoomLevel(RealTimeMap.MapZoomEventArgs args)
        {
            Console.WriteLine(args.zoomLevel);
        }
    }

### OnMouseMove

> **OnMouseMove** event is triggered after the usermove pointer mouse on RealTimeMap and return the **location** of the mouse pointer.

1. **value._sender_**: is the reference to the **RealTimeMap** control
1. **value._location_**: location of the mouse pointer

#### Example code

Blazor page

    <RealTimeMap @ref="realTimeMap" height="460px" width="460px" OnMouseMove="@onMouseMove"></RealTimeMap>

Code block

    @code{
            RealTimeMap realTimeMap = new RealTimeMap();
            public void onMouseMove(RealTimeMap.ClicksMapArgs args)
            {
                Console.WriteLine($"{args.location.latitude} / {args.location.longitude}");
            }
        }

### OnStreamPointAppearanceChange

 **OnStreamPointAppearanceChange** event is triggered every time the Appearance() method from the Geometric.Points class is called.

#### Example code

Blazor page

    <RealTimeMap @ref="realTimeMap" height="88vh" width="80hw" OnStreamPointAppearanceChange="@onStreamPointAppearanceChange"/>

Code block

    @code{
            private void onStreamPointAppearanceChange(RealTimeMap.StreamPointsAppearanceArgs args)
            {
                //where args.sender is RealTimeMap control reference
                RealTimeMap.StreamPointsAppearance[] result = args.pointsAppearance as RealTimeMap.StreamPointsAppearance[];
            }
        }

where the **StreamPointsAppearance** class definition is:

        public class StreamPointsAppearance
        {
            public Guid[] guids { get; set; }
            public double[][] coordinates { get; set; }     //latitude and longitude
            public string type { get; set; }
            public RealTimeMap.PointSymbol symbol { get; set; }
            public RealTimeMap.PointIcon icon { get; set; }
        }


## Working with a single point (ex. my position)

> movePoint(args...) method allows displaying the position of a single point. The method can be used to monitor one's own position.

The movePoint() method accepts from one argument to three arguments:
 - coordinate (double[2]): point coordinate. For example: realTimeMap.movePoint([44.4502578, 26.1108199]). Latitude and Longitude in degrees, geographical coordinates;
 - render symbol (PointSymbol/PointIcon): the point can be displayed with a circle (PointSymbol) or an icon/*.png (PointIcon);
 - tooltip (PointTooltip): configuring a tooltip with various information;

 |**Method**|**Description**|**Map Results**|
 |:---|:---|:---|
 |mapPoint(double[])|The point is given by coordinate: latitude and longitude|The default **Leaflet** marker will displayed on the map|
 |mapPoint(double[],[PointTooltip](#pointtooltip))|The point is given by coordinate: latitude and longitude. **movePoint** allows the definition of tooltip|The default **Leaflet** marker will be displayed on the map. The point will display a tooltip whose content is defined by **PointTooltip**|
 |mapPoint(double[],[PointSymbol](#pointsymbol))|The point is given by coordinate: latitude and longitude. **movePoint** allows a custom symbol to be displayed|The point will be displayed with a symbol defined by **PointSymbol**|
 |mapPoint(double[],[PointIcon](#pointicon))|The point is given by coordinate: latitude and longitude.**movePoint** allows a custom icon (ex. *.png file) to displayed in the map|The point will be displayed with an icon defined by **PointIcon**|
 |mapPoint(double[],[PointSymbol](#pointsymbol), [PointTooltip](#pointtooltip))|The point is given by coordinate: latitude and longitude. **movePoint** allows a custom symbol to be displayed and a tooltip|The point will be displayed with a symbol defined by **PointSymbol** and will display a tooltip whose content is defined by **PointTooltip**|
 |mapPoint(double[],[PointIcon](#pointicon), [PointTooltip](#pointtooltip))|The point is given by coordinate: latitude and longitude.**movePoint** allows a custom icon (ex. *.png file) to be displayed and a tooltip.|The point will by displayed with an icon defined by **PointIcon** and will display a tooltip whose content is defined by **PointTooltip**|

 where:

### PointTooltip

    public class PointTooltip
    {
        public string? content { get; set; }        //accept html content or JavaScript template literals without "`"
        public bool permanent { get; set; } = true;
        public double opacity { get; set; } = 0.9;
    }

### PointSymbol

     public class PointSymbol
    {
        public int radius { get; set; } = 4;
        public string? fillColor {get;set;} 
        public string? color {get;set;} 
        public int weight{get;set;} 
        public double opacity{get;set;}
        public double fillOpacity { get; set; } = 1;
    }
    
### PointIcon

    public class PointIcon
    {
        public string iconUrl{get; set;}      //icon url (ex. *.png file)
        public int[] iconSize{get; set;}      //pixels
        public int[] iconAnchor{get; set;}    
        public int[] popupAnchor{get; set;}   
        public string shadowUrl{get; set;}     
        public int[] shadowSize{get; set;}    
        public int[] shadowAnchor{get; set;}  
    }
### Add in __Imports.razor_ project file

    @using LeafletForBlazor

### Blazor Page:

    <button @onclick="onClickRun">Run</button> //launch moving points
    <RealTimeMap
        @ref="realTimeMap"
        width="600px" 
        height="600px"
        Parameters="@parameters"
    ></RealTimeMap>

### Blazor code block:

    @code {
        RealTimeMap? realTimeMap;	//reference to map control
        RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()  //general map settings
        {
            zoom_level = 18,
            location = new RealTimeMap.Location()
            {
                latitude = 44.4501715,
                longitude = 26.1107672,
            }
        }
        
        //points (coordonate) on the route. For simulation...
        List<List<double>> coordinates = new List<List<double>>() {
        new List<double>() { 44.4502578, 26.1108199 },
        new List<double>() { 44.4500215, 26.1105407 },
        new List<double>() { 44.4497369, 26.1093086 },
        new List<double>() { 44.4496145 , 26.1088460 },
        new List<double>() {  44.4491875, 26.1079328 }
        };

        RealTimeMap.PointSymbol symbol = new RealTimeMap.PointSymbol()
        {
            color = "red",
            fillColor = "yellow",
            radius = 10,
            weight = 3,
            opacity = 1,
            fillOpacity = 1
        };
        bool run = false;
        private async Task onClickRun() //Button onclick event
        {
            run = !run;
            for(var i=0;i<1000;i++)
            {
                pas = i % coordinates.Count;
                RealTimeMap.PointTooltip tooltip = new RealTimeMap.PointTooltip() { 
                    content=$"{Math.Round( coordinates[pas][0],3)},{Math.Round( coordinates[pas][1],3)}", 
                    opacity = 0.6 
                };

                await  realTimeMap.movePoint(coordinates[pas].ToArray(),  symbol, tooltip);
                await Task.Delay(1000);
                if (run == false)
                    return;
            }
        }

    }

[RealTimeMap movePoint() method GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RealTimeMap%20movePoint)


## Real Time data and Geometric class

 > Geometric class provide functionalities for working with real-time data.

 > This class will be a parent class (more precisely, host class - there is no inheritance) for the geometric shapes (ex. Points), geometric map shapes appearance, geometric analisys and so one supported by RealTimeMap.


### Points class

> The Points class is hosted by the Geometric class.

 > This class will work with RealTimeMap points. 
 > The points displayed in the map will be defined by the StreamPoint class, whose structure is predefined but which can be extended (value property is of type object).

 >Also, this class will provide methods to control the display of points (Appearance()), analysis (points collection) and so one.

### StreamPoint

Class has the following structure:

       public interface IStreamPoint
        {
            public Guid guid { get; set; }              //globally unique identifier
            public DateTime timestamp { get; set; }     //Date and Time
            public double latitude { get; set; }        //EPSG latitude coordionate
            public double longitude { get; set; }       //EPSG longitude coordionate
            public string type { get; set; }            //StreamPoint type
            public object value { get; set; }           //StreamPoint value (object)
        }
_latitude and longitude properties are Web Mercator coordinate values._

_The value property can be string or object defined by customn Data Structure Class._

### Working with Points collection

#### Upload points collection

            if(realTimeMap !=null)
                await realTimeMap.Geometric.Points.upload(points, true);

where, the last parameter is newCollection:
 - if it's missing, it means it's _false_. That is, the previous collection is kept;

            if(realTimeMap !=null)
                await realTimeMap.Geometric.Points.upload(points);

 - if it's _true_, a new collection will be created;

#### Add point(s) to collection

The class provides the following methods:

- Add single points

      Geometric.Points.add(StreamPoint point);

- Add more points

      Geometric.Points.add(StreamPoint[] point);

The **changeExtentWhenAddPoints** property of the Geometric.Points class allows changing or not the current view of the map at the same time as add one or more points:

    realTimeMap.Geometric.Points.changeExtentWhenAddPoints = true;

or

    realTimeMap.Geometric.Points.changeExtentWhenAddPoints = false;

> Default value for **changeExtentWhenAddPoints** is _true_.
 
 #### Delete point(s) from collection

Delete all points from Geometric.Points:

        if(realTimeMap!=null)
            await realTimeMap.Geometric.Points.delete(); //delete all points from Geometric.Points

Delete single points from Geometric.Points:

        if(realTimeMap!=null)
            await realTimeMap.Geometric.Points.delete("15366d7f-0689-4b8e-a2ee-29e5cb27f76e"); //delete point by guid

Delete multiple points from Geometric.Points:

        string[] ids = new string[2] {  "15366d7f-0689-4b8e-a2ee-28e5cb22f26e",
                                        "46246d6f-0684-4b8e-a2ee-26e2cb28f86f" };
        if(realTimeMap!=null)
            await realTimeMap.Geometric.Points.delete(ids); //delete points by guid


#### Moving point(s) on the map

Moving single point from Geometric.Points

        var point = new RealTimeMap.StreamPoint()
            {
                latitude = 44.4504845,
                longitude = 26.1128922,
                guid = Guid.Parse("15366d7f-0689-4b8e-a2ee-29e5cb27f76e") //existing guide in the Geometric.Points collection 
            };
        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.moveTo(point);

_during the move you cannot change the attributes (type, value, timestamp)_

Moving multiple points from Geometric.Points

        var point = new RealTimeMap.StreamPoint()
            {
                latitude = 44.4504845,
                longitude = 26.1128922,
                guid = Guid.Parse("15366d7f-0689-4b8e-a2ee-29e5cb27f76e") //existing guide in the Geometric.Points collection
            };

        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.moveTo(points.ToArray());

_during the move you cannot change the attributes (type, value, timestamp). A warning will appear in the console_

The **changeExtentWhenMovingPoints** property of the Geometric.Points class allows changing or not the current view of the map at the same time as moving the points:

    realTimeMap.Geometric.Points.changeExtentWhenMovingPoints = false; //the current view will be static

or

    realTimeMap.Geometric.Points.changeExtentWhenMovingPoints = true; //the current view will be expanded to display all the moving points
 
> Default value for **changeExtentWhenAddPoints** is _true_. 
 

 #### update() method

The **update()** method on Geometric.Points allows updating attributes (without location):
- **type** property;
- **timestamp** property;
- **value** property;

>The **value** property of StreamPoint allows you to set string, number or custom object.

Code example:

       //StreamPoint to be updated
       var point = new RealTimeMap.StreamPoint()
        {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),  //existing guide
                type = "intervention crew 2",                               //new type
                value = new Attributes() { 
                                            registrationNumber = "B 28 AAB", //new registration number 
                                            vehicleType = "5 seats"          //new vechicle type
                                        }
        };

        if (realTimeMap != null)
        {
            //update properties value (attributes)
            await realTimeMap.Geometric.Points.update(point);
            //check the update
            var result = realTimeMap.Geometric.Points.getItems(item => item.guid == Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"));
        }

Once the **StreamPoint** properties have been updated, the **Appearance** and/or **AppearanceOnType** will also updated:

| **StreamPoint Appearance type** | **Description** |
| :---- | :----- |
|  [rendering](#appearance-render-configuring-display-symbol)     | _symbol_ of **StreamPoint** collection in the **RealTimeMap**    |
|  [zoom levels](#appearance-zoom-levels-configuring-zoom-levels-between-are-displayed)  | _min. and max. levels_ between which **StreamPoint** collection are displayed on the map. Working only with **AppearanceOnType()** method    |
|  [tooltips](#appearance-tooltips-configuring-streampoint-tooltip)  | _text info_ displayed on the **StreamPoint**   |



 #### Getting points from the RealTimeMap

- Get all stream points

        //return List<StreamPoint> from Geometric.Points
        Geometric.Points.getItems(); 

- Get the points that match a criteria

        //return IEnumerable<StreamPoint> from Geometric.Points
        Geometric.Points.getItems(item=>item.timestamp == DateTime.Now); 


[Working with Geometric.Points collection - code example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RealTimeMap%20Geometric.Points%20collection)


### Appearance of **StreamPoint** collection

The Appearance of the points displayed in **RealTimeMap**, refers to:

| **Appearance type**         | **What it is?**                                                   |
| ---------------------------------- | ---------------------------------------------------------------- |
|  [rendering](#appearance-render-configuring-display-symbol)     | configuring _display symbol_ of **StreamPoint** collection in the **RealTimeMap**    |
|  [zoom levels](#appearance-zoom-levels-configuring-zoom-levels-between-are-displayed)  | _min. and max. levels_ between which **StreamPoint** collection are displayed on the map    |
|  [tooltips](#appearance-tooltips-configuring-streampoint-tooltip)  | _text info_ displayed on the **StreamPoint**   |


 #### Appearance render - configuring display symbol 


Change appearance of all points from points collection

    realTimeMap.Geometric.Points.Appearance(item => true).pattern = new RealTimeMap.PointSymbol() { 
                                                                                                        radius = 8,    
                                                                                                        color = "gray", 
                                                                                                        opacity = 0.68, 
                                                                                                        fillColor = "gray", 
                                                                                                        weight = 4, 
                                                                                                        fillOpacity = 0.68 
                                                                                               };


...or much more simple:

    realTimeMap.Geometric.Points.Appearance().pattern = new RealTimeMap.PointSymbol()
    {
        color = "green",
        fillColor = "green",
        fillOpacity = 0.5,
        radius = 10
    };

You can use predicate of Appearance method to filter points

    realTimeMap.Geometric.Points.Appearance(item => item.type == "points of type 1").pattern = new RealTimeMap.PointSymbol() { 
                                                                                                                                radius = 16,    
                                                                                                                                color = "rgb(200,100,0)", 
                                                                                                                                opacity = 0.68, 
                                                                                                                                fillColor = "red", 
                                                                                                                                weight = 4, 
                                                                                                                                fillOpacity = 0.68 
                                                                                                                             };

The appearance of the points is preserved in the map view. To reset the stored appearance, the Appearance method provide reset boolean parameter:

    realTimeMap.Geometric.Points.Appearance(item=>item.type=="emergency vehicles", true).pattern = new RealTimeMap.PointSymbol()
    {
        color = "blue",
        fillColor = "blue",
        fillOpacity = 0.5,
        radius = 10
    };

[Working with Geometric.Points Appearance](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RealTimeMap%20Geometric.Points%20Appearance)

#### _Configuring points Appearance render based on custom attributes_

The value property of the **StreamPoint** object allows to use custom attributes. These custom attributes can be used for various purposes.
The Appearance of the points in the map can be configured based on the custom attributes defined on the StreamPoint value property:

[Appearance render of points based on custom attributes](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20Appearance%20and%20custom%20attr)

[...more about Appearance render](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/more%20about%20Appearance/README.md)



#### Appearance zoom levels - configuring zoom levels between are displayed

In addition, the **pattern** property of the **AppearanceOnType()** method accepts the configuration of the scales (min, max) between which the points on the map are displayed:

           realTimeMap.Geometric.Points.AppearanceOnType(item => item.type == "intervention crew").pattern = new RealTimeMap.VisibilityZoomLevel()
            {
               maxZoomLevel = 18,
               minZoomLevel = 15
            };

[AppearanceOnType example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20AppearanceOnType)

#### Appearance tooltips - configuring StreamPoint tooltip

Tooltips can be associated with StreamPoint collection displayed on the map (map items). Tooltips can be configured using both **AppearanceOnType()** and **Appearance()** methodes and the **pattern** property:
The definition of the tooltip is done using the class **PointTooltip**:

Using AppearanceOnType() method:

    realTimeMap.Geometric.Points.AppearanceOnType(item => item.type == "intervention vehicle").pattern = new RealTimeMap.PointTooltip()
        {
            content = "<h6>${value}</h6>${type}</br>${guid}",
            opacity = 0.8,
            permanent = true
        };

or using Appearance() method:

    realTimeMap.Geometric.Points.Appearance(item => item.value == "B 42 DCI").pattern = new RealTimeMap.PointTooltip()
        {
            content = "<h6>${value}</h6>${type}</br>${guid}",
            opacity = 0.8,
            permanent = false
        };

where:

1. **content** - can be a string, html components or JavaScript string template without "`" (without the intended JavaScript string template character);
   - **value** is current StreamPoint value property;
   - **type** is current StreamPoint type property;
   - **guid** is current StreamPoint guid property;
1. **opacity** - the opacity of the tooltip displayed in the map;
1. **pemanent** - true - the display is permanent, false - the display is done when the mouse passes over the point;

Also, the Appearance() and AppearanceOnType() methods can be used without predicate conditions:

For example:

    realTimeMap.Geometric.Points.Appearance().pattern = new RealTimeMap.PointTooltip()
        {
            content = "<h6>${value}</h6>${type}</br>${guid}",
            opacity = 0.8,
            permanent = false
        };

in this case, the tooltips will be displayed for all elements in the map.



#### _Configuring tooltips based on custom attributes_

The value property of the **StreamPoint** object allows to use custom attributes. These custom attributes can be used for various purposes.
The pattern property allows the use of _custom attributes_ defined for **StreamPoint** to configuring RealTimeMap items tooltips. For more details, you can access the following examples:

[Configuring StreamPoint Tooltips with custom attributes - example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/StreamPoint%20tooltip/RTM%20Points%20Tooltips#readme)

[Configuring StreamPoint Tooltips with hierarchical custom attributes - example code](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/StreamPoint%20tooltip/RTM%20tooltip%20hierarchical%20attr/README.md)


## Code Example

 > Code example for Points collection.

 #### Add in __Imports.razor_ project file

        @using LeafletForBlazor

#### Blazor Page:

        <RealTimeMap 
            width="600px" 
            height="600px"
            @ref="realTimeMap" 
        ></RealTimeMap>

#### Blazor code block:

##### Reference to RealTimeMap control (from Blazor Page):

        @code {
            RealTimeMap? realTimeMap;	//reference to control
              }

##### Stream points collection


       List<RealTimeMap.StreamPoint> points = new List<RealTimeMap.StreamPoint> {
                new RealTimeMap.StreamPoint()
                {
                    guid = Guid.Parse("15366d7f-0689-4b8e-a2ee-29e5cb27f76e"),
                    latitude = 44.4502578,
                    longitude = 26.1108199,
                    type = "type 1",
                    value = "a point-specific value",
                }
        }



_latitude and longitude properties are Web Mercator coordinate values._

_In this previous, the value property is of string type_

_If the timestamp is missing, LeafletForBlazor will assign the current date_

_This collection has a static behavior._

### Clustering

You can choose to have the StreamPoint collection clustered in the map. To do this, you must set the property to true:

	realTimeMap.Geometric.Points.clusteringAfterCollectionUpdate = true;

[more about](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Working%20with%20StreamPoint/Clustering/README.md#clustering)


# Geometric class for displaying different static shapes

## Add GeoJSON data to RealTimeMap

The **DataFromGeoJSON** class offers the possibility of adding data (GeoJSON format) to the RealTimeMap control.

This class is hosted by the **Geometric** class. This class allows adding spatial data from **GeoJSON** formats.

Two formats are used, both complying with: [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946).

### Add from object

**DataFromGeoJSON** provides **addObject()** method:

This method allows adding GeoJSON data programmatically, using custom classes (according to [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946))

1. The first format is an array that exactly respects the format [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

[Working with GeoJSON Array - documentation and example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Array)

1. And another JSON format, which for the "data" property we have the same array [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946). In addition, this format accepts customization of symbolization, tooltips, etc 


        <RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded" width="460px" height="462px" />
        @code{
            public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
             {
                await args.sender.Geometric.DataFromGeoJSON.addObject(geojsonObject);
             }
        }

[Working with GeoJSON Object - documentation and example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Object)

For more information:

[RTM and GeoJSON documentation and example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON)


## Add from file(s)

**DataFromGeoJSON** provides **addFromFiles()** method:

       await args.sender.Geometric.DataFromGeoJSON.addFromFiles(new string[1] 
            { 
                "http://localhost:5141/sample-data/pointIconTooltip.json"
            }
        );


[more about data form files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON)

Both for objects added with **addObject()** and the content of files added with **addFromFiles()**, we have the following properties:

1. for graphic (circleMarker) symbol:

| Property | Type | Descriotion |
|----|----|----|
| radius | int | circle radius |
| fillColor | string | fill color of circle |
| fillOpacity | double | fill opacity of circle |
| color | string | margin (line) color of cricle |
| opacity | double | margin (line) opacity |
| weight | int | margin (line) weight |


_similar with leaflet documentation_


2. for icon symbol:

| Property | Type | Descriotion |
|---|---|---|
| iconUrl | string | url of image icon |
| iconSize | int[2] | screen pixels of icon dimension |
| iconAnchor | int[2] | screen pixels of icon anchor |
| popupAnchor| int[2] | screen pixels of popup anchor |
| shadowUrl| string | screen pixels of shadow icon anchor |
| shadowSize| int[2] | screen pixels of shadow icon dimension |
| shadowAnchor| int[2] | url of shadow icon |

_similar with leaflet documentation_


3. symbol for polygon shape:


| Property | Type | Descriotion |
|----|----|----|
| fillColor | string | fill color of shape |
| fillOpacity | double | fill opacity of shape |
| color | string | margin (line) color of shape |
| opacity | double | margin (line) opacity |
| weight | int | margin (line) weight |


_similar with leaflet documentation_

4. symbol for polyline shape:


| Property | Type | Descriotion |
|----|----|----|
| color | string | color of line |
| opacity | double | opacity of line |
| weight | int | weight of line |


_similar with leaflet documentation_

### Appearance

### Appearance and switch cases

You can create distinct _symbolization classes_ based on the properties of GeoJSON file items.
How appearance can be customized by defining distinct classes?

It can be done using a JSON switch object of *appearance* item:

    {
        switch:   {
                      "fieldName": "name",  //field name of item properties 
                      "cases": []           //value: {}
                      "default": {}         //symbol,
                  },
        "visibilityZoomLevels": {
                                  "minZoomLevel": 12,
                                  "maxZoomLevel": 16
                                }

    }

What is the structure of a _cases_ array item?

    "<property value>": {
                        "color": "green",
                        "opacity": 0.6,
                        "weight": 8
                      }

#### Example code

        {
          "name": "Streets",
          "data": [
            {
              "type": "Feature",
              "geometry": {
                "type": "Polyline",
                "coordinates": [
                  [
                    [ 44.44586931032441, 26.097146294088674 ],
                    [ 44.44567571771458, 26.096377445586192 ],
                    [ 44.44557322665131, 26.096160510467932 ],
                    [ 44.44542518267126, 26.09578087503316 ]
                  ]
                ]
              },
              "properties": {
                "name": "Biserica Amzei"
              }
            }
          ],
          "appearance": {
            "switch": {
              "fieldName": "name",
              "cases": [
                {
                  "Biserica Amzei": {
                    "color": "green",
                    "opacity": 0.6,
                    "weight": 8
                  }
                }
              ],
              "default": {
                            "color": "gray",
                            "opacity": 0.6,
                            "weight": 8
                         }
            },
             "visibilityZoomLevels": {
                                          "minZoomLevel": 12,
                                          "maxZoomLevel": 16
                                      }
          }
        }


### Custom tooltip

You can display customized tooltips based on the attributes stored in the files:

    "tooltip": {
        "content": "<b>${name}</b><br/><i><font size='4' face='verdana' color='blue' >${description}</font></i><br/><img width='100%' height='100%' src = '${url}'></img>",
        "opacity": 0.8,
        "visibilityZoomLevels": {
              "minZoomLevel": 15,
              "maxZoomLevel": 18
    }


![GeoJSON@appearance20](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/81f4ea40-55b5-4dd5-9270-c2643aa47dd6)



[more about configuring appearance and tooltips form files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON)




## **DisplayPolygonsFromArray** class

**DisplayPolygonsFromArray** is a new class that allows displaying polygons starting from point arrays.
This class allows the display of simple polygons or polygons with several rings.

Display of simple polygons (single ring):

    await realTimeMap.Geometric.DisplayPolygonsFromArray.add(new List<double[]>
        {
            new double[] { 43.97209871008421, 25.328761772135064 },
            new double[] { 43.972004589576606, 25.329119019038004},
           ...
        });

Display polygons with multiple rings:

    await realTimeMap.Geometric.DisplayPolygonsFromArray.add(
        new List<List<double[]>>()
            {
                new List<double[]>()
                {
                    new double[] { 43.97210330030072, 25.32749864474909 },
                    ...
                },
        new List<double[]>()
                {
                    new double[] { 43.972004589576606, 25.329119019038004},
                    ...
                }
        });

        
Also, the add() method allows customizing the symbolization of the displayed polygons:

           await realTimeMap.Geometric.DisplayPolygonsFromArray.add(new List<double[]>
                {
                    new double[] { 43.97209871008421, 25.328761772135064 },
                    new double[] { 43.972004589576606, 25.329119019038004},
                    ...
             }, 
             new RealTimeMap.PolygonSymbol()
             {
                    color = "yellow",
                    fillColor = "orange",
                    weight = 4,
                    opacity = 0.4,
                    fillOpacity = 0.4
             });

 >In the future, this class will be used only for displaying polygons.

 ## DisplayPointsFromArray

The **DisplayPointsFromArray** class hosted by the Geometric class allows displaying static points using coordinate arrays (new double[2]{}) as input data:


    await realTimeMap.Geometric.DisplayPointsFromArray.addPoint(
            new double[2] { 43.97248976827578, 25.326675905214792 });

or customizing the appearance of the point dispalayed in the map:

    await realTimeMap.Geometric.DisplayPointsFromArray.addPoint(
            new double[2] { 43.97248976827578, 25.326675905214792 }, 
            new RealTimeMap.PointSymbol()
            {
                color = "yellow",
                fillColor = "yellow",
                opacity = 0.8,
                fillOpacity = 0,
                radius = 12,
                weight = 2
            });

### Obsolete methods

The **add()** method for adding points is **obsolete/deprecated**. The **add()** method is replaced by the **addPoint()** method.

The **deleteAll()** method for deleting points is **obsolete/deprecated**. The **deleteAllPoints()** method is replaced by the **deleteAll()** method:

    await realTimeMap.Geometric.DisplayPointsFromArray.deleteAllPoints();


### addLabel() method

The **addLabel()** method on the **DisplayPointsFromArray** class will allow you to display a text in the map:

    await realTimeMap.Geometric.DisplayPointsFromArray.addLabel( new RealTimeMap.LabelInfo()
    {
            coordinates = new double[2] { 43.97248976827578, 25.326675905214792 },
            textAnchor = new double[2] { 0, 16 },
            text = "text displayed on the map",
            labelStyle = "min-width:40px;height:100%;background-color:#920202;border-radius:6px;color:white;text-align:center;font-size:11px;opacity:0.6"
    });

The **labelStyle** property allows you to formating label displayed in the map.

## DisplayPolylinesFromArray

The **DisplayPolylinesFromArray** class hosted by the Geometric class, allows you to display measurements and connectors lines.

### Measure line

Adding a measurement line is done with the addMeasure() method.

>~~textAnchor~~ parameter is **obsolete/deprecated**. The **labelAnchor** parameter is used to set the anchor point of the text label displayed in the map.

>~~text~~ parameter becomes obsolete and is replaced with **content**


            await realTimeMap.Geometric.DisplayPolylinesFromArray.addMeasure(
                                                                new RealTimeMap.MeasureLine()
                                                                {
                                                                    start = new double[2] { 43.971312524467095, 25.328505256329578},    //start point of measure line
                                                                    end = new double[2] { 43.970933062429864, 25.329087513345627},      //end point of measure line
                                                                    text = "20 meters", //is obsolete
                                                                    content = "20 meters", //replace text parameter
                                                                    textAnchor = new double[2] {- 2, 8 },  //is obsolete
                                                                    labelAnchor = new double[2] {- 2, 8 }, //replace textAnchor                              //the anchor point (text) from the middle of the line 
                                                                    labelStyle = "min-width:40px;height:100%;background-color:#084886;border-radius:6px;color:#d2efff;text-align:center;font-size:10px;"

                                                            });



The **labelRotateWithLine** parameter is of type boolean and allows the label to be displayed in the same direction (slope) as the measurement line.

Delete all measure lines with deleteMeasure() method:

			await realTimeMap.Geometric.DisplayPolylinesFromArray.deleteMeasure();

### Connector line

Add line with addConnector() method:

           double[,] polyline = new double[12, 2] {
                           { 44.44586931032441, 26.097146294088674 }, { 44.44567571771458, 26.096377445586192 }, { 44.44557322665131, 26.096160510467932 }, { 44.44542518267126, 26.09578087503316 }, { 44.44530219217061, 26.09554799080396 }, { 44.445135928272926, 26.095378912700124 }, { 44.44502660288366, 26.095200263212803 }, { 44.44493095375493, 26.094874850544517 }, { 44.44486034694202, 26.09453030700582 }, { 44.44465286263079, 26.093572916893123 }, { 44.44440775850324, 26.092709245635653 }, { 44.44427754378361, 26.09215134979953 }
           };
           await realTimeMap.Geometric.DisplayPolylinesFromArray.addConnector(polyline, symbol: new RealTimeMap.PolylineSymbol() { color = "blue", weight = 2 });


Delete all connector lines with deleteConnectors() method:

        await realTimeMap?.Geometric.DisplayPolylinesFromArray.deleteConnectors();

# RealTimeMap components

## StreamLegend

StreamLegend is a beta component (starting with 2.0.0.6) that allows the display of symbols applied through the Appearance() method. This component displays only the symbols of the StreamPoint elements added on the RealTime.Geometric.Points class.

1. Add the LeafletForBlazor namespace to the project, using the @using directive

For this, add

        @using LeafletForBlazor.Components

in the **_Imports.razor** file of the project.

2. In the Blazor page, add StreamLegend as RealTimeMap child:


        <RealTimeMap height="88vh" width="80hw">
            <StreamLegend/>
        </RealTimeMap>





# Geometric.Computations class

The **Geometric.Computations** class will provide a set of functions various geometric calculations.

## Distance calculation

Computing distance distance between two points:

- working with double values:

      Geometric.Computations.distance(double latitudeOfPoint1, double longitudeOfPoint1, double latitudeOfPoint2, double longitudeOfPoint2, UnitOfMeasure unitOfMeasure);

- working with double array:

      Geometric.Computations.distance(double[2] coordinate1, double[2] coordinate2, UnitOfMeasure unitOfMeasure);

- working with StreamPoint(s):

      Geometric.Computations.distance(StreamPoint point1, StreamPoint point2, UnitOfMeasure unitOfMeasure);
    
Code example:
    
    Console.WriteLine(realTimeMap.Geometric.Computations.distance(pct1, pct6, RealTimeMap.UnitOfMeasure.meters))

### Searching points on click, distance() condition example

In order to be able to find the points in the neighborhood of a point (click on the map), you can use Geometric.Points.getItems() with predicate distance condition

Blazor page:

    <RealTimeMap height="620px" width="820px" OnClickMap="onClickingMap"></RealTimeMap>

Code block:

    @code{
         public  void onClickingMap(RealTimeMap.ClicksMapArgs value)
            {
                List<RealTimeMap.StreamPoint> findedPoints = new List<RealTimeMap.StreamPoint>();
                    findedPoints = (value.sender as RealTimeMap).Geometric.Points.getItems(point => (value.sender as RealTimeMap).Geometric.Computations.distance(
                        point, 
                        new RealTimeMap.StreamPoint() { latitude = value.location.latitude, longitude = value.location.longitude }, 
                        RealTimeMap.UnitOfMeasure.meters
                        ) <= 10
                    );
            }
        }




------------

                                                            
# Tracking and Monitoring points position

**RealTimeMap** will provide the necessary tools for monitoring, tracking and analyzing shapes (ex. points position) in motion. These tools will be able to be integrated in the final IoT applications (possible integration with Arduino and/or  Raspberry pi).

[LeafletForBlazorTracking GitHub repository](https://github.com/ichim/LeafletForBlazorTracking)


## Nearby Points Analysis

> You can get the nearby points.

The configuration of nearby points analysis is done by:

    public class NearbyAnalysis
    {
        public double threshold { get; set; } = 0; // > 0
        public UnitOfMeasure unit { get; set; } =   UnitOfMeasure.meters; // UnitOfMeasure.kilometers | UnitOfMeasure.miles | UnitOfMeasure.nauticalMiles | UnitOfMeasure.feets 
    }

...and filtering the points subject to analysis:

    realTimeMap.Geometric.Points.Analysis(item => item.value == "alpha crew")

Obtaining the points that meet the _nearby points_ condition (threshold) is done using the event method:

    analysis.OnNearbyThresholdFired += onNearbyThresholdTrigger;

    public async void onNearbyThresholdTrigger(object sender, RealTimeMap.NearbyThresholdArgs args)
    {
  
    }

Closing the nearby points condition will trigger the method:

    analysis.OnNearbyThresholdClosed += nearbyThresholdTriggerClosed;

    public async void nearbyThresholdTriggerClosed(object sender)
    {
      
    }

## Code Example

Add using LeafletForBlazor reference into _Imports.razor

    @using LeafletForBlazor

Add <RealTimeMap/> Blazor control in your page:

    <RealTimeMap @ref="realTimeMap" height="800px" width="800px"></RealTimeMap>

Define block clode block and declare RealTimeMap object:

    @code{
        RealTimeMap? realTimeMap;
    }

Upload List<StreamPoint> data into RealTimeMap:

    public async Task upload()
    {
        if(realTimeMap!=null)
            await realTimeMap.Geometric.Points.upload(new InputData().input);
    }


Change the default appearance (Geometric.Points.Appearance()) of the points displayed on the map:

    public async Task upload()
    {
        if(realTimeMap!=null)
            await realTimeMap.Geometric.Points.upload(new InputData().input);
        //change points appearance
        if(realTimeMap !=null)
        {
            realTimeMap.Geometric.Points.Appearance(item => item.type == "emergency vehicles").pattern = new RealTimeMap.PointSymbol()
            {
                    color = "green",
                    fillColor = "green",
                    fillOpacity = 0.5,
                    radius = 10
            };
            realTimeMap.Geometric.Points.Appearance(item => item.type == "ambulance").pattern = new RealTimeMap.PointSymbol()
            {
                color = "blue",
                fillColor = "blue",
                fillOpacity = 0.5,
                radius = 10
            };
    }

Set up nearby point analysis. The threshold value can be given in various units of measure:

            var analysis = realTimeMap.Geometric.Points.Analysis(item => true);
            analysis.nearby = new RealTimeMap.NearbyAnalysis()
                {
                    threshold = 0.2,
                    unit=RealTimeMap.UnitOfMeasure.nauticalMiles
                };

If the unit of measure (unit) is missing, it will be in meters.

_add into upload() method_

Define the methods that will be triggered when the condition NearbyAnalysis() is reached

    analysis.OnNearbyThresholdFired += onNearbyThresholdTrigger;
    analysis.OnNearbyThresholdClosed += nearbyThresholdTriggerClosed;

_add into upload() method_

Define _onNearbyThresholdTrigger_ and _nearbyThresholdTriggerClosed_ methods:

_onNearbyThresholdTrigger_:

    public void onNearbyThresholdTrigger(object sender, RealTimeMap.NearbyThresholdArgs args)
    {

    }

_onNearbyThresholdTrigger_:

    public void nearbyThresholdTriggerClosed(object sender)
    {
 
    }

Use the _onNearbyThresholdTrigger_ method to change the appearance or display nearby points:

    public void onNearbyThresholdTrigger(object sender, RealTimeMap.NearbyThresholdArgs args)
    {
        foreach(var item in args.tuples)
        {
            var guid = item.tuple.Item1.guid;
            realTimeMap.Geometric.Points.Appearance(item => item.guid == guid).pattern = new RealTimeMap.PointSymbol()
                {
                    color = "red",
                    fillColor = "red",
                    fillOpacity = 0.5,
                    radius = 10
                };
        }
    }

Use the _nearbyThresholdTriggerClosed_ method to return to the initial appearance of the points. Careful! Appearance must contain the parameter reset = true . Appearance(predicate, reset):

    public  void nearbyThresholdTriggerClosed(object sender)
    {
        realTimeMap.Geometric.Points.Appearance(item => item.type == "anti-terrorist vehicles", true).pattern = new RealTimeMap.PointSymbol()
            {
                color = "green",
                fillColor = "green",
                fillOpacity = 0.5,
                radius = 10
            };
        realTimeMap.Geometric.Points.Appearance(item => item.type == "ambulance", true).pattern = new RealTimeMap.PointSymbol()
            {
                color = "blue",
                fillColor = "blue",
                fillOpacity = 0.5,
                radius = 10
            };
    }

# Esri Leaflet

## Esri basemaps

[more about](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Esri%20Leaflet#esri-basemaps)

## Esri GeoSearch Task

[more about](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Esri%20Leaflet/README.md#esri-geosearch-task)

## Esri Reverse Geocode Task

[more about](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Esri%20Leaflet#esri-reverse-geocode-task)



 _____________


O-L I

Thank you for choosing this package!

Laurentiu Ichim
