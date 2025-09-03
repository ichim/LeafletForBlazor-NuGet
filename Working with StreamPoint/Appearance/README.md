# Basic Appearance

               realTimeMap.Geometric.Points.Appearance(item => item.type == "intervention crew").pattern = 
                new RealTimeMap.PointSymbol() 
                       { 
                              radius = 8, 
                              color = "#28ffff", 
                              opacity = 0.68, 
                              fillColor = "orange", 
                              weight = 2, 
                              fillOpacity = 0.68 
                         };

  [more about basic implementation](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Appearance/Basic%20Appearance#appearance-render)

# Appearance on Type

# Appearance based on Custom Attributes

StreamPoint data defined based on a [Custom class](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint#extending-streampoint-attributes) can be used to define the Appearance in the map. To define the Appearance of a point class in the StreamPoint collection, you must [use the Custom class](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Appearance/Custom%20Attributes#appearance-based-on-custom-attributes) defined to extend the StreamPoint data structure. 

# Zoom Level Visibility

You can use the Appearance method to show or hide StreamPoints at certain scale levels.


## Update type and Appearance

Changing the type property of a StreamPoint will have the effect of changing its appearance.

The Appearance can be configured on the Load event (OnAfterMapLoaded) of the RealTimeMap component.

Updating the type property, anywhere in the code, will have the effect of updating the Appearance in the Map.


[example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Collection#update)



