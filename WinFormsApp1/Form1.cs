using Newtonsoft.Json;
using System;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Car> mainList;
        int numberPages = 0;
        int perPages = 10;
        int currentPage = 1;
        string searchString = "";
        string order;
        int columnIndex;
        public Form1()
        {
            InitializeComponent();
            mainList= new List<Car>();
            PagesNumber();
            RefreshList();
        }

        public async Task FillCarsList()
        {
            HttpClient client = new HttpClient();
            string apiText = $"{searchString}&perPage={perPages}&pageNumber={currentPage}&columnIndex={columnIndex}&order={order}"; 
            var response = await client.GetAsync("http://localhost:5258/api/Cars/PagingSearchSort?searchString=" + apiText);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Car>>(content);
                mainList = data.ToList();
            }
        }

        public async Task RefreshList()
        {
            await FillCarsList();
            MainListTable.Controls.Clear();
            foreach(var car in mainList)
            {
                CarsListItem listItem = new CarsListItem(car);
                listItem.Dock = DockStyle.Fill;
                MainListTable.Controls.Add(listItem);
            }
            if (mainList.Count == 0)
                MainListTable.Controls.Clear();
            PagesNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        public async Task PagesNumber()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5258/api/Cars/CarsNumber/?searchString=" + searchString);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<int>(content);
                numberPages = (data + (perPages - 1)) / perPages;
            }
            await CreatePagesButton();
        }

        public async Task CreatePagesButton()
        {
            tableLayoutPanel5.Controls.Clear();

            for (int i = 1; i <= numberPages; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Dock= DockStyle.Fill;
                btn.Click += PageBtnClick;
                tableLayoutPanel5.Controls.Add(btn);
            }
        }

        public void PageBtnClick(object sender, EventArgs e)
        {
            currentPage = int.Parse(((Button)sender).Text);
            RefreshList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            perPages = int.Parse(comboBox1.SelectedItem.ToString());
            RefreshList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchString = textBox1.Text;
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //searchString = textBox1.Text;
            //RefreshList();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Model": columnIndex = 1; break;
                case "Narx": columnIndex = 2; break;
                case "Yil": columnIndex = 3; break;
            }
            if (order is null || order == "desc")
                order = "asc";
            else order = "desc";

            RefreshList();
        }
    }
}