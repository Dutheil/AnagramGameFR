namespace AnagramGameFR
{
	partial class UC_Game
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.LblWordsValue = new System.Windows.Forms.Label();
			this.LblWords = new System.Windows.Forms.Label();
			this.LblScoreValue = new System.Windows.Forms.Label();
			this.LblScore = new System.Windows.Forms.Label();
			this.BtnSolution = new System.Windows.Forms.Button();
			this.BtnNext = new System.Windows.Forms.Button();
			this.LblThemeValue = new System.Windows.Forms.Label();
			this.LblTheme = new System.Windows.Forms.Label();
			this.WordInput = new System.Windows.Forms.TextBox();
			this.WordShuffle = new System.Windows.Forms.TextBox();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// LblWordsValue
			// 
			this.LblWordsValue.AutoSize = true;
			this.LblWordsValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblWordsValue.ForeColor = System.Drawing.Color.Coral;
			this.LblWordsValue.Location = new System.Drawing.Point(481, 11);
			this.LblWordsValue.Name = "LblWordsValue";
			this.LblWordsValue.Size = new System.Drawing.Size(40, 24);
			this.LblWordsValue.TabIndex = 19;
			this.LblWordsValue.Text = "0/0";
			// 
			// LblWords
			// 
			this.LblWords.AutoSize = true;
			this.LblWords.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblWords.Location = new System.Drawing.Point(404, 11);
			this.LblWords.Name = "LblWords";
			this.LblWords.Size = new System.Drawing.Size(84, 24);
			this.LblWords.TabIndex = 18;
			this.LblWords.Text = "Words:";
			// 
			// LblScoreValue
			// 
			this.LblScoreValue.AutoSize = true;
			this.LblScoreValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblScoreValue.ForeColor = System.Drawing.Color.Coral;
			this.LblScoreValue.Location = new System.Drawing.Point(337, 11);
			this.LblScoreValue.Name = "LblScoreValue";
			this.LblScoreValue.Size = new System.Drawing.Size(22, 24);
			this.LblScoreValue.TabIndex = 17;
			this.LblScoreValue.Text = "0";
			// 
			// LblScore
			// 
			this.LblScore.AutoSize = true;
			this.LblScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblScore.Location = new System.Drawing.Point(269, 11);
			this.LblScore.Name = "LblScore";
			this.LblScore.Size = new System.Drawing.Size(76, 24);
			this.LblScore.TabIndex = 16;
			this.LblScore.Text = "Score:";
			// 
			// BtnSolution
			// 
			this.BtnSolution.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BtnSolution.Enabled = false;
			this.BtnSolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSolution.Location = new System.Drawing.Point(587, 11);
			this.BtnSolution.Name = "BtnSolution";
			this.BtnSolution.Size = new System.Drawing.Size(77, 24);
			this.BtnSolution.TabIndex = 15;
			this.BtnSolution.UseVisualStyleBackColor = false;
			this.BtnSolution.Click += new System.EventHandler(this.BtnSolution_Click);
			// 
			// BtnNext
			// 
			this.BtnNext.Enabled = false;
			this.BtnNext.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnNext.Location = new System.Drawing.Point(12, 191);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(652, 42);
			this.BtnNext.TabIndex = 14;
			this.BtnNext.Text = "NEXT";
			this.BtnNext.UseVisualStyleBackColor = true;
			this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// LblThemeValue
			// 
			this.LblThemeValue.AutoSize = true;
			this.LblThemeValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblThemeValue.ForeColor = System.Drawing.Color.Coral;
			this.LblThemeValue.Location = new System.Drawing.Point(87, 11);
			this.LblThemeValue.Name = "LblThemeValue";
			this.LblThemeValue.Size = new System.Drawing.Size(0, 24);
			this.LblThemeValue.TabIndex = 13;
			// 
			// LblTheme
			// 
			this.LblTheme.AutoSize = true;
			this.LblTheme.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTheme.Location = new System.Drawing.Point(7, 11);
			this.LblTheme.Name = "LblTheme";
			this.LblTheme.Size = new System.Drawing.Size(86, 24);
			this.LblTheme.TabIndex = 12;
			this.LblTheme.Text = "Theme:";
			// 
			// WordInput
			// 
			this.WordInput.BackColor = System.Drawing.Color.White;
			this.WordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.WordInput.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WordInput.Location = new System.Drawing.Point(12, 121);
			this.WordInput.Name = "WordInput";
			this.WordInput.Size = new System.Drawing.Size(652, 64);
			this.WordInput.TabIndex = 11;
			this.WordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.WordInput.TextChanged += new System.EventHandler(this.WordInput_TextChanged);
			// 
			// WordShuffle
			// 
			this.WordShuffle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.WordShuffle.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WordShuffle.Location = new System.Drawing.Point(12, 51);
			this.WordShuffle.Name = "WordShuffle";
			this.WordShuffle.ReadOnly = true;
			this.WordShuffle.Size = new System.Drawing.Size(652, 64);
			this.WordShuffle.TabIndex = 10;
			this.WordShuffle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Timer
			// 
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// UC_Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LblWordsValue);
			this.Controls.Add(this.LblWords);
			this.Controls.Add(this.LblScoreValue);
			this.Controls.Add(this.LblScore);
			this.Controls.Add(this.BtnSolution);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.LblThemeValue);
			this.Controls.Add(this.LblTheme);
			this.Controls.Add(this.WordInput);
			this.Controls.Add(this.WordShuffle);
			this.Name = "UC_Game";
			this.Size = new System.Drawing.Size(675, 241);
			this.Load += new System.EventHandler(this.UC_Game_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblWordsValue;
		private System.Windows.Forms.Label LblWords;
		private System.Windows.Forms.Label LblScoreValue;
		private System.Windows.Forms.Label LblScore;
		private System.Windows.Forms.Button BtnSolution;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Label LblThemeValue;
		private System.Windows.Forms.Label LblTheme;
		private System.Windows.Forms.TextBox WordInput;
		private System.Windows.Forms.TextBox WordShuffle;
		private System.Windows.Forms.Timer Timer;
	}
}
