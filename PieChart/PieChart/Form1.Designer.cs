using System;
using System.Drawing;
using System.Windows.Forms;

namespace PieChart
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel chartPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnCreate = new Button();
            btnClear = new Button();
            txtYvalue = new TextBox();
            txtXvalue = new TextBox();
            txtZvalue = new TextBox();
            chartPanel = new Panel();
            lblXvalue = new Label();
            lblYvalue = new Label();
            lblZvalue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 11F);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(415, 26);
            label1.TabIndex = 0;
            label1.Text = "Please enter values for X, Y and Z ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 11F);
            label2.Location = new Point(51, 99);
            label2.Name = "label2";
            label2.Size = new Size(271, 26);
            label2.TabIndex = 1;
            label2.Text = "Click \"Create\" button";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreate.Location = new Point(81, 348);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 56);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.Location = new Point(239, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 56);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtYvalue
            // 
            txtYvalue.Font = new Font("Segoe UI", 11F);
            txtYvalue.Location = new Point(171, 214);
            txtYvalue.Name = "txtYvalue";
            txtYvalue.Size = new Size(100, 37);
            txtYvalue.TabIndex = 1;
            // 
            // txtXvalue
            // 
            txtXvalue.Font = new Font("Segoe UI", 11F);
            txtXvalue.Location = new Point(171, 162);
            txtXvalue.Name = "txtXvalue";
            txtXvalue.Size = new Size(100, 37);
            txtXvalue.TabIndex = 3;
            // 
            // txtZvalue
            // 
            txtZvalue.Font = new Font("Segoe UI", 11F);
            txtZvalue.Location = new Point(171, 273);
            txtZvalue.Name = "txtZvalue";
            txtZvalue.Size = new Size(100, 37);
            txtZvalue.TabIndex = 5;
            // 
            // chartPanel
            // 
            chartPanel.BorderStyle = BorderStyle.FixedSingle;
            chartPanel.Location = new Point(434, 44);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(527, 398);
            chartPanel.TabIndex = 6;
            // 
            // lblXvalue
            // 
            lblXvalue.Font = new Font("Stencil", 12F, FontStyle.Bold);
            lblXvalue.Location = new Point(118, 162);
            lblXvalue.Name = "lblXvalue";
            lblXvalue.Size = new Size(50, 37);
            lblXvalue.TabIndex = 0;
            lblXvalue.Text = "X:";
            // 
            // lblYvalue
            // 
            lblYvalue.Font = new Font("Stencil", 12F, FontStyle.Bold);
            lblYvalue.Location = new Point(118, 218);
            lblYvalue.Name = "lblYvalue";
            lblYvalue.Size = new Size(57, 23);
            lblYvalue.TabIndex = 2;
            lblYvalue.Text = "Y:";
            // 
            // lblZvalue
            // 
            lblZvalue.Font = new Font("Stencil", 12F, FontStyle.Bold);
            lblZvalue.Location = new Point(118, 278);
            lblZvalue.Name = "lblZvalue";
            lblZvalue.Size = new Size(50, 23);
            lblZvalue.TabIndex = 4;
            lblZvalue.Text = "Z:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 239, 204);
            ClientSize = new Size(1001, 486);
            Controls.Add(lblXvalue);
            Controls.Add(txtYvalue);
            Controls.Add(lblYvalue);
            Controls.Add(txtXvalue);
            Controls.Add(lblZvalue);
            Controls.Add(txtZvalue);
            Controls.Add(chartPanel);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pie Chart";
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        private Label label1;
        private Label label2;
        private Button btnCreate;
        private Button btnClear;
        private TextBox txtYvalue;
        private TextBox txtXvalue;
        private TextBox txtZvalue;

        #endregion

        private Label lblXvalue;
        private Label lblYvalue;
        private Label lblZvalue;
    }
}
