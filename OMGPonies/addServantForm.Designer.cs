
namespace OMGPonies
{
	partial class addServantForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbNameServant = new System.Windows.Forms.TextBox();
			this.cbWorkshop = new System.Windows.Forms.ComboBox();
			this.tbPaymentRate = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbPaymentRate);
			this.panel1.Controls.Add(this.cbWorkshop);
			this.panel1.Controls.Add(this.tbNameServant);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(503, 144);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 199);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(503, 0);
			this.panel2.TabIndex = 1;
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(131, 168);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(75, 23);
			this.btnAccept.TabIndex = 2;
			this.btnAccept.Text = "Добавить";
			this.btnAccept.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(278, 168);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(46, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Цех";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(46, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Зарплата";
			// 
			// tbNameServant
			// 
			this.tbNameServant.Location = new System.Drawing.Point(141, 27);
			this.tbNameServant.Name = "tbNameServant";
			this.tbNameServant.Size = new System.Drawing.Size(100, 20);
			this.tbNameServant.TabIndex = 3;
			// 
			// cbWorkshop
			// 
			this.cbWorkshop.FormattingEnabled = true;
			this.cbWorkshop.Location = new System.Drawing.Point(141, 65);
			this.cbWorkshop.Name = "cbWorkshop";
			this.cbWorkshop.Size = new System.Drawing.Size(121, 21);
			this.cbWorkshop.TabIndex = 4;
			// 
			// tbPaymentRate
			// 
			this.tbPaymentRate.Location = new System.Drawing.Point(141, 112);
			this.tbPaymentRate.Name = "tbPaymentRate";
			this.tbPaymentRate.Size = new System.Drawing.Size(100, 20);
			this.tbPaymentRate.TabIndex = 5;
			this.tbPaymentRate.TextChanged += new System.EventHandler(this.TbPaymentRate_TextChanged);
			// 
			// addServantForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 199);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "addServantForm";
			this.Text = "Новый сотрудник";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cbWorkshop;
		private System.Windows.Forms.TextBox tbPaymentRate;
		private System.Windows.Forms.TextBox tbNameServant;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}
