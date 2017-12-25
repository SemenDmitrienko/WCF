using System.ServiceModel;

namespace CarService
{
    [MessageContract(IsWrapped = true, WrapperName = "CarRequest", WrapperNamespace = "http://in1clickdomain.com")]
    public class CarRequest
    {
        [MessageBodyMember(Namespace = "http://in1clickdomain.com")]
        public int Id { get; set; }
        [MessageHeader(Namespace = "http://in1clickdomain.com")]
        public string LicenseKey { get; set; }
    }
}
