namespace Task1_ImportFromJSON
{
    public class Car
    {
        public CarDealer Dealer { get; internal set; }
        public string ManufacturerName { get; internal set; }
        public string Model { get; internal set; }
        public decimal Price { get; internal set; }
        public int TransmissionType { get; internal set; }
        public int Year { get; internal set; }
    }
}