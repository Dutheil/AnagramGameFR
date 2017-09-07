namespace AnagramGameFR
{
	partial class Main
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.LblThemes = new System.Windows.Forms.Label();
			this.cbThemeExample = new System.Windows.Forms.CheckBox();
			this.BtnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblThemes
			// 
			this.LblThemes.AutoSize = true;
			this.LblThemes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblThemes.Location = new System.Drawing.Point(13, 13);
			this.LblThemes.Name = "LblThemes";
			this.LblThemes.Size = new System.Drawing.Size(98, 24);
			this.LblThemes.TabIndex = 1;
			this.LblThemes.Text = "Themes:";
			// 
			// cbThemeExample
			// 
			this.cbThemeExample.AutoSize = true;
			this.cbThemeExample.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbThemeExample.Location = new System.Drawing.Point(117, 18);
			this.cbThemeExample.Name = "cbThemeExample";
			this.cbThemeExample.Size = new System.Drawing.Size(88, 20);
			this.cbThemeExample.TabIndex = 0;
			this.cbThemeExample.Text = "EXAMPLE";
			this.cbThemeExample.UseVisualStyleBackColor = true;
			this.cbThemeExample.Visible = false;
			// 
			// BtnStart
			// 
			this.BtnStart.BackColor = System.Drawing.Color.DarkGreen;
			this.BtnStart.Enabled = false;
			this.BtnStart.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnStart.ForeColor = System.Drawing.Color.White;
			this.BtnStart.Location = new System.Drawing.Point(17, 41);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(88, 179);
			this.BtnStart.TabIndex = 2;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = false;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 243);
			this.Controls.Add(this.BtnStart);
			this.Controls.Add(this.LblThemes);
			this.Controls.Add(this.cbThemeExample);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Anagram Game: French";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblThemes;
		private System.Windows.Forms.CheckBox cbThemeExample;
		private System.Windows.Forms.Button BtnStart;
	}
}

