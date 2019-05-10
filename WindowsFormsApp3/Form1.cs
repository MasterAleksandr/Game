using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int stepChange = 1;
        public Form1()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            pl.BackColor = Color.Transparent;
            this.MouseClick += new MouseEventHandler(Form1MouseDown);
            this.KeyDown += new KeyEventHandler(OKP);

        }

        string lastButton = "S";
        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "X":
                    switch(lastButton)
                    {
                        case "A":
                            fireball.Size = new Size(44, 44);
                            fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                            fireball.Location = new Point (pl.Location.X - 40, pl.Location.Y);
                            break;
                        case "D":
                            var x = pl.Location.X;
                            while(x < 1285)
                            {
                                x += 1;
                                fireball.Size = new Size(44, 44);
                                fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                                fireball.Location = new Point(x, pl.Location.Y);
                            }
                            break;
                        case "S":
                            fireball.Size = new Size(44, 44);
                            fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                            fireball.Location = new Point(pl.Location.X, pl.Location.Y + 65);
                            break;
                        case "W":
                            fireball.Size = new Size(44, 44);
                            fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                            fireball.Location = new Point(pl.Location.X, pl.Location.Y - 40);
                            break;
                    }
                    break;
                case "A":
                    if (pl.Location.X > 10)
                    {
                        if (stepChange==1)
                        {
                            
                            stepChange = 2;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.left_step1;
                            pl.Location = new Point(pl.Location.X - 7, pl.Location.Y+1);
                            
                        }
                        else if(stepChange == 2)
                        {
                            stepChange = 3;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.left_stend;
                            pl.Location = new Point(pl.Location.X -7, pl.Location.Y);
                            
                        }
                        else if (stepChange == 3)
                        {
                            stepChange = 4;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.left_step2;
                            pl.Location = new Point(pl.Location.X - 7, pl.Location.Y - 1);
                        }
                        else 
                        {
                            stepChange = 1;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.left_stend;
                            pl.Location = new Point(pl.Location.X - 7, pl.Location.Y );

                        }
                    }
                    lastButton = "A";  
                    break;

                case "D":

                    if (pl.Location.X < 1285)
                    {
                        if (stepChange == 1)
                        {
                            stepChange = 2;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.right_step1;
                            pl.Location = new Point(pl.Location.X + 7, pl.Location.Y + 1);

                        }
                        else if (stepChange == 2)
                        {
                            stepChange = 3;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.right_stend;
                            pl.Location = new Point(pl.Location.X + 7, pl.Location.Y);

                        }
                        else if (stepChange == 3)
                        {
                            stepChange = 4;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.right_step2;
                            pl.Location = new Point(pl.Location.X + 7, pl.Location.Y - 1);
                        }
                        else
                        {
                            stepChange = 1;
                            pl.Size = new Size(40, 65);
                            pl.Image = Properties.Resources.right_stend;
                            pl.Location = new Point(pl.Location.X + 7, pl.Location.Y);

                        }
                    }
                    lastButton = "D";
                    break;

                case "W":
                    if (pl.Location.Y >44)
                    {
                        if (stepChange == 1)
                        {
                            stepChange = 2;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.up_step1;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y - 7);

                        }
                        else if (stepChange == 2)
                        {
                            stepChange = 3;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.up_stend;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y - 7);

                        }
                        else if (stepChange == 3)
                        {
                            stepChange = 4;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.up_step2;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y - 7);

                        }
                        else if (stepChange == 4)
                        {
                            stepChange = 1;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.up_stend;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y - 7);

                        }
                    }
                    lastButton = "W";
                    break;
                case "S":
                    
                    if (pl.Location.Y < 586)
                    {
                        if (stepChange==1)
                        {
                            stepChange = 2;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.down_step1;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y + 7);

                        }
                        else if (stepChange == 2)
                        {
                            stepChange = 3;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.down_stend;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y + 7);

                        }
                        else if (stepChange == 3)
                        {
                            stepChange = 4;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.down_step2;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y + 7);

                        }
                        else if (stepChange == 4)
                        {
                            stepChange = 1;
                            pl.Size = new Size(45, 65);
                            pl.Image = Properties.Resources.down_stend;
                            pl.Location = new Point(pl.Location.X, pl.Location.Y + 7);

                        }
                    }
                    lastButton = "S";
                    break;
                default:
                    pl.Image = Properties.Resources.up_stend;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        void Form1MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    fireball.Size = new Size(44, 44);
                    fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                    fireball.Location = pl.Location;

                    for (int x = pl.Location.X; x <= e.Location.X; x++)
                    {
                        fireball.Size = new Size(44, 44);
                        fireball.Image = Properties.Resources.a0cd84b264f852e4c7af031efb08af91_1_1_;
                        fireball.Location = new Point(fireball.Location.X + x, fireball.Location.Y);
                    }
                    break;
                default:
                    break;

                
            }

        }

        private void pl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
