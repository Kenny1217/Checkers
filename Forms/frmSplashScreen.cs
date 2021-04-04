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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
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
                if (!val.IsSameName(txtPlayer1Name.Text,txtPlayer2Name.Text))
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
                    msg = "Players can not have matching names";
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
                if (!val.IsSameName(txtPlayer2Name.Text, txtPlayer1Name.Text))
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
                    msg = "Players names can not match";
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
            if (txtPlayer1Name.ReadOnly == true && txtPlayer2Name.ReadOnly == true) //Check if names have been entered
            {
                //Take player to form 2
                string PlayerRed = txtPlayer1Name.Text; //Store red player name
                string PlayerBlack = txtPlayer2Name.Text; //Store black player name
                frmGameBoard frm2 = new frmGameBoard(); //Create form 2
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter players name to play.");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close(); //Closes game
        }
    }
}
