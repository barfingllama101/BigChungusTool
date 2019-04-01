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

namespace BigChungusTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filename;
        private String[] levelInfo = new String[3];
        private int numPlatforms = 0;
        private int numCarrots = 0;
        private int playerX;
        private int playerY;

        public string Filename { get => filename; set => filename = value; }
        public String[] LevelInfo { get => levelInfo; set => levelInfo = value; }
        public int NumPlatforms { get => numPlatforms; set => numPlatforms = value; }
        public int NumCarrots { get => numCarrots; set => numCarrots = value; }
        public int PlayerX { get => playerX; set => playerX = value; }
        public int PlayerY { get => playerY; set => playerY = value; }

        private void platformTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void carrotTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void platformButton_Click(object sender, EventArgs e)
        {
            if (platformTextBox.Text!=null)
            {
                numPlatforms += 1;
                levelInfo[0] = (numPlatforms + ",dog," + platformTextBox.Text);
            }
        }

        private void carrotButton_Click(object sender, EventArgs e)
        {
            if (carrotTextBox.Text != null)
            {
                numCarrots += 1;
                levelInfo[1] = (numCarrots + ",CarrotTexture," + carrotTextBox.Text);
            }
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text!=null)
            {
                filename = nameTextBox.Text;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter levelWriter = new StreamWriter(filename + ".txt");
                for (int i = 0; i < levelInfo.Length; i++)
                {
                    levelWriter.WriteLine("");
                    levelWriter.WriteLine(levelInfo[i]);
                }
                levelWriter.Close();
                errorLabel.Text = ("File created");
            }
            catch (Exception error)
            {
                errorLabel.Text = ("Error: " + error.Message);
                throw;
            }
        }

        private void spawnButton_Click(object sender, EventArgs e)
        {
            if (spawnTextBox.Text != null)
            {
                levelInfo[2] = spawnTextBox.Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
