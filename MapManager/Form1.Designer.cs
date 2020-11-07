﻿namespace MapManager
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
            this.assetsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.debugStatus = new System.Windows.Forms.Label();
            this.mousePosScaled = new System.Windows.Forms.Label();
            this.mousePosActual = new System.Windows.Forms.Label();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.layersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.layerPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.layerSelectionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).BeginInit();
            this.assetsLayoutPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.primaryVerticalLayout.SuspendLayout();
            this.layersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerPreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(235, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(790, 746);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            this.mapPictureBox.Resize += new System.EventHandler(this.mapPictureBox_Resize);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 508);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // assetPictureBox
            // 
            this.assetPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("assetPictureBox.Image")));
            this.assetPictureBox.Location = new System.Drawing.Point(3, 3);
            this.assetPictureBox.Name = "assetPictureBox";
            this.assetPictureBox.Size = new System.Drawing.Size(220, 499);
            this.assetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetPictureBox.TabIndex = 2;
            this.assetPictureBox.TabStop = false;
            this.assetPictureBox.Click += new System.EventHandler(this.assetPictureBox_Click);
            // 
            // assetsLayoutPanel
            // 
            this.assetsLayoutPanel.AutoSize = true;
            this.assetsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assetsLayoutPanel.ColumnCount = 1;
            this.assetsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.assetsLayoutPanel.Controls.Add(this.comboBox1, 0, 1);
            this.assetsLayoutPanel.Controls.Add(this.assetPictureBox, 0, 0);
            this.assetsLayoutPanel.Controls.Add(this.labelPanel, 0, 2);
            this.assetsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.assetsLayoutPanel.Name = "assetsLayoutPanel";
            this.assetsLayoutPanel.RowCount = 3;
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.assetsLayoutPanel.Size = new System.Drawing.Size(226, 746);
            this.assetsLayoutPanel.TabIndex = 4;
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.debugStatus);
            this.labelPanel.Controls.Add(this.mousePosScaled);
            this.labelPanel.Controls.Add(this.mousePosActual);
            this.labelPanel.Location = new System.Drawing.Point(3, 535);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(220, 208);
            this.labelPanel.TabIndex = 3;
            // 
            // debugStatus
            // 
            this.debugStatus.AutoSize = true;
            this.debugStatus.Location = new System.Drawing.Point(3, 26);
            this.debugStatus.Name = "debugStatus";
            this.debugStatus.Size = new System.Drawing.Size(77, 13);
            this.debugStatus.TabIndex = 2;
            this.debugStatus.Text = "Is in Edit Mode";
            // 
            // mousePosScaled
            // 
            this.mousePosScaled.AutoSize = true;
            this.mousePosScaled.Location = new System.Drawing.Point(3, 13);
            this.mousePosScaled.Name = "mousePosScaled";
            this.mousePosScaled.Size = new System.Drawing.Size(121, 13);
            this.mousePosScaled.TabIndex = 1;
            this.mousePosScaled.Text = "mousePosScaled - X: Y:";
            // 
            // mousePosActual
            // 
            this.mousePosActual.AutoSize = true;
            this.mousePosActual.Location = new System.Drawing.Point(3, 0);
            this.mousePosActual.Name = "mousePosActual";
            this.mousePosActual.Size = new System.Drawing.Size(118, 13);
            this.mousePosActual.TabIndex = 0;
            this.mousePosActual.Text = "mousePosActual - X: Y:";
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 3;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.primaryVerticalLayout.Controls.Add(this.assetsLayoutPanel, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Controls.Add(this.layersTableLayoutPanel, 2, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.Size = new System.Drawing.Size(1244, 752);
            this.primaryVerticalLayout.TabIndex = 5;
            // 
            // layersTableLayoutPanel
            // 
            this.layersTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layersTableLayoutPanel.ColumnCount = 1;
            this.layersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            this.layersTableLayoutPanel.Controls.Add(this.layerPreviewPictureBox, 0, 0);
            this.layersTableLayoutPanel.Controls.Add(this.layerSelectionComboBox, 0, 1);
            this.layersTableLayoutPanel.Location = new System.Drawing.Point(1031, 3);
            this.layersTableLayoutPanel.Name = "layersTableLayoutPanel";
            this.layersTableLayoutPanel.RowCount = 2;
            this.layersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07239F));
            this.layersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.92761F));
            this.layersTableLayoutPanel.Size = new System.Drawing.Size(210, 746);
            this.layersTableLayoutPanel.TabIndex = 5;
            // 
            // layerPreviewPictureBox
            // 
            this.layerPreviewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.layerPreviewPictureBox.Name = "layerPreviewPictureBox";
            this.layerPreviewPictureBox.Size = new System.Drawing.Size(204, 375);
            this.layerPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.layerPreviewPictureBox.TabIndex = 0;
            this.layerPreviewPictureBox.TabStop = false;
            // 
            // layerSelectionComboBox
            // 
            this.layerSelectionComboBox.FormattingEnabled = true;
            this.layerSelectionComboBox.Location = new System.Drawing.Point(3, 384);
            this.layerSelectionComboBox.Name = "layerSelectionComboBox";
            this.layerSelectionComboBox.Size = new System.Drawing.Size(204, 21);
            this.layerSelectionComboBox.TabIndex = 1;
            this.layerSelectionComboBox.SelectedValueChanged += new System.EventHandler(this.layerSelectionComboBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1244, 752);
            this.Controls.Add(this.primaryVerticalLayout);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).EndInit();
            this.assetsLayoutPanel.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.layersTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerPreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox assetPictureBox;
        private System.Windows.Forms.TableLayoutPanel assetsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Label mousePosScaled;
        private System.Windows.Forms.Label mousePosActual;
        private System.Windows.Forms.TableLayoutPanel layersTableLayoutPanel;
        private System.Windows.Forms.PictureBox layerPreviewPictureBox;
        private System.Windows.Forms.ComboBox layerSelectionComboBox;
        private System.Windows.Forms.Label debugStatus;
    }
}

