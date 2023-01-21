using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class EditCar : Form
    {
        int carId;
        public EditCar(Car car)
        {
            InitializeComponent();
            ModelTxtBox.Text = car.model;
            NarxiTxtBox.Text = car.narxi.ToString();
            YiliTxtBox.Text = car.yili.ToString();
            carId = car.id;
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car();
                car.model = ModelTxtBox.Text;
                car.narxi = int.Parse(NarxiTxtBox.Text);
                car.yili = int.Parse(YiliTxtBox.Text);
                await SaveCar(car);

                if (Application.OpenForms["Form1"] != null)
                {
                    (Application.OpenForms["Form1"] as Form1).RefreshList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        public async Task SaveCar(Car car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5258/api/Cars?id=" + carId.ToString());
            var response = await client.PutAsJsonAsync(client.BaseAddress, car);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Saved");
            }
        }
    }
}
