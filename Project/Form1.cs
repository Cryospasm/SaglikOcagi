using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Baglanti bag = new Baglanti();
            DataTable dt = new DataTable();
            dt = bag.DataTableGetir("select * from hasta");
            dataGridView1.DataSource = dt;
        }

        
    }
}
