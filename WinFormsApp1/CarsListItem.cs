using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class CarsListItem : UserControl
    {
        Car addCar;
        public CarsListItem(Car car)
        {
            InitializeComponent();
            IdLbl.Text = car.id.ToString();
            ModelLbl.Text = car.model;
            NarxLbl.Text = car.narxi.ToString();
            YiliLbl.Text = car.yili.ToString();
            addCar= car;
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            await DeleteCar();
            var parent = this.ParentForm as Form1;
            if (parent != null)
            {
                parent.RefreshList();
            }
        }

        public async Task DeleteCar()
        {
            HttpClient client = new HttpClient();
            var response = await client.DeleteAsync("http://localhost:5258/api/Cars/Delete?id=" + addCar.id.ToString());
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCar editCar = new EditCar(addCar);
            editCar.Show();
        }
    }
}
