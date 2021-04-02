
namespace Checkers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPlayer1Ok = new System.Windows.Forms.Button();
            this.btnPlayer2Ok = new System.Windows.Forms.Button();
            this.btnPlayer1Edit = new System.Windows.Forms.Button();
            this.btnPlayer2Edit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(104, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(436, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the game of Checkers!";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(161, 67);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(312, 20);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Please start by entering the Player\'s names";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(163, 143);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(77, 13);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1 (Red):";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(156, 183);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(84, 13);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2 (Black):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnPlayer1Ok
            // 
            this.btnPlayer1Ok.Location = new System.Drawing.Point(368, 137);
            this.btnPlayer1Ok.Name = "btnPlayer1Ok";
            this.btnPlayer1Ok.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1Ok.TabIndex = 6;
            this.btnPlayer1Ok.Text = "Ok";
            this.btnPlayer1Ok.UseVisualStyleBackColor = true;
            this.btnPlayer1Ok.Click += new System.EventHandler(this.btnPlayer1Ok_Click);
            // 
            // btnPlayer2Ok
            // 
            this.btnPlayer2Ok.Location = new System.Drawing.Point(368, 177);
            this.btnPlayer2Ok.Name = "btnPlayer2Ok";
            this.btnPlayer2Ok.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2Ok.TabIndex = 7;
            this.btnPlayer2Ok.Text = "Ok";
            this.btnPlayer2Ok.UseVisualStyleBackColor = true;
            this.btnPlayer2Ok.Click += new System.EventHandler(this.btnPlayer2Ok_Click);
            // 
            // btnPlayer1Edit
            // 
            this.btnPlayer1Edit.Location = new System.Drawing.Point(449, 137);
            this.btnPlayer1Edit.Name = "btnPlayer1Edit";
            this.btnPlayer1Edit.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1Edit.TabIndex = 8;
            this.btnPlayer1Edit.Text = "Edit";
            this.btnPlayer1Edit.UseVisualStyleBackColor = true;
            this.btnPlayer1Edit.Click += new System.EventHandler(this.btnPlayer1Edit_Click);
            // 
            // btnPlayer2Edit
            // 
            this.btnPlayer2Edit.Location = new System.Drawing.Point(449, 177);
            this.btnPlayer2Edit.Name = "btnPlayer2Edit";
            this.btnPlayer2Edit.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2Edit.TabIndex = 9;
            this.btnPlayer2Edit.Text = "Edit";
            this.btnPlayer2Edit.UseVisualStyleBackColor = true;
            this.btnPlayer2Edit.Click += new System.EventHandler(this.btnPlayer2Edit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(299, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(299, 257);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 404);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPlayer2Edit);
            this.Controls.Add(this.btnPlayer1Edit);
            this.Controls.Add(this.btnPlayer2Ok);
            this.Controls.Add(this.btnPlayer1Ok);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPlayer1Ok;
        private System.Windows.Forms.Button btnPlayer2Ok;
        private System.Windows.Forms.Button btnPlayer1Edit;
        private System.Windows.Forms.Button btnPlayer2Edit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
    }
}

