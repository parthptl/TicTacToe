namespace tictactoebyparth
{
    partial class Form2
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
            this.p1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pp1 = new System.Windows.Forms.TextBox();
            this.pp2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(13, 31);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(82, 13);
            this.p1.TabIndex = 1;
            this.p1.Text = "Player 1 Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 2 Name: ";
            // 
            // pp1
            // 
            this.pp1.Location = new System.Drawing.Point(145, 31);
            this.pp1.Name = "pp1";
            this.pp1.Size = new System.Drawing.Size(175, 20);
            this.pp1.TabIndex = 3;
            this.pp1.TextChanged += new System.EventHandler(this.pp1_TextChanged);
            // 
            // pp2
            // 
            this.pp2.Location = new System.Drawing.Point(145, 73);
            this.pp2.Name = "pp2";
            this.pp2.Size = new System.Drawing.Size(175, 20);
            this.pp2.TabIndex = 4;
            this.pp2.TextChanged += new System.EventHandler(this.pp2_TextChanged);
            this.pp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pp2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Player 1 for (X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Player 2 for (O)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pp2);
            this.Controls.Add(this.pp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 190);
            this.MinimumSize = new System.Drawing.Size(353, 190);
            this.Name = "Form2";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pp1;
        private System.Windows.Forms.TextBox pp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}