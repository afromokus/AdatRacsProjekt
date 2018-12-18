using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendegProjekt
{
    public partial class Form1 : Form
    {
        Adatbazis ad = new Adatbazis();
        MySQLDatabaseInterface mdi;
        DataTable vendegDT;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mdi = ad.kapcsolodas();
            mdi.open();
            vendegDT = mdi.getToDataTable("SELECT * FROM vendegek");
            adatRacs.DataSource = vendegDT;
        }

        private void adatRacs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
