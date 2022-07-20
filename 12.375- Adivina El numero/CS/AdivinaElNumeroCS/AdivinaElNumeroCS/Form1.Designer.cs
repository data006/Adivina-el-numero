namespace AdivinaElNumeroCS
{
	partial class frmAdivinaElNumeroCS
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// tmrPrincipal
			// 
			this.tmrPrincipal.Enabled = true;
			this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
			// 
			// frmAdivinaElNumeroCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "frmAdivinaElNumeroCS";
			this.Text = "Adivina El Numero";
			this.Load += new System.EventHandler(this.frmAdivinaElNumeroCS_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrPrincipal;
	}
}

