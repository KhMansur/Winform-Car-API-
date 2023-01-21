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
using WinFormsApp1;

namespace WinFormsApp1.Forms
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car();
                car.model = ModelTxtBox.Text;
                car.narxi = int.Parse(NarxiTxtBox.Text);
                car.yili = int.Parse(YiliTxtBox.Text);
                await AddNewCar(car);

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

        public async Task AddNewCar(Car car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5258/api/Cars/Add");
            var response = await client.PostAsJsonAsync(client.BaseAddress, car);
            
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Added");
            }
        }
    }
}
