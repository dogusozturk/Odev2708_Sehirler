using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Odev2708Sehirler
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSehir.ValueMember = "SehirID";
            comboBoxSehir.DisplayMember = "Isim";
            List<Sehirler> cities = dm.GetSehir();
            cities.Insert(0, new Sehirler { SehirID = 0, Isim = "Seçiniz" });
            comboBoxSehir.DataSource = cities;
            comboBoxIlce.Enabled = false;
        }

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SehirID = comboBoxSehir.SelectedIndex;
            if (SehirID != 0)
            {
                comboBoxIlce.Enabled = true;
                comboBoxIlce.DisplayMember = "Isim";
                comboBoxIlce.ValueMember = "IlceID";
                comboBoxIlce.DataSource = dm.GetIlce(SehirID);
            }
            else
            {
                comboBoxIlce.Enabled = false;
                comboBoxIlce.Text = "";
            }
        }
    }
}
