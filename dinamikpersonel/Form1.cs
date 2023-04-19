using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamikpersonel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

            
            System.Windows.Forms.Label l1= new System.Windows.Forms.Label();
            l1.AutoSize = true;
            l1.Location = new System.Drawing.Point(144, 39);
            l1.Name = "label1";
            l1.Size = new System.Drawing.Size(35, 13);
            l1.TabIndex = 0;
            l1.Text = "label1";
            System.Windows.Forms.Label l2= new System.Windows.Forms.Label();
            l2.AutoSize = true;
            l2.Location = new System.Drawing.Point(144, 39);
            l2.Name = "label2";
            l2.Size = new System.Drawing.Size(35, 13);
            l2.TabIndex = 0;
            l2.Text = "label2";
            TextBox tt1 = new TextBox();
            tt1.Location = new Point(185, 52);// location property textbox x,y koordinat
            tt1.Size = new Size(100, 20);
            Controls.Add(tt1);
        }
    }
}
