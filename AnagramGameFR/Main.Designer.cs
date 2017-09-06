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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.WordShuffle = new System.Windows.Forms.TextBox();
			this.WordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LblTheme = new System.Windows.Forms.Label();
			this.BtnNext = new System.Windows.Forms.Button();
			this.BtnSolution = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.LblScore = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.LblWords = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// WordShuffle
			// 
			this.WordShuffle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.WordShuffle.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WordShuffle.Location = new System.Drawing.Point(12, 49);
			this.WordShuffle.Name = "WordShuffle";
			this.WordShuffle.ReadOnly = true;
			this.WordShuffle.Size = new System.Drawing.Size(652, 64);
			this.WordShuffle.TabIndex = 0;
			this.WordShuffle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// WordInput
			// 
			this.WordInput.BackColor = System.Drawing.Color.White;
			this.WordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.WordInput.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WordInput.Location = new System.Drawing.Point(12, 119);
			this.WordInput.Name = "WordInput";
			this.WordInput.Size = new System.Drawing.Size(652, 64);
			this.WordInput.TabIndex = 1;
			this.WordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.WordInput.TextChanged += new System.EventHandler(this.WordInput_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Theme:";
			// 
			// LblTheme
			// 
			this.LblTheme.AutoSize = true;
			this.LblTheme.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTheme.ForeColor = System.Drawing.Color.Coral;
			this.LblTheme.Location = new System.Drawing.Point(87, 9);
			this.LblTheme.Name = "LblTheme";
			this.LblTheme.Size = new System.Drawing.Size(0, 24);
			this.LblTheme.TabIndex = 3;
			// 
			// BtnNext
			// 
			this.BtnNext.Enabled = false;
			this.BtnNext.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnNext.Location = new System.Drawing.Point(12, 189);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(652, 42);
			this.BtnNext.TabIndex = 4;
			this.BtnNext.Text = "NEXT";
			this.BtnNext.UseVisualStyleBackColor = true;
			this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// BtnSolution
			// 
			this.BtnSolution.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BtnSolution.Enabled = false;
			this.BtnSolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSolution.Location = new System.Drawing.Point(587, 9);
			this.BtnSolution.Name = "BtnSolution";
			this.BtnSolution.Size = new System.Drawing.Size(77, 24);
			this.BtnSolution.TabIndex = 5;
			this.BtnSolution.UseVisualStyleBackColor = false;
			this.BtnSolution.Click += new System.EventHandler(this.BtnSolution_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(269, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Score:";
			// 
			// LblScore
			// 
			this.LblScore.AutoSize = true;
			this.LblScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblScore.ForeColor = System.Drawing.Color.Coral;
			this.LblScore.Location = new System.Drawing.Point(337, 9);
			this.LblScore.Name = "LblScore";
			this.LblScore.Size = new System.Drawing.Size(22, 24);
			this.LblScore.TabIndex = 7;
			this.LblScore.Text = "0";
			// 
			// Timer
			// 
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// LblWords
			// 
			this.LblWords.AutoSize = true;
			this.LblWords.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblWords.ForeColor = System.Drawing.Color.Coral;
			this.LblWords.Location = new System.Drawing.Point(481, 9);
			this.LblWords.Name = "LblWords";
			this.LblWords.Size = new System.Drawing.Size(40, 24);
			this.LblWords.TabIndex = 9;
			this.LblWords.Text = "0/0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(404, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Words:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 243);
			this.Controls.Add(this.LblWords);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LblScore);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnSolution);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.LblTheme);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WordInput);
			this.Controls.Add(this.WordShuffle);
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

		private System.Windows.Forms.TextBox WordShuffle;
		private System.Windows.Forms.TextBox WordInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblTheme;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Button BtnSolution;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LblScore;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.Label LblWords;
		private System.Windows.Forms.Label label4;
	}
}

