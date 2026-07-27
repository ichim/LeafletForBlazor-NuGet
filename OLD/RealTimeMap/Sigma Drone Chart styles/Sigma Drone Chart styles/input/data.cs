using LeafletForBlazor;

namespace input.Data
{
    public class data
    {

        public List<RealTimeMap.SigmaDronePoint> items = new List<RealTimeMap.SigmaDronePoint>()
        {
            new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude = 54.349746877082964,
                    longitude = 18.74062644099916,
                },
                dimension = 82,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                styles = new RealTimeMap.SigmaDroneStyle()
                {
                    background = new LeafletForBlazor.css.Style().add("fill", "lime"),
                    pivot = new LeafletForBlazor.css.Style().add("r","3").add("opacity","0.6").add("fill","indigo")
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
                new RealTimeMap.SigmaDroneCrownPercent()
                {
                    label = "battery",
                    valueStart = 0,
                    valueStop = 4,
                    value = 2.4,
                    percentageOfTheEntireCrown = 20,
                    backgroundColor = "gray",
                    fillColor = "yellow",
                    haloText = true,
                },
                   new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 18,
                    value = 6,
                    percentageOfTheEntireCrown = 50,
                    backgroundColor = "#f8f8ff",
                    styles = new RealTimeMap.SigmaDroneCrownScaleStyle()
                    {
                        ticks = new LeafletForBlazor.css.Style().add("stroke","darkgray").add("stroke-width","1.2"),
                        indicator = new LeafletForBlazor.css.Style().add("stroke","orange").add("stroke-width","4px").add("opacity","0.6")
                    }
                },
                new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "fuel",
                    colors = new List<string>() { "green", "yellow", "red" }.ToArray(),
                    percentageValues = new List<int>() { 33, 33, 33 }.ToArray(),
                    index=1,
                    labels = new List<string>() { "full", "half", "low" }.ToArray(),
                    percentageOfTheEntireCrown = 30,
                    backgroundColor = "lightgray",
                    styles = new RealTimeMap.SigmaDroneCrownDiscreteStyle()
                    {
                        indicator = new LeafletForBlazor.css.Style().add("stroke","indigo").add("stroke-width","4px").add("opacity","0.6")
                    }
                },


            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 1
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 820,
                    maximumAltitude = 1200,

            },
            batteryIndicator = new RealTimeMap.BatteryIndicator()
            {
                    level = 6,
                   
            }
            },
         
        };  
    }
}
