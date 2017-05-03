using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbowkerRPG
{
    public partial class MainView : Form
    {
        private Game game;

        public MainView()
        {
            game = new Game();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String helpURL = Directory.GetCurrentDirectory() + "\\help\\index.html";
            MessageBox.Show(helpURL);

            if(File.Exists(helpURL))
            {
            Process.Start(helpURL);
            }
            else
            {
                MessageBox.Show("Help file not found, please re-install the application.", "Error - Yet Another RPG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
