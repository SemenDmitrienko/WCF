using CarClient.CarService;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CarClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            cbxType.SelectedIndex = 0;
        }

        ICarService _client = new CarServiceClient("BasicHttpBinding_ICarService");

        private void btnSetCar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxId.Text);
            string vendor = tbxVendor.Text;
            string model = tbxModel.Text;
            int year = int.Parse(tbxYear.Text);
            CarInfo car = new CarInfo();

            switch (cbxType.SelectedIndex)
            {
                case 0:
                    car.Type = CarType.Car;
                    break;
                case 1:
                    car.Capacity = double.Parse(tbxType.Text, CultureInfo.GetCultureInfo("en-US"));
                    car.Type = CarType.TruckCar;
                    break;
                case 2:
                    car.Capacity = double.Parse(tbxType.Text, CultureInfo.GetCultureInfo("en-US"));
                    car.Type = CarType.PassengerCar;
                    break;
                default:
                    car.Type = CarType.Car;
                    break;
            }

            car.Id = id;
            car.Vendor = vendor;
            car.Model = model;
            car.Year = year;

            _client.SetCar(car);
        }

        private void btnGetCar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxId.Text);

            var car = _client.GetCar(new CarRequest("LKM5647-OM", id));

            tbxId.Text = car.Id.ToString();
            tbxVendor.Text = car.Vendor;
            tbxModel.Text = car.Model;
            tbxYear.Text = car.Year.ToString();

            if (car.Type == CarType.TruckCar)
            {
                cbxType.SelectedIndex = 1;
                tbxType.Text = car.Capacity.ToString(CultureInfo.GetCultureInfo("en-US"));
            }
            if (car.Type == CarType.PassengerCar)
            {
                cbxType.SelectedIndex = 2;
                tbxType.Text = car.Passengers.ToString(CultureInfo.GetCultureInfo("en-US"));
            }
            if (car.Type == CarType.Car)
            {
                cbxType.SelectedIndex = 0;
                tbxType.Text = "";
            }
                
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            showType((sender as ComboBox)?.Text ?? "");
        }

        private void showType(string type)
        {
            switch (type)
            {
                case "Car":
                    lblType.Visible = false;
                    tbxType.Visible = false;
                    lblType.Text = "";
                    break;
                case "Truck":
                    lblType.Visible = true;
                    tbxType.Visible = true;
                    lblType.Text = "Capacity";
                    break;
                case "Passenger":
                    lblType.Visible = true;
                    tbxType.Visible = true;
                    lblType.Text = "Passengers";
                    break;
                default:
                    lblType.Visible = false;
                    tbxType.Visible = false;
                    lblType.Text = "";
                    break;
            }
        }
    }
}
