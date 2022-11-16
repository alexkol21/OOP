using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charisma_Shooting
{
    public partial class Form3 : Form
    {

        public List<int> score = new List<int>();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Turquoise;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            deserialize();
            while (score.Count() < 10)
            {
                score.Add(0);
            }
            score.Sort();
            score.Reverse();

            score1.Text = score[0].ToString();
            score2.Text = score[1].ToString();
            score3.Text = score[2].ToString();
            score4.Text = score[3].ToString();
            score5.Text = score[4].ToString();
            score6.Text = score[5].ToString();
            score7.Text = score[6].ToString();
            score8.Text = score[7].ToString();
            score9.Text = score[8].ToString();
            score10.Text = score[9].ToString();
        }
        private void deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("TopScores.ser", FileMode.Open, FileAccess.Read);
            score = (List<int>)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
