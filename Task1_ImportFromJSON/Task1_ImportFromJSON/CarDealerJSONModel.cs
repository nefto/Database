using System;

namespace Task1_ImportFromJSON
{
    public class CarDealerJSONModel
    {
        public static Func<CarDealerJSONModel, CarDealer> ReturnDealerFromJSON
        {
            get
            {
                return carDealerJSON => new CarDealer(carDealerJSON.Name, carDealerJSON.City);

            }
        }

        public string Name { get; set; }
        public string City { get; set; }
    }
}