using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        CarService.CarServiceClient _client = new CarService.CarServiceClient("BasicHttpBinding_ICarService");

        private void btnSetCar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxId.Text);
            string vendor = tbxVendor.Text;
            string model = tbxModel.Text;
            int year = int.Parse(tbxYear.Text);

            _client.SetCar(new CarService.Car
            {
                Id = id,
                Vendor = vendor,
                Model = model,
                Year = year
            });
        }

        private void btnGetCar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxId.Text);

            CarClient.CarService.Car car = _client.GetCar(id);

            tbxId.Text = car.Id.ToString();
            tbxVendor.Text = car.Vendor;
            tbxModel.Text = car.Model;
            tbxYear.Text = car.Year.ToString();
        }
    }
}
