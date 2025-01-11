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
    public partial class ResultForm : Form
    {
        public ResultForm(string resultMessage)
        {
            InitializeComponent();
           labelResult.Text = resultMessage;
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {
            // Formun yüklendiğinde yapılacak işlemler
            // Örneğin: sonucu gösterme, kazananı belirleme, vs.
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void labelResult_Click(object sender, EventArgs e)
        {

        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // Ana menüye dönme işlemi
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}