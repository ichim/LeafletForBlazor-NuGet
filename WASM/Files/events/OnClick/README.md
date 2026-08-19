
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

