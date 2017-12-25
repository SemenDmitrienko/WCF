using System.ServiceModel;

namespace CarService
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void SetCar(CarInfo c);

        [OperationContract]
        CarInfo GetCar(CarRequest id);
    }
}
