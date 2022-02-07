using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int  a = rastgele.Next(0, 7);
            int  b = rastgele.Next(0, 7);
            int c = rastgele.Next(0, 7);
            int d = rastgele.Next(0, 7);
            label5.Text = a.ToString();
            label6.Text = b.ToString();
            label8.Text = c.ToString();
            label9.Text = d.ToString();
           
            if (Convert.ToInt32(label5.Text)>Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
              

            }

            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();

            }

            if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();

            }
            
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label9.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label9.Text))
            {
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
            }
         
           

        }
 
    }
}
     
