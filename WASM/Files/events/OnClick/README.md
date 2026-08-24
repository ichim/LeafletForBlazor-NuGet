
# OnClick event

This is triggered whenever a click is made on the map.

     map.Geometric.From.Files.OnClick += (sender, args) =>
     {
         
     };

 Where args is:

        public class FilesItemsEventArgs : EventArgs
        {
            public List<ExpandoObject> geometriesFound { get; set; }
            public Coordinates geoid { get; set; }
            public Coordinates screen { get; set; }
        }

Code example. How to extract data from the OnClick event:

           map.Geometric.From.Files.OnClick += (sender, args) =>
           {
               foreach(ExpandoObject shape in args.geometriesFound)
               {
                   foreach(var dict in shape)
                   {
                       if(dict.Value is ExpandoObject newTree)
                       {
                           foreach(var dictTree in newTree)
                           {
                               Console.WriteLine($"Key: {dictTree.Key} / Value: {dictTree.Value}");
                           }
                       }
                       else
                           Console.WriteLine($"Key: {dict.Key} / Value: {dict.Value}");
                   }
               }
           };
