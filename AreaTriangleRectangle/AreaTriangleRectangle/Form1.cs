using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangleRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Visible = true;
            txtY.Visible = true;
            txtz.Visible = false;
            lblRecTri.Visible = true;
            lblRecTri1.Visible = true;
            lblRecTri2.Visible = false;
            lblRecTri.Text = "Enter Length: ";
            lblRecTri1.Text = "Enter Width: ";
            btnCalRec.Visible = true;
            btnCalTri.Visible = false;
            
        }

        private void rdbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Visible = true;
            txtY.Visible = true;
            txtz.Visible = true;
           
            lblRecTri.Visible = true;
            lblRecTri1.Visible = true;
            lblRecTri2.Visible = true;
            lblRecTri.Text = "Enter Base: ";
            lblRecTri1.Text = "Enter Height: ";
            lblRecTri2.Text = "Enter Hypotenuse: ";
            btnCalTri.Visible = true;
            btnCalRec.Visible = false;
        }

        private void btnCalRec_Click(object sender, EventArgs e)
        {
            lblArea.Visible = true;
            lblPeri.Visible = true;
            label2.Visible = true;
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
           
            Rectangle ract = new Rectangle();
            ract.x = x;
            ract.y = y;
           
            lblArea.Text = "Area =  " + ract.Area().ToString();
            
            Rectangle ract1 = new Rectangle();
            ract1.x = x;
            ract1.y = y;
            
            lblPeri.Text =  "Perimeter =  " + ract.Perimeter().ToString();

        }

        private void btnCalTri_Click(object sender, EventArgs e)
        {
            lblArea.Visible = true;
            lblPeri.Visible = true;
            label2.Visible = true;
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double z = Convert.ToDouble(txtz.Text);

           Triangle Tri = new Triangle();
           Tri .x = x;
            Tri.y = y;
            Tri.z = z;

            lblArea.Text = "Area =  " + Tri.Area().ToString();

            Triangle Tri1 = new Triangle();
            Tri1.x = x;
            Tri1.y = y;
            Tri1.z = z;

            lblPeri.Text = "Perimeter =  " + Tri1.Perimeter().ToString();

        }

    }
}

