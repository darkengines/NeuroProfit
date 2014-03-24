namespace NeuroProfitUI {
	partial class PriceChart {
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			this.SuspendLayout();
			// 
			// Chart
			// 
			this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chart.Location = new System.Drawing.Point(0, 0);
			this.Chart.Name = "Chart";
			this.Chart.Size = new System.Drawing.Size(1030, 499);
			this.Chart.TabIndex = 0;
			this.Chart.Text = "chart1";
			// 
			// PriceChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Chart);
			this.Name = "PriceChart";
			this.Size = new System.Drawing.Size(1030, 499);
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
	}
}
