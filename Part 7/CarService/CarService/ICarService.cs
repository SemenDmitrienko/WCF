using System.ServiceModel;

namespace CarService
{
    //[ServiceKnownType(typeof(TruckCar))]
    //[ServiceKnownType(typeof(PassengerCar))]
    [ServiceContract]
    public interface ICarService
    {
        //[ServiceKnownType(typeof(TruckCar))]
        //[ServiceKnownType(typeof(PassengerCar))]
        [OperationContract]
        void SetCar(Car c);

        //[ServiceKnownType(typeof(TruckCar))]
        //[ServiceKnownType(typeof(PassengerCar))]
        [OperationContract]
        Car GetCar(int id);
    }
}
