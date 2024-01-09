using GunshopInventorySystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunshopInventorySystem
{
    public partial class MainMenu_Frm : Form
    {
        public MainMenu_Frm()
        {
            InitializeComponent();
        }

        private void Firearm_Btn_Click(object sender, EventArgs e)
        {
            Firearms FirearmFrm = new Firearms();
            this.Hide();
            FirearmFrm.Show();
        }
    }
}
