using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Charisma_Shooting
{
    public partial class Form1 : Form
    {
        SoundPlayer PlayButt = new SoundPlayer(soundLocation: @"zapsplat_multimedia_game_sound_tone_button_select_menu_sci_fi_001_40729.wav");
        SoundPlayer highscore = new SoundPlayer(soundLocation: @"zapsplat_multimedia_game_sound_menu_click_006_76692.wav");
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightCoral;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumOrchid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayButt.Play();
            Form2 form2 = new Form2();
            form2.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            highscore.Play();
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }
    }
}
