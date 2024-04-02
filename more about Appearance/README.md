# Apearance on StreamPoint custom attributes

The **Appearance** of the points displayed on the map can be configured using the standard attributes of the **StreamPoint** points: **guid**, **timestamp**, **type** and **value**.
The **value** property of a **StreamPoint** supports the configuration of custom classes. This option allows to extend the data structure of a **StreamPoint**

**Question**: Can I use a custom data structure (defined on the **value** property of a **StreamPoint**) to configure Appearance of Map points?

**Answer**: Yes, very simple to do!

## The data used in the example

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
