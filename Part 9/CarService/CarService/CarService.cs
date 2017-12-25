using System.Linq;
using System.Configuration;
using System.Xml.Linq;
using System.Globalization;

namespace CarService
{
    public class CarService : ICarService
    {
        public void SetCar(CarInfo c)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];

            var doc = XDocument.Load(file);

            var element = new XElement("Car", new XAttribute("Id", c.Id),
                          new XElement("Vendor", c.Vendor),
                          new XElement("Model", c.Model),
                          new XElement("Year", c.Year));

            if (c.Type == CarType.PassengerCar)
            {
                element.Add(new XAttribute("Type", "Passenger"),
                            new XElement("Passengers", c.Passengers.ToString(CultureInfo.GetCultureInfo("en-US"))));

            }
            else if (c.Type == CarType.TruckCar)
            {
                element.Add(new XAttribute("Type", "Truck"),
                            new XElement("Capacity", c.Capacity.ToString(CultureInfo.GetCultureInfo("en-US"))));
            }
            else
            {
                element.Add(new XAttribute("Type", "Car"));
            }

            doc.Root.Add(element);

            doc.Save(file);
        }

        public CarInfo GetCar(CarRequest request)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];

            Car result;

            var doc = XDocument.Load(file);

            var element = doc.Descendants("Car").FirstOrDefault(x => x.Attribute("Id").Value == request.Id.ToString());

            switch (element.Attribute("Type").Value)
            {
                case "Passenger":
                    result = new PassengerCar{ Passengers = int.Parse(element.Element("Passengers").Value, CultureInfo.GetCultureInfo("en-US")) };
                    break;
                case "Truck":
                    result = new TruckCar{ Capacity = double.Parse(element.Element("Capacity").Value, CultureInfo.GetCultureInfo("en-US")) };
                    break;
                default:
                    result = new Car();
                    break;
            }

            result.Id = int.Parse(element.Attribute("Id").Value);
            result.Vendor = element.Element("Vendor").Value;
            result.Model = element.Element("Model").Value;
            result.Year = int.Parse(element.Element("Year").Value);

            return new CarInfo(result);
        }

    }
}
