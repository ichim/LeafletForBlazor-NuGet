# Apearance on StreamPoint custom attributes

The **Appearance** of the points displayed on the map can be configured using the standard attributes of the **StreamPoint** points: **guid**, **timestamp**, **type** and **value**.
The **value** property of a **StreamPoint** supports the configuration of custom classes. This option allows to extend the data structure of a **StreamPoint**

>**Question**: Can I use a custom data structure (defined on the **value** property of a **StreamPoint**) to configure Appearance of Map points?
>**Answer**: Yes, very easy to do!

## The data used in the code example

The **value** property of the **StreamPoint** object will be extended with the following data structure:

        public class Attributes
        {
            public string? registrationNumber { get; set; }
            public string? vehicleType { get; set; }
            public string? description { get; set; }
        }

A **StreamPoint** from the collection will have the following values, as an example:

         var streamPoint = new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.972801938829356,
                longitude = 25.326177627532893,
                type = "intervention crew",
                value = new Attributes() { 
                                          registrationNumber = "B 24 AAB", 
                                          vehicleType = "bus", 
                                          description = "without description" 
                                          }
         }

_**latitude** and **longitude** properties are Web Mercator coordinate values._

_The **value** property supports objects defined by custom classes.In this example, the **value** property is used to define custom attributes from **StreamPoint**_

_If the **timestamp** is missing, LeafletForBlazor will assign the current date_

_This collection has a static behavior._

## Configuring Appearance on custom attributes

In this code example, the appearance of the displayed points was made based on the custom **vechicleType** attribute:

                realTimeMap!.Geometric.Points.Appearance(item => (item.value as Attributes)!.vehicleType == "bus").pattern = new RealTimeMap.PointSymbol()
                    {
                        fillColor = "red",
                        fillOpacity= 0.6,
                        color = "yellow",
                        opacity = 1,
                        weight = 2,
                        radius = 12,
                    };
                realTimeMap!.Geometric.Points.Appearance(item => (item.value as Attributes)!.vehicleType == "5 seats").pattern = new RealTimeMap.PointSymbol()
                    {
                        fillColor = "blue",
                        fillOpacity = 0.6,
                        color = "green",
                        opacity = 1,
                        weight = 2,
                        radius = 8,
                    };


# Appearance and update() custom attribute

In this example, it will be shown that updating a custom attribute will have the effect of changing the render symbology in the map.

## The data used in the code example

The **value** property of the **StreamPoint** object will be extended with the following data structure:

        public class Attributes
        {
            public string? registrationNumber { get; set; }
            public string? vehicleType { get; set; }
            public string? description { get; set; }
        }

A **StreamPoint** from the collection will have the following values, as an example:

         var streamPoint = new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.972801938829356,
                longitude = 25.326177627532893,
                type = "intervention crew",
                value = new Attributes() { 
                                          registrationNumber = "B 24 AAB", 
                                          vehicleType = "bus", 
                                          description = "without description" 
                                          }
         }

_**latitude** and **longitude** properties are Web Mercator coordinate values._

_The **value** property supports objects defined by custom classes.In this example, the **value** property is used to define custom attributes from **StreamPoint**_

_If the **timestamp** is missing, LeafletForBlazor will assign the current date_

_This collection has a static behavior._

## Configuring Appearance on custom attributes

In this code example, the appearance of the displayed points was made based on the custom **vechicleType** attribute. The configuration of the appearance of the rendering will be done on the OnAfterMapLoaded event of the RealTimeMap.


           public async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
           {
               //default render symbology. This render symbology will NOT change!!
               realTimeMap!.Geometric.Points.Appearance(item =>  (item.value as Attributes ?? new Attributes()).vehicleType == "car").pattern = new RealTimeMap.PointSymbol()
               {
                   radius = 10,
                   fillColor = "green",
                   fillOpacity = 0.4
               };
          }

## Update custom attribute

on the onClick event of a button, the custom vehicleType attribute will be updated:


            public async Task onUpdate()
            {//here we will change the attributes. vehicleType will become "car"
                var pointAttributes = new RealTimeMap.StreamPoint()
                {
                        guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                        type = "intervention crew",
                        value = new Attributes() { registrationNumber = "B 24 AAB", vehicleType = "car" }
                };
               await realTimeMap!.Geometric.Points.update(pointAttributes);
            }

The rendering symbol of this StreamPoint will be made in accordance with the Appearance configured when loading the map (onAfterMapLoaded event).

![update@appearance@render](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/581ec7bc-4f87-4082-9bc8-56af7f8cc0a2)



