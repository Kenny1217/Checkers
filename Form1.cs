using Checkers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayer1Ok_Click(object sender, EventArgs e)
        {
            string msg = "";
            PlayerNameValidation val = new PlayerNameValidation();
            if (!val.IsBlank(txtPlayer1Name.Text))
            {
                if (!val.IsDigit(txtPlayer1Name.Text))
                {
                   txtPlayer1Name.ReadOnly = true;
                   btnPlayer1Ok.Enabled = false;
                }
                else
                {
                    msg = "Player 1 can not have a digit";
                    txtPlayer1Name.Text = "";
                    txtPlayer1Name.Focus();
                }
            }
            else
            {
                msg = "Player 1 Name is empty or has whitespace";
                txtPlayer1Name.Text = "";
                txtPlayer1Name.Focus();
            }
        }

        private void btnPlayer2Ok_Click(object sender, EventArgs e)
        {
            string msg = "";
            PlayerNameValidation val = new PlayerNameValidation();
            if (!val.IsBlank(txtPlayer2Name.Text))
            {
                if (!val.IsDigit(txtPlayer2Name.Text))
                {
                    txtPlayer2Name.ReadOnly = true;
                    btnPlayer2Ok.Enabled = false;
                }
                else
                {
                    msg = "Player 2 can not have a digit";
                    txtPlayer2Name.Text = "";
                    txtPlayer2Name.Focus();
                }
            }
            else
            {
                msg = "Player 2 Name is empty or has whitespace";
                txtPlayer2Name.Text = "";
                txtPlayer2Name.Focus();
            }
        }

        private void btnPlayer1Edit_Click(object sender, EventArgs e)
        {
            txtPlayer1Name.ReadOnly = false;
            btnPlayer1Ok.Enabled = true;
        }

        private void btnPlayer2Edit_Click(object sender, EventArgs e)
        {
            txtPlayer2Name.ReadOnly = false;
            btnPlayer2Ok.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close(); //Closes game
        }

        











    }
}
