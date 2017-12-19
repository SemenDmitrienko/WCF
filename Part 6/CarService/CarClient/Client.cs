using CarClient.CarService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        CarServiceClient _client = new CarService.CarServiceClient("BasicHttpBinding_ICarService");

        private void btnSetCar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxId.Text);
            string vendor = tbxVendor.Text;
            string model = tbxModel.Text;
            int year = int.Parse(tbxYear.Text);
            Car car;

            switch (cbxType.SelectedIndex)
            {
                case 0:
                    car = new Car();
                    break;
                case 1:
                    car = new TruckCar { Capacity = double.Parse(tbxType.Text, CultureInfo.GetCultureInfo("en-US"))};
                    break;
                case 2:
                    car = new PassengerCar { Passengers = int.Parse(tbxType.Text, CultureInfo.GetCultureInfo("en-US")) };
                    break;
                default:
                    car = new Car();
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

            Car car = _client.GetCar(id);

            tbxId.Text = car.Id.ToString();
            tbxVendor.Text = car.Vendor;
            tbxModel.Text = car.Model;
            tbxYear.Text = car.Year.ToString();

            if (car is TruckCar)
            {
                cbxType.SelectedIndex = 1;
                tbxType.Text = ((TruckCar)car).Capacity.ToString(CultureInfo.GetCultureInfo("en-US"));
            }
            else if (car is PassengerCar)
            {
                cbxType.SelectedIndex = 2;
                tbxType.Text = ((PassengerCar)car).Passengers.ToString(CultureInfo.GetCultureInfo("en-US"));
            }
            else
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
