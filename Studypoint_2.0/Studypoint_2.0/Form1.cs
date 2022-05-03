using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studypoint_2._0
{
    public partial class StudypointFM : Form
    {
        KIRJAUDU kirjaudu = new KIRJAUDU();
        public StudypointFM()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            kirjaudu1.Visible = true;
            etusivu1.Visible = false;
            EtuBTPL.Visible = true;
        }

        private void RekisteroidyBT_Click(object sender, EventArgs e)
        {

        }

        private void OtayhteyttaBT_Click(object sender, EventArgs e)
        {

        }

        private void UuttaBT_Click(object sender, EventArgs e)
        {

        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {

        }

        private void kirjaudu1_Load(object sender, EventArgs e)
        {
            KirjauduBT.Visible = false;
            Etusivu01BT.Visible = true;
        }

        private void Etusivu01BT_Click(object sender, EventArgs e)
        {
            etusivu1.Visible = true;
            kirjaudu1.Visible = false;
            EtuBTPL.Visible = false;
        }

        private void etusivu1_Load(object sender, EventArgs e)
        {
            KirjauduBT.Visible = true;
            Etusivu01BT.Visible = false;
            EtuBTPL.Visible = false;
        }
    }
}
