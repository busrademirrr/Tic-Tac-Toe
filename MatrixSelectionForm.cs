using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MatrixSelectionForm : Form
    {
        private bool isSinglePlayer;

        public MatrixSelectionForm(bool singlePlayer)
        {
            InitializeComponent();
            isSinglePlayer = singlePlayer;
        }

        private void pictureBox3x3_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(3, isSinglePlayer);
            gameForm.Show();
            this.Hide();
        }

        private void pictureBox5x5_Click(object sender, EventArgs e)
        {
            // 5x5 seçeneği için
            GameForm gameForm = new GameForm(5, isSinglePlayer);
            gameForm.Show();
            this.Hide();
        }

        private void pictureBox7x7_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(7, isSinglePlayer);
            gameForm.Show();
            this.Hide();
        }

        private void pictureBox3x3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
