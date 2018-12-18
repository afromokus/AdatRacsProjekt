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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adatRacs.ReadOnly = true;
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            betoltes();
        }

        private void betoltes()
        {
            mdi = ad.kapcsolodas();
            mdi.open();
            adatRacs.DataSource = mdi.getToDataTable("SELECT * FROM vendegek");
        }

        private void adatRacs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            betoltes();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            adatRacs.ReadOnly = false;
            buttonCancel.Visible = true;
            buttonSave.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            betoltes();
            adatRacs.ReadOnly = true;
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
        }
    }
}
