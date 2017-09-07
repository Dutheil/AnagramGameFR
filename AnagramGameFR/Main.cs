using AnagramGameFR.Dependencies;
using AnagramGameFR.ThemesWords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnagramGameFR
{
	public partial class Main : Form
	{
		private ListWords listWords = new ListWords();
		private List<Themes> listThemes = new List<Themes>();
		private List<CheckBox> listCheckBox = new List<CheckBox>();

		private bool start = false;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			List<Themes> themes = this.listWords.GetThemes();

			foreach(Themes theme in themes)
				this.AddNewCheckBox(theme.ToString());
		}

		private void Cb_CheckedChanged(object sender, EventArgs e)
		{
			if(this.start)
				return;

			foreach(CheckBox cb in this.listCheckBox)
			{
				int i = this.listCheckBox.IndexOf(cb);

				if(cb.Checked)
				{
					if(!(this.listThemes.Contains(this.listWords.GetTheme(i))))
						this.listThemes.Add(this.listWords.GetTheme(i));
				}

				else
				{
					if(this.listThemes.Contains(this.listWords.GetTheme(i)))
						this.listThemes.Remove(this.listWords.GetTheme(i));
				}
			}

			this.BtnStart.Enabled = this.listThemes.Count > 0;
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			if(this.start)
				return;

			this.start = true;
			this.Controls.Add(new UC_Game(this.listWords, this.listThemes, 0, 0));

			foreach(CheckBox cb in this.listCheckBox)
			{
				cb.Visible = false;
				cb.Checked = false;
			}

			this.LblThemes.Visible = false;
			this.BtnStart.Visible = false;

			this.listThemes.Clear();
		}

		//------------------------------------------------

		int x = 117;
		int y = 18;

		private void AddNewCheckBox(string text)
		{
			CheckBox cb = this.cbThemeExample.Clone();

			cb.Name = "cbTheme" + this.listCheckBox.Count;
			cb.Location = new Point(this.x, this.y);
			cb.Text = text;
			cb.Visible = true;
			cb.CheckedChanged += Cb_CheckedChanged;

			this.listCheckBox.Add(cb);

			if(this.listCheckBox.Count == 8)
			{
				this.x += 140;
				this.y = 18;
			}

			else
			{
				y += 26;
			}			
		}

		
	}
}
