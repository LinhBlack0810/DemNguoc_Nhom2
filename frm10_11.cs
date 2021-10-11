using LinhBlack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace LinhBlack
{
    public partial class frm10_11 : Form
    {
        public frm10_11()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.HappyNewYear);
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (second == 0) { 
                timer1.Stop();
                DialogResult dlr=MessageBox.Show("Are you ok (^_^)");
                if(dlr == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(@"E:\phaohoa.gif ");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    player.Stream.Position = 0;
                    player.Play();

                }
                
          
               
               

            }
            else
            {
                second--;
                label2.Text = $"{second/60}:{ second%60}";
            }
        }

        int second = 0;
        
        private void btnbatdau_Click(object sender, EventArgs e)
        {
            second = (int)timer.Value *60;
            timer1.Start();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
