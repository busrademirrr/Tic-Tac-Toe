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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            MatrixSelectionForm matrixSelectionForm = new MatrixSelectionForm(true);
            matrixSelectionForm.Show();
            this.Hide();
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            MatrixSelectionForm matrixSelectionForm = new MatrixSelectionForm(false);
            matrixSelectionForm.Show();
            this.Hide();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
