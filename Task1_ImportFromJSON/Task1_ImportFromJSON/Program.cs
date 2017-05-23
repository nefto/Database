using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1_ImportFromJSON
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = File.ReadAllText("..\\..\\..\\data.number.json");

            var cars = JsonConvert.DeserializeObject<CarJsonModel[]>(json);
            IEnumerable<Car> carsModel = cars.Select(CarJsonModel.FromJsonModel);
            
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Query.xml");
            XmlNode rootNode = doc.DocumentElement;
            XmlNodeList queries = doc.GetElementsByTagName("Query");
            QueryGenerator queryGenerator = new QueryGenerator();
            foreach (XmlNode query in queries)
            {
                var outputFilename = query.Attributes["OutputFileName"].Value;
                foreach (XmlNode currentClause in query.ChildNodes)
                {
                    switch (currentClause.Name)
                    {
                        case "OrderBy":
                            queryGenerator.OrderBy.Add(currentClause.InnerText);
                            break;
                        default:
                            break;
                    }
                    if (currentClause.Name == "OrderBy")
                    {

                    }
                }                
            }
        }
    }
}
