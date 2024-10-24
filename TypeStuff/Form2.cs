using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeStuff
{
    public partial class Form2 : Form
    {
        public Form2(int timeForm1, char[] correctInputArrayForm1 = null)
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;

            char[] correctInputArray = correctInputArrayForm1;
            if (correctInputArray != null)
            {
                int spaceCount = 0;
                int time = timeForm1;

                this.button1.Location = new System.Drawing.Point(313, 73);
                this.button1.Text = "Restart";
                this.button2.Location = new System.Drawing.Point(313, 159);
                this.ClientSize = new System.Drawing.Size(464, 229);
                this.groupBox1.Visible = true;
                this.groupBox1.Location = new System.Drawing.Point(26, 27);

                for (int i = 0; i < correctInputArray.Length; i++)
                {
                    if (correctInputArray[i] == ' ')
                    {
                        spaceCount += 1;
                    }
                }

                double typeSpeed = 0;
                if (spaceCount != 0)
                {
                    typeSpeed = Convert.ToDouble(spaceCount) / Convert.ToDouble(time) * 60;
                }
                label4.Text = Convert.ToString(time) + " s";
                label5.Text = Convert.ToString(spaceCount) + " words";
                label6.Text = Convert.ToString(Math.Round(typeSpeed, 1));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 typeStuffForm = new Form1();
            typeStuffForm.Show();
            this.Hide();
            typeStuffForm.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
