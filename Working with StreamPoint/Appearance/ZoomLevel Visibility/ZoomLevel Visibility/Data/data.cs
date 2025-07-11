using LeafletForBlazor;

namespace StreamPointCollection
{
    public class InputData
    {
        public List<RealTimeMap.StreamPoint> input = new List<RealTimeMap.StreamPoint>() {
          new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.972801938829356,
                longitude = 25.326177627532893,
                type = "intervention crew",
                value = "gendarmerie crew"
         },
              new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("48466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.97156729345875,
                longitude = 25.328326109623443,
                type = "suspicious vehicle",
                value = "CT 402 TRR"
         },
                   new RealTimeMap.StreamPoint()
         {
               guid = Guid.Parse("88466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
             latitude= 43.97290712065776,
             longitude = 25.329964708333343,
             type = "ambulance",
            value = "ambulance crew"
         },
         new RealTimeMap.StreamPoint()
         {
               guid = Guid.Parse("68466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
             latitude=43.97129017044845,
             longitude = 25.32946103324729,
             type = "police crew",
            value = "police - alpha crew"
         },
             new RealTimeMap.StreamPoint()
             {
                guid = Guid.Parse("82466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                 latitude= 43.971356241788044,    
                 longitude = 25.32843148166333,
                type = "suspicious vehicle",
                    value = "B 42 SSP"
             },
        };
    }

}
