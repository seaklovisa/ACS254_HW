using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>{
                new Product{Name = "iPhone12",Price = 17000,ForeColor = Color.Black, CategoryName = "IIOS"},
                new Product{Name = "iPad Thunder",Price = 27000,ForeColor = Color.Black,CategoryName = "IIOS"},
                new Product{Name = "Samsang Galaxy S9+",Price = 18900,ForeColor = Color.Black,CategoryName = "Bndroid"},
                new Product{Name = "HTc M60 - 5",Price = 24000,ForeColor = Color.Black,CategoryName = "Bndroid"},
                new Product{Name = "Sorry xperia ZZ",Price = 23000,ForeColor = Color.Black,CategoryName = "Bndroid",Hot=Color.Red},
                new Product{Name = "Nokie Lumia 1520",Price = 22111,ForeColor = Color.Black,CategoryName = "WindowPhone",Hot=Color.Red},
                new Product{Name = "Nokie Lumia 925",Price = 15900,ForeColor = Color.Black,CategoryName = "WindowPhone",OffPrice = 10000},
            };

            //排序一下再丟進去
            productList.Items.AddRange(products.OrderBy(x => x.CategoryName).ToArray());
        }
    }
}