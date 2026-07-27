using LeafletForBlazor;

namespace Legend.Data
{
    public class InputData
    {
       public List<RealTimeMap.StreamPoint> points = new List<RealTimeMap.StreamPoint>();

        public InputData() {
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44469760652109,  
                longitude = 26.095382508640196,
                type = "museum"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44524976131496,  
                longitude = 26.098549993223983,
                type = "souvenir shop"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.445736948590145,  
                longitude = 26.09684397215584,
                type = "museum"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44390591554736,
                
                longitude = 26.1002900704259,
                type = "unknown"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44338627600413,
                longitude = 26.098749007675178,
                type = "museum"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.444181986815835,
                
                longitude = 26.09506972528488,
                type = "museum"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44246867624891,
                longitude = 26.101700380637304,
                type = "souvenir shop"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.442586407956405,
                longitude = 26.09498444804462,
                type = "food shop"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.443508035882154,  
                longitude = 26.09524598411777,
                type = "souvenir shop"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.446742316294205,
                longitude = 26.09408989852577,
                type = "unknown"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44662172496849,
                longitude =  26.09242517219661,
                type = "unknown"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.4470867279357,
               
                longitude = 26.099220830833435,
                type = "souvenir shop"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44845318772376,
               
                longitude = 26.098481024146988,
                type = "museum"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44882059052618,
                longitude = 26.09985632131542,
                type = "unknown"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.448120211477786,
                
                longitude = 26.09757221325789,
                type = "food shop"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.446253517519715,
                

                longitude = 26.095140412833867,
                type = "residency"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.447728308038066,
                

                longitude = 26.093686712431392,
                type = "residency"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44542054951827,
               

                longitude = 26.09375365744,
                type = "residency"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44425296148042,
                

                longitude = 26.09701481639701,
                type = "residency"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44737321497266,
                longitude = 26.097244531292905,
                type = "cofee shop"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44646515998972,
                
                longitude = 26.096087241671157,
                type = "cofee shop"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44513360151565,
                

                longitude = 26.100065704981613,
                type = "cofee shop"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44516109047999,
                
                longitude = 26.09491085802221,
                type = "post office"
            });

            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.448083274308765,
                

                longitude = 26.097990586476424,
                type = "post office"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44849979810626,
                
                longitude = 26.094308373464717,
                type = "car rentals"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44751657188475,
                
                longitude = 26.089966365309643,
                type = "car rentals"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44494946363973,
                
                longitude = 26.094308335116775,
                type = "car rentals"
            });
            points.Add(new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                latitude = 44.44877275866783,
                
                longitude = 26.09962603467301,
                type = "car rentals"
            });
        }
    }
}
