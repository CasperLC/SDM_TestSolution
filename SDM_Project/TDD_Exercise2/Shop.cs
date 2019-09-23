using System;

namespace SDM_Project.TDD_Exercise2
{
    public class Shop: IComparable<Shop>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int gpsX { get; set; }
        public int gpsY { get; set; }
        public int CompareTo(Shop other)
        {
            throw new NotImplementedException();
        }
    }
}