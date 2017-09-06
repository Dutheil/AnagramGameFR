using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramGameFR.Dependencies
{
	public class Words
	{
		public Themes _theme { get; internal set; }
		public string _word { get; internal set; }

		public Words(Themes theme, string word)
		{
			this._theme = theme;
			this._word = word;
		}
	}
}
