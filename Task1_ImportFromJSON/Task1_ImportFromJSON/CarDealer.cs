namespace Task1_ImportFromJSON
{
    public class CarDealer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public CarDealer(string name, string city)
        {
            this.Name = name;
            this.City = city;

        }
    }
}