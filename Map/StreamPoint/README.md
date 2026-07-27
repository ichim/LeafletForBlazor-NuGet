# StreamPoint collection

The StreamPoint collection is hosted by @map.Geometric.Points and provides operating functionalities with a predefined but hierarchically extensible root data structure.

What does root data structure mean?

``StreamPoint`` has a predefined, mandatory structure without which these points cannot function correctly.

    public class StreamPoint : IStreamPoint, IStreamType
    {
        public Guid guid { get; set; }                                            //unique identifier
        public Coordinates coordinates { get; set; } = new Coordinates();         //WGS coordinates
        public object value { get; set; }                                         //this property allows hierarchical expansion with other attributes
        public DateTime timestamp { get; set; }                                   //data time, are often used in the MemoryCache mechanism
        public string? type { get; set; }                                         //allows for a classification of data. Often used for map appearance
    }



## Add

## Remove

## Update

## Appearance
