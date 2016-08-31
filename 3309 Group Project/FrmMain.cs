using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3309_Group_Project
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmPlayers myFormPlayers = new FrmPlayers();
        FrmCheckOut myFormCheckOut = new FrmCheckOut();
        FrmDoublePrice myFormDoublePrice = new FrmDoublePrice();
        FrmEasy123 myFormEasy123 = new FrmEasy123();
        FrmGoldenRoad myFormGoldenRoad = new FrmGoldenRoad();
        FrmMostExpensive myFormMostExpensive = new FrmMostExpensive();
        FrmOneWrongPrice myFormOneWrongPrice = new FrmOneWrongPrice();

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            myFormPlayers.ShowDialog();
            
        }
    }
}
