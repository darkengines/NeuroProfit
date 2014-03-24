namespace NeuroProfitUI {
	partial class MainForm {
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Status = new System.Windows.Forms.StatusStrip();
			this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
			this.SubLayout = new System.Windows.Forms.TableLayoutPanel();
			this.ChartTab = new System.Windows.Forms.TabControl();
			this.MainFormMenuStrip.SuspendLayout();
			this.MainLayout.SuspendLayout();
			this.SubLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainFormMenuStrip
			// 
			this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainFormMenuStrip.Name = "MainFormMenuStrip";
			this.MainFormMenuStrip.Size = new System.Drawing.Size(1240, 24);
			this.MainFormMenuStrip.TabIndex = 0;
			this.MainFormMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// Status
			// 
			this.Status.Location = new System.Drawing.Point(0, 475);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(1240, 22);
			this.Status.TabIndex = 0;
			this.Status.Text = "statusStrip1";
			// 
			// MainLayout
			// 
			this.MainLayout.ColumnCount = 1;
			this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainLayout.Controls.Add(this.Status, 0, 1);
			this.MainLayout.Controls.Add(this.SubLayout, 0, 0);
			this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLayout.Location = new System.Drawing.Point(0, 24);
			this.MainLayout.Name = "MainLayout";
			this.MainLayout.RowCount = 2;
			this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.MainLayout.Size = new System.Drawing.Size(1240, 497);
			this.MainLayout.TabIndex = 1;
			// 
			// SubLayout
			// 
			this.SubLayout.ColumnCount = 2;
			this.SubLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
			this.SubLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SubLayout.Controls.Add(this.ChartTab, 1, 0);
			this.SubLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SubLayout.Location = new System.Drawing.Point(3, 3);
			this.SubLayout.Name = "SubLayout";
			this.SubLayout.RowCount = 1;
			this.SubLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SubLayout.Size = new System.Drawing.Size(1234, 469);
			this.SubLayout.TabIndex = 1;
			// 
			// ChartTab
			// 
			this.ChartTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChartTab.Location = new System.Drawing.Point(180, 3);
			this.ChartTab.Name = "ChartTab";
			this.ChartTab.SelectedIndex = 0;
			this.ChartTab.Size = new System.Drawing.Size(1051, 463);
			this.ChartTab.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 521);
			this.Controls.Add(this.MainLayout);
			this.Controls.Add(this.MainFormMenuStrip);
			this.MainMenuStrip = this.MainFormMenuStrip;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.MainFormMenuStrip.ResumeLayout(false);
			this.MainFormMenuStrip.PerformLayout();
			this.MainLayout.ResumeLayout(false);
			this.MainLayout.PerformLayout();
			this.SubLayout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainFormMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.StatusStrip Status;
		private System.Windows.Forms.TableLayoutPanel MainLayout;
		private System.Windows.Forms.TableLayoutPanel SubLayout;
		private System.Windows.Forms.TabControl ChartTab;


	}
}

