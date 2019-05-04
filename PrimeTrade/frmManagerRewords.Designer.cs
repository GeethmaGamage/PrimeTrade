﻿namespace PrimeTrade
{
    partial class frmManagerRewords
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
            this.components = new System.ComponentModel.Container();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPromotion = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splashPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(1141, 63);
            this.splashPanel1.Controls.Add(this.label1);
            this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.LeftTop;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(-170, 5);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(1141, 63);
            this.splashPanel1.TabIndex = 139;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 32);
            this.label1.TabIndex = 137;
            this.label1.Text = "PRIME TRADE : REWORDS FOR THE SELECTED PROMOTION";
            // 
            // cmbPromotion
            // 
            this.cmbPromotion.FormattingEnabled = true;
            this.cmbPromotion.ItemHeight = 23;
            this.cmbPromotion.Location = new System.Drawing.Point(275, 85);
            this.cmbPromotion.Name = "cmbPromotion";
            this.cmbPromotion.Size = new System.Drawing.Size(310, 29);
            this.cmbPromotion.TabIndex = 142;
            this.cmbPromotion.UseSelectable = true;
            this.cmbPromotion.SelectedIndexChanged += new System.EventHandler(this.cmbPromotion_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(92, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 283);
            this.listView1.TabIndex = 141;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(144, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 140;
            this.materialLabel1.Text = "Promotion ID";
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(73, 41);
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Bump;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv2.Image = global::PrimeTrade.Properties.Resources.error;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(694, 373);
            this.buttonAdv2.MetroColor = System.Drawing.Color.Aqua;
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.OverrideFormManagedColor = true;
            this.buttonAdv2.PushButton = true;
            this.buttonAdv2.Size = new System.Drawing.Size(73, 41);
            this.buttonAdv2.TabIndex = 143;
            this.buttonAdv2.Text = "Exit";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdv2.UseVisualStyle = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Distributer Name";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "User ID";
            this.columnHeader5.Width = 150;
            // 
            // frmManagerRewords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.cmbPromotion);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.splashPanel1);
            this.Name = "frmManagerRewords";
            this.Text = "frmManagerRewords";
            this.splashPanel1.ResumeLayout(false);
            this.splashPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbPromotion;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}