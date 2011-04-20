
namespace OMGPonies
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.учетСлужащихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьСведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьСведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рассчитатьИтоговуюЗарплатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьИтоговуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.addServant = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteServant = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnCalculate = new System.Windows.Forms.ToolStripButton();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.учетСлужащихToolStripMenuItem,
									this.сервисToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(611, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// учетСлужащихToolStripMenuItem
			// 
			this.учетСлужащихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.добавитьСведенияToolStripMenuItem,
									this.изменитьСведенияToolStripMenuItem});
			this.учетСлужащихToolStripMenuItem.Name = "учетСлужащихToolStripMenuItem";
			this.учетСлужащихToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.учетСлужащихToolStripMenuItem.Text = "Учет служащих";
			// 
			// добавитьСведенияToolStripMenuItem
			// 
			this.добавитьСведенияToolStripMenuItem.Name = "добавитьСведенияToolStripMenuItem";
			this.добавитьСведенияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.добавитьСведенияToolStripMenuItem.Text = "Добавить сведения";
			// 
			// изменитьСведенияToolStripMenuItem
			// 
			this.изменитьСведенияToolStripMenuItem.Name = "изменитьСведенияToolStripMenuItem";
			this.изменитьСведенияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.изменитьСведенияToolStripMenuItem.Text = "Изменить сведения";
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.рассчитатьИтоговуюЗарплатуToolStripMenuItem,
									this.создатьИтоговуюТаблицуToolStripMenuItem});
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// рассчитатьИтоговуюЗарплатуToolStripMenuItem
			// 
			this.рассчитатьИтоговуюЗарплатуToolStripMenuItem.Name = "рассчитатьИтоговуюЗарплатуToolStripMenuItem";
			this.рассчитатьИтоговуюЗарплатуToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.рассчитатьИтоговуюЗарплатуToolStripMenuItem.Text = "Рассчитать итоговую зарплату";
			// 
			// создатьИтоговуюТаблицуToolStripMenuItem
			// 
			this.создатьИтоговуюТаблицуToolStripMenuItem.Name = "создатьИтоговуюТаблицуToolStripMenuItem";
			this.создатьИтоговуюТаблицуToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.создатьИтоговуюТаблицуToolStripMenuItem.Text = "Создать итоговую таблицу";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addServant,
									this.toolStripSeparator1,
									this.deleteServant,
									this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(611, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// addServant
			// 
			this.addServant.AutoToolTip = false;
			this.addServant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.addServant.Image = ((System.Drawing.Image)(resources.GetObject("addServant.Image")));
			this.addServant.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addServant.Name = "addServant";
			this.addServant.Size = new System.Drawing.Size(129, 22);
			this.addServant.Text = "Добавить служащего";
			this.addServant.Click += new System.EventHandler(this.ToolStripButton1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// deleteServant
			// 
			this.deleteServant.AutoToolTip = false;
			this.deleteServant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.deleteServant.Image = ((System.Drawing.Image)(resources.GetObject("deleteServant.Image")));
			this.deleteServant.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteServant.Name = "deleteServant";
			this.deleteServant.Size = new System.Drawing.Size(121, 22);
			this.deleteServant.Text = "Удалить служащего";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnCalculate,
									this.btnExport});
			this.toolStrip2.Location = new System.Drawing.Point(0, 49);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(611, 25);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnCalculate
			// 
			this.btnCalculate.AutoToolTip = false;
			this.btnCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Image")));
			this.btnCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(128, 22);
			this.btnCalculate.Text = "Зарплата сотрудника";
			// 
			// btnExport
			// 
			this.btnExport.AutoToolTip = false;
			this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(87, 22);
			this.btnExport.Text = "Создать отчет";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 309);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "OMGPonies";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripButton btnCalculate;
		private System.Windows.Forms.ToolStripButton addServant;
		private System.Windows.Forms.ToolStripButton deleteServant;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem создатьИтоговуюТаблицуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem рассчитатьИтоговуюЗарплатуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem изменитьСведенияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьСведенияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem учетСлужащихToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
