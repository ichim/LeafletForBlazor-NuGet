
using static LeafletForBlazor.Map;

namespace Data.Input
{
    public class IndustrialValues
    {
        public double[]? production { get; set; }
        public string[]? texts { get; set; }
        public string[]? classes { get; set; }
    }

    public class SpeedValues
    {
        public double? speedMax { get; set; }
        public double? speedMin { get; set; }
        public double? speed { get; set; }
    }

    public class DroneFuel
    {
        public string[]? colors { get; set; }
        public double[]? percentages { get; set; }
        public string[]? labels { get; set; }
        public int? value { get; set; } = 0;
    }

    public class DroneTrak
    {
        public double? speed { get; set; } = 0;
        public double? battery { get; set; } = 0;
        public int wifiLevel { get; set; } = 0;
        public double? fuel { get; set; } = 0;
        public double? altitude { get; set; } = 0;
        public double timeSpent { get; set; } = 0;
    }


    public class DroneFuelFilling
    {
        public double? startFuel { get; set; } = 0;
        public double? endFuel { get; set; } = 100;
        public double? value { get; set; } = 0;
        public double? startBattery { get; set; } = 0;
        public double? endBattery { get; set; } = 100;
        public double? level { get; set; } = 0;
    }
    public class StreamPoints
    {
        public List<StreamPoint> points = new List<StreamPoint>()
        {
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.860847591747186,  4.227255449993002 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000001"),
                    type = "Industrial",
                    value = new IndustrialValues()
                    {
                        production = new double[4] { 400, 200, 300, 50 },
                        texts = new string[3] { "Low", "Medium", "High" },
                        classes = new string[4] { "white", "yellow", "red", "gray" }
                    }

                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.882847591747186,  4.288255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000002"),
                     type = "Park",
                     value = "Disneyland"
                },
                  new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.62847591747186,  4.4255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000004"),
                     type = "Park",
                     value = "Amusement (2)"
                },
                     new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.60847591747186,  4.6255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000006"),
                     type = "Industrial",
                     value = new IndustrialValues()
                    {
                        production = new double[3] { 40, 80, 300 },
                        texts = new string[3] { "easy", "Medium", "Heavy" },
                       classes = new string[3] { "azure", "orange", "brown" }
                    }
                },
                             new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.61840,  4.638040 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000008"),
                     type = "Market",
                     value = "Local Market"
                },
                             new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] {  50.960847591747186,  4.327255449993002}
                    },             //00000000-0000-0000-0000-000000000020
                    guid = new Guid("00000000-0000-0000-0000-000000000020"),
                     type = "Industrial",
                    value = new IndustrialValues()
                    {
                        production = new double[6] { 30,60,20,80,120,400 },
                         texts = new string[6] { "A","B", "C", "D", "E", "FA" },
                        classes = new string[6] { "indianred", "green", "yellow","brown", "orange","red"}
                    }
                },

                 new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 51.2238430516536, 5.3244195839057005 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000022"),
                     type = "Industrial",
                     value = new IndustrialValues()
                    {
                        production = new double[3] { 30, 200, 120 },
                        texts = new string[3] { "Low", "Medium", "High" },
                        classes = new string[3] { "white", "yellow", "red" }
                    }
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.36778218921488, 5.514295121160788 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000024"),
                    type = "Market",
                    value = "Local Market (2)"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.536507651588, 3.779197489605147 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000026"),
                     type = "Souvenirs",
                     value = "Souvenir Shop"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.81044933309833, 3.012712647249016 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000028"),
                     type = "Souvenirs",
                     value = "Souvenir Shop"                },
                     new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.975439016816225, 5.075631752399717 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000040"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.81312396164056, 5.11950296132925 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000042"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.73920389805987, 4.683492331725523 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000044"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.85307921477056, 5.011282532093949 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000046"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.95378559667879, 4.989300750159471 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000048"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 51.12676724171815, 4.79665627330793 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000060"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.92947867286425, 4.930286512219346 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000062"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 51.10894028989639, 4.9294043986552785 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000064"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.87368858789195, 4.753136270850954 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000066"),
                     type = "Workshop",
                     value = "Car Repair"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.92538381958736, 4.700954547080917 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000068"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.84692327148474, 4.579791169521665 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000080"),
                     type = "Deposit",
                     value = "Bank"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 51.10894028989639, 4.9294043986552785 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000082"),
                     type = "Deposit",
                     value = "Online Store"
                },

                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.92482817386561, 4.212191532922628 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000084"),
                     type = "Workshop",
                     value = "Car Repair"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.87632223381341, 4.1010742821982555 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000086"),
                     type = "Workshop",
                     value = "Car Repair"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.974300992149686, 4.117211315658318 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000088"),
                     type = "Workshop",
                     value = "Car Repair"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.90091608549828, 4.001328944699709 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000200"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.951451266515306, 3.986288916944186 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000202"),
                    type = "Souvenirs",
                    value = "Souvenir Shop"                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.99270619185104, 3.9893687826195494 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000204"),
                     type = "Auto",
                     value = "Car Dealership"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.77043876141215, 4.268419163355712 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000206"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.7790289388057, 4.137552259042519 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000208"),
                     type = "Deposit",
                     value = "Bank"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.720143897473804, 4.053403630585305 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000220"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.67360233178867, 4.128960872425004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000222"),
                     type = "Deposit",
                     value = "Bank"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.79741662806712, 3.858659635874197 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000224"),
                     type = "Deposit",
                     value = "Online Store"
                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.7054148948664, 3.7832117152321847 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000226"),
                     type = "Auto",
                     value = "Car Dealership"
                },
        };
        public List<StreamPoint> test = new List<StreamPoint>()
        {
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 45.29202308966132, 27.970245162324545 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000001"),
                     type = "Sigma",
                      value = new DroneTrak()
                    {
                      battery = 8,
                      fuel = 0,
                      speed = 0,
                      timeSpent = 0.6
                    }

                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 45.28945914280691, 28.001053738673114 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000002"),
                     type = "Sigma",
                      value = new DroneTrak()
                    {
                      battery = 9,
                      fuel = 1,
                      speed = 0,
                      timeSpent = 1
                    }
                },
                  new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 45.27482512292329, 27.969996482781905 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000004"),
                        type = "Sigma",
                      value = new DroneTrak()
                    {
                      battery = 6,
                      fuel = 2,
                      speed = 0,
                      timeSpent = 1.2
                    }
                },
                //     new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.60847591747186,  4.6255449993004 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000006"),
                //     type = "Industrial",
                //     value = new IndustrialValues()
                //    {
                //        production = new double[3] { 40, 80, 300 },
                //        texts = new string[3] { "easy", "Medium", "Heavy" },
                //       classes = new string[3] { "azure", "orange", "brown" }
                //    }
                //},
                //             new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.61840,  4.638040 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000008"),
                //     type = "Market",
                //     value = "Local Market"
                //},
                //             new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] {  50.960847591747186,  4.327255449993002}
                //    },             //00000000-0000-0000-0000-000000000020
                //    guid = new Guid("00000000-0000-0000-0000-000000000020"),
                //     type = "Industrial",
                //    value = new IndustrialValues()
                //    {
                //        production = new double[6] { 30,60,20,80,120,400 },
                //         texts = new string[6] { "A","B", "C", "D", "E", "FA" },
                //        classes = new string[6] { "indianred", "green", "yellow","brown", "orange","red"}
                //    }
                //},

                // new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 51.2238430516536, 5.3244195839057005 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000022"),
                //     type = "Industrial",
                //     value = new IndustrialValues()
                //    {
                //        production = new double[3] { 30, 200, 120 },
                //        texts = new string[3] { "Low", "Medium", "High" },
                //        classes = new string[3] { "white", "yellow", "red" }
                //    }
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.36778218921488, 5.514295121160788 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000024"),
                //    type = "Market",
                //    value = "Local Market (2)"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.536507651588, 3.779197489605147 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000026"),
                //     type = "Souvenirs",
                //     value = "Souvenir Shop"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.81044933309833, 3.012712647249016 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000028"),
                //     type = "Souvenirs",
                //     value = "Souvenir Shop"                },
                //     new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.975439016816225, 5.075631752399717 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000040"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.81312396164056, 5.11950296132925 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000042"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.73920389805987, 4.683492331725523 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000044"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.85307921477056, 5.011282532093949 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000046"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.95378559667879, 4.989300750159471 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000048"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 51.12676724171815, 4.79665627330793 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000060"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.92947867286425, 4.930286512219346 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000062"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 51.10894028989639, 4.9294043986552785 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000064"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.87368858789195, 4.753136270850954 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000066"),
                //     type = "Workshop",
                //     value = "Car Repair"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.92538381958736, 4.700954547080917 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000068"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.84692327148474, 4.579791169521665 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000080"),
                //     type = "Deposit",
                //     value = "Bank"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 51.10894028989639, 4.9294043986552785 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000082"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},

                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.92482817386561, 4.212191532922628 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000084"),
                //     type = "Workshop",
                //     value = "Car Repair"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.87632223381341, 4.1010742821982555 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000086"),
                //     type = "Workshop",
                //     value = "Car Repair"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.974300992149686, 4.117211315658318 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000088"),
                //     type = "Workshop",
                //     value = "Car Repair"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.90091608549828, 4.001328944699709 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000200"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.951451266515306, 3.986288916944186 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000202"),
                //    type = "Souvenirs",
                //    value = "Souvenir Shop"                },
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.99270619185104, 3.9893687826195494 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000204"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.77043876141215, 4.268419163355712 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000206"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.7790289388057, 4.137552259042519 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000208"),
                //     type = "Deposit",
                //     value = "Bank"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.720143897473804, 4.053403630585305 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000220"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.67360233178867, 4.128960872425004 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000222"),
                //     type = "Deposit",
                //     value = "Bank"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.79741662806712, 3.858659635874197 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000224"),
                //     type = "Deposit",
                //     value = "Online Store"
                //},
                //new StreamPoint()
                //{
                //    coordinates = new Coordinates()
                //    {
                //        xy = new double[2] { 50.7054148948664, 3.7832117152321847 }
                //    },
                //    guid = new Guid("00000000-0000-0000-0000-000000000226"),
                //     type = "Auto",
                //     value = "Car Dealership"
                //},
        };
    }
}
