#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows.Forms;

namespace CellSelectionDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1233, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox2";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(355, 825);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.checkBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox2.Location = new System.Drawing.Point(15, 110);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(330, 40);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Enable Excel-Like Selection";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.checkBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(15, 50);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(330, 40);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Selection";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                        | System.Windows.Forms.AnchorStyles.Left)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Size = new System.Drawing.Size(1232, 563);
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            //
            //listBox1
            //
            this.listBox1.Dock = DockStyle.Bottom;
            this.listBox1.Size = new System.Drawing.Size(1232, 300);
            this.listBox1.Name = "panel1";
            this.listBox1.TabIndex = 1;
            //
            //panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                                   | System.Windows.Forms.AnchorStyles.Left)
                                                                                  | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Size = new System.Drawing.Size(1232, 859);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 0;
            this.panel1.Controls.Add(this.pivotGridControl1);
            this.panel1.Controls.Add(this.listBox1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cell Selection";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
    }
}