﻿namespace Solipstry_Character_Creator
{
	partial class CustomSpellForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.lblSpellName = new System.Windows.Forms.Label();
			this.txtSpellName = new System.Windows.Forms.TextBox();
			this.lblCost = new System.Windows.Forms.Label();
			this.cmbSchool = new System.Windows.Forms.ComboBox();
			this.lblSchool = new System.Windows.Forms.Label();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(122, 91);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(203, 91);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lblSpellName
			// 
			this.lblSpellName.AutoSize = true;
			this.lblSpellName.Location = new System.Drawing.Point(12, 9);
			this.lblSpellName.Name = "lblSpellName";
			this.lblSpellName.Size = new System.Drawing.Size(38, 13);
			this.lblSpellName.TabIndex = 2;
			this.lblSpellName.Text = "Name:";
			// 
			// txtSpellName
			// 
			this.txtSpellName.Location = new System.Drawing.Point(12, 25);
			this.txtSpellName.Name = "txtSpellName";
			this.txtSpellName.Size = new System.Drawing.Size(266, 20);
			this.txtSpellName.TabIndex = 0;
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Location = new System.Drawing.Point(15, 48);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(28, 13);
			this.lblCost.TabIndex = 4;
			this.lblCost.Text = "Cost";
			// 
			// cmbSchool
			// 
			this.cmbSchool.FormattingEnabled = true;
			this.cmbSchool.Items.AddRange(new object[] {
            "Alteration",
            "Conjuration",
            "Destruction",
            "Restoration"});
			this.cmbSchool.Location = new System.Drawing.Point(110, 64);
			this.cmbSchool.Name = "cmbSchool";
			this.cmbSchool.Size = new System.Drawing.Size(168, 21);
			this.cmbSchool.TabIndex = 2;
			// 
			// lblSchool
			// 
			this.lblSchool.AutoSize = true;
			this.lblSchool.Location = new System.Drawing.Point(107, 48);
			this.lblSchool.Name = "lblSchool";
			this.lblSchool.Size = new System.Drawing.Size(43, 13);
			this.lblSchool.TabIndex = 6;
			this.lblSchool.Text = "School:";
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(12, 64);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(92, 20);
			this.txtCost.TabIndex = 1;
			// 
			// CustomSpellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 126);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.lblSchool);
			this.Controls.Add(this.cmbSchool);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.txtSpellName);
			this.Controls.Add(this.lblSpellName);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CustomSpellForm";
			this.Text = "Create Custom Skill";
			this.Load += new System.EventHandler(this.CustomSpellForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lblSpellName;
		private System.Windows.Forms.TextBox txtSpellName;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.ComboBox cmbSchool;
		private System.Windows.Forms.Label lblSchool;
		private System.Windows.Forms.TextBox txtCost;
	}
}