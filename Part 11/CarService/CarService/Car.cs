using System.Runtime.Serialization;
using System.ServiceModel;

namespace CarService
{
    [KnownType(typeof(TruckCar))]
    [KnownType(typeof(PassengerCar))]
    [DataContract]
    public class Car : IExtensibleDataObject
    {
        [DataMember(Order = 2)]
        public int Id { get; set; }
        [DataMember(Order = 3)]
        public string Vendor { get; set; }
        [DataMember(Order = 4)]
        public string Model { get; set; }
        //[DataMember(Order = 1)]
        //public int Year { get; set; }
        [DataMember(Order = 5, IsRequired = true)]
        public int MileAge { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
