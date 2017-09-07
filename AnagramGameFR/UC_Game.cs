using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnagramGameFR.Dependencies;

namespace AnagramGameFR
{
	public partial class UC_Game : UserControl
	{
		private const int SOLUTION_TIME = 30;
		private const int DIVIDE_SCORE = 5;

		//-----------------------------------------------

		private readonly List<Themes> listThemes;
		private readonly int maxScore;
		private readonly int maxWords;

		//-----------------------------------------------

		private ListWords listWords;
		private string actualWord = "";
		private Themes actualTheme = (Themes)(-1);
		private int time = 0;
		private int score = 0;
		private int nWords = 0;
		private int nWordsFound = 0;
		private bool solution = false;

		//-----------------------------------------------

		public UC_Game(ListWords listWords, List<Themes> listThemes, int maxScore, int maxWords)
		{
			InitializeComponent();

			this.listWords = listWords;
			this.listThemes = listThemes;
			this.maxScore = maxScore;
			this.maxWords = maxWords;
		}

		private void UC_Game_Load(object sender, EventArgs e)
		{
			this.GenerateNewAnagram();
			this.WordInput.Select();
		}

		private void WordInput_TextChanged(object sender, EventArgs e)
		{
			if(this.solution)
			{
				this.solution = false;
				return;
			}

			if(this.WordInput.Text == this.actualWord)
			{
				this.WordInput.Enabled = false;
				this.WordInput.BackColor = Color.MediumSeaGreen;

				this.BtnNext.Enabled = true;
				this.BtnNext.Select();

				this.Timer.Stop();

				this.score += this.time > 5 ? this.time / DIVIDE_SCORE : 1;
				this.LblScoreValue.Text = this.score.ToString();

				this.LblWordsValue.Text = (++this.nWordsFound).ToString() + "/" + (++this.nWords).ToString();
			}
		}

		private void BtnNext_Click(object sender, EventArgs e)
		{
			this.GenerateNewAnagram();

			this.BtnNext.Enabled = false;

			this.WordInput.Enabled = true;
			this.WordInput.BackColor = Color.White;
			this.WordInput.Text = "";
			this.WordInput.Select();
		}

		private void BtnSolution_Click(object sender, EventArgs e)
		{
			this.solution = true;

			this.BtnSolution.Enabled = false;
			this.WordInput.Enabled = false;
			this.WordInput.BackColor = Color.MediumSeaGreen;
			this.WordInput.Text = this.actualWord;

			this.BtnNext.Enabled = true;
			this.BtnNext.Select();

			this.LblWordsValue.Text = (this.nWordsFound).ToString() + "/" + (++this.nWords).ToString();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(--this.time == 0)
			{
				this.Timer.Stop();

				this.BtnSolution.Text = "Solution";
				this.BtnSolution.Enabled = true;
			}

			else
				this.BtnSolution.Text = this.time.ToString();
		}

		private void GenerateNewAnagram()
		{
			string word;

			if(this.listThemes.Count == 1)
			{
				this.actualTheme = this.listThemes[0];
			}

			else
			{
				Themes theme;

				do theme = this.listWords.GetRandomTheme();
				while(!(this.listThemes.Contains(theme)) || theme == this.actualTheme);

				this.actualTheme = theme;
			}

			do word = this.listWords.GetRandomWordByTheme(this.actualTheme);
			while(word == this.actualWord);

			this.actualWord = word;

			this.LblThemeValue.Text = this.actualTheme.ToString() + " (" + this.listWords.GetNumberWordsByTheme(this.actualTheme) + ")";
			this.WordShuffle.Text = this.Shuffle(this.actualWord);

			this.time = SOLUTION_TIME;
			this.BtnSolution.Text = this.time.ToString();
			this.Timer.Start();
		}

		//---------------------------------------------------------------

		private string Shuffle(string str)
		{
			char[] array = str.ToCharArray();
			Random rng = new Random();
			int n = array.Length;
			while(n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				var value = array[k];
				array[k] = array[n];
				array[n] = value;
			}
			return new string(array);
		}
	}
}
