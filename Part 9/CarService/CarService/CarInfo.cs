using System.ServiceModel;

namespace CarService
{
    [MessageContract(IsWrapped =true, WrapperName = "CarInfoWrapper", WrapperNamespace ="http://in1clickdomain.com")]
    public class CarInfo
    {
        public CarInfo()
        {

        }

        public CarInfo(Car carInstance)
        {
            Id = carInstance.Id;
            Vendor = carInstance.Vendor;
            Model = carInstance.Model;
            Year = carInstance.Year;
            Type = CarType.Car;

            if (carInstance.GetType() == typeof(TruckCar))
            {
                Capacity = ((TruckCar)carInstance).Capacity;
                Type = CarType.TruckCar;
            }
            if (carInstance.GetType() == typeof(PassengerCar))
            {
                Passengers = ((PassengerCar)carInstance).Passengers;
                Type = CarType.PassengerCar;
            }

        }
        [MessageBodyMember]
        public int Id { get; set; }
        [MessageBodyMember]
        public string Vendor { get; set; }
        [MessageBodyMember]
        public string Model { get; set; }
        [MessageBodyMember]
        public int Year { get; set; }
        [MessageBodyMember]
        public int Passengers { get; set; }
        [MessageBodyMember]
        public double Capacity { get; set; }
        [MessageBodyMember]
        public CarType Type { get; set; }
    }
}
