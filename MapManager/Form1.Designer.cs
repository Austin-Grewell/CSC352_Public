namespace MapManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.assetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(256, 12);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(851, 765);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.mapPictureBox_DragDrop);
            this.mapPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPictureBox_DragEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // assetPictureBox
            // 
            this.assetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("assetPictureBox.Image")));
            this.assetPictureBox.Location = new System.Drawing.Point(33, 12);
            this.assetPictureBox.Name = "assetPictureBox";
            this.assetPictureBox.Size = new System.Drawing.Size(109, 165);
            this.assetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetPictureBox.TabIndex = 2;
            this.assetPictureBox.TabStop = false;
            this.assetPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.assetPictureBox_DragDrop);
            this.assetPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.assetPictureBox_DragEnter);
            this.assetPictureBox.DragOver += new System.Windows.Forms.DragEventHandler(this.assetPictureBox_DragOver);
            this.assetPictureBox.DragLeave += new System.EventHandler(this.assetPictureBox_DragLeave);
            this.assetPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.assetPictureBox_MouseDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 789);
            this.Controls.Add(this.assetPictureBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mapPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox assetPictureBox;
    }
}

