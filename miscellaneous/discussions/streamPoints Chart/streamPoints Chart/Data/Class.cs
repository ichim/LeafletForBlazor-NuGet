using LeafletForBlazor;


namespace streamPieChart.data
{
    public class Attributes
    {
        public string? registrationNumber { get; set; }
        public string? vehicleType { get; set; }
        public string? description { get; set; }
        public int[]? values { get; set; }
        public string[]? render { get; set; }
        public string[]? labels { get; set; }
    }
    public class InputData
    {
        public List<RealTimeMap.StreamPoint> input = new List<RealTimeMap.StreamPoint>() {
          new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.972801938829356,
                longitude = 25.326177627532893,
                type = "intervention crew",
                value = new Attributes() {
                    registrationNumber = "B 24 AAB",
                    vehicleType = "bus",
                    values = new List<int>(){22,18,2}.ToArray(),
                    render = new List<string>(){ "#b91d47", "#00aba9", "#2b5797" }.ToArray(),
                    labels = new List<string>(){ "fasion", "food", "tech" }.ToArray()

                }
         },
          new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("48466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.971876662076546,
                longitude = 25.328737648076636,
                type = "asked for help",

               value = new Attributes() {
                   registrationNumber = "B 24 AAD",
                   vehicleType = "5 seats",
                   description="black color, two occupants in the car",
                   values = new List<int>(){40,12,20}.ToArray(),
                   render = new List<string>(){ "#b91d47", "#00aba9", "#2b5797" }.ToArray(),
                   labels = new List<string>(){ "fasion", "food", "tech" }.ToArray()
               }
         },
          new RealTimeMap.StreamPoint()
         {
               guid = Guid.Parse("88466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
             latitude= 43.97290712065776,
             longitude = 25.329964708333343,
             type = "ambulance",
            value = new Attributes() {
                registrationNumber = "B 24 DAA",
                vehicleType = "special car",
                values = new List<int>(){40,22,82}.ToArray(),
                render = new List<string>(){ "#b91d47", "#00aba9", "#2b5797" }.ToArray(),
                labels = new List<string>(){ "fasion", "food", "tech" }.ToArray()

            }
         },
          new RealTimeMap.StreamPoint()
         {
               guid = Guid.Parse("68466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
             latitude=43.97129017044845,
             longitude = 25.32946103324729,
             type = "police crew",
            value = new Attributes() {
                registrationNumber = "B 24 DAB",
                vehicleType = "5 seats",
                values = new List<int>(){40,22,220}.ToArray(),
                render = new List<string>(){ "#b91d47", "#00aba9", "#2b5797" }.ToArray(),
                labels = new List<string>(){ "fasion", "food", "tech" }.ToArray()

            }
         },
          new RealTimeMap.StreamPoint()
             {
                guid = Guid.Parse("82466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                 latitude= 43.971356241788044,
                 longitude = 25.32843148166333,
                type = "asked for help",
                value = new Attributes() {
                    registrationNumber = "B 24 DBA",
                    vehicleType = "5 seats",
                    description = "blue color",
                    values = new List<int>(){40,12,20}.ToArray(),
                    render = new List<string>(){ "#b91d47", "#00aba9", "#2b5797" }.ToArray(),
                    labels = new List<string>(){ "fasion", "food", "tech" }.ToArray()
                }
             },
        };
    }

}

