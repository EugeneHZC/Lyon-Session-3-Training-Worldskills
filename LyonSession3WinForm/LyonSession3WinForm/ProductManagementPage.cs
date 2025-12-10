using LyonSession3API.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyonSession3WinForm
{
    public partial class ProductManagementPage : Form1
    {
        private static List<Product> products = new List<Product>();

        public ProductManagementPage()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            products = await Helper.Get<List<Product>>("products");
            productBindingSource.DataSource = products;
            //dataGridView1.DataSource = new ObservableCollection<Product>(products.ToList()).ToBindingList();
        }
    }
}
