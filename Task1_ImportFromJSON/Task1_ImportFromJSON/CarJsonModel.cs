using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ImportFromJSON
{
    public class CarJsonModel
    {
        public int Year { get; set; }
        public int TransmissionType { get; set; }
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public CarDealerJSONModel Dealer { get; set; }

        public static Func<CarJsonModel, Car> FromJsonModel
        {
            get
            {
                return jsomModel => new Car
                {
                    Model = jsomModel.Model,
                    Dealer = CarDealerJSONModel.ReturnDealerFromJSON(jsomModel.Dealer),
                    ManufacturerName = jsomModel.ManufacturerName,
                    Price = jsomModel.Price,
                    TransmissionType = jsomModel.TransmissionType,
                    Year = jsomModel.Year
                };
            }
        }
    }
}
