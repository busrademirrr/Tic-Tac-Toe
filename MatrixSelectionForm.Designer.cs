namespace TicTacToe
{
    partial class MatrixSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixSelectionForm));
            this.pictureBox5x5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3x3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7x7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5x5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7x7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5x5
            // 
            this.pictureBox5x5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5x5.Image")));
            this.pictureBox5x5.Location = new System.Drawing.Point(228, 152);
            this.pictureBox5x5.Name = "pictureBox5x5";
            this.pictureBox5x5.Size = new System.Drawing.Size(156, 140);
            this.pictureBox5x5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5x5.TabIndex = 2;
            this.pictureBox5x5.TabStop = false;
            this.pictureBox5x5.Click += new System.EventHandler(this.pictureBox5x5_Click);
            // 
            // pictureBox3x3
            // 
            this.pictureBox3x3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3x3.Image")));
            this.pictureBox3x3.Location = new System.Drawing.Point(33, 152);
            this.pictureBox3x3.Name = "pictureBox3x3";
            this.pictureBox3x3.Size = new System.Drawing.Size(154, 140);
            this.pictureBox3x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3x3.TabIndex = 1;
            this.pictureBox3x3.TabStop = false;
            this.pictureBox3x3.Click += new System.EventHandler(this.pictureBox3x3_Click);
            // 
            // pictureBox7x7
            // 
            this.pictureBox7x7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7x7.Image")));
            this.pictureBox7x7.Location = new System.Drawing.Point(428, 152);
            this.pictureBox7x7.Name = "pictureBox7x7";
            this.pictureBox7x7.Size = new System.Drawing.Size(151, 140);
            this.pictureBox7x7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7x7.TabIndex = 0;
            this.pictureBox7x7.TabStop = false;
            this.pictureBox7x7.Click += new System.EventHandler(this.pictureBox7x7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(153, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHOOSE A GRİD!";
            // 
            // MatrixSelectionForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5x5);
            this.Controls.Add(this.pictureBox3x3);
            this.Controls.Add(this.pictureBox7x7);
            this.Name = "MatrixSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5x5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7x7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7x7;
        private System.Windows.Forms.PictureBox pictureBox3x3;
        private System.Windows.Forms.PictureBox pictureBox5x5;
        private System.Windows.Forms.Label label1;
    }
}