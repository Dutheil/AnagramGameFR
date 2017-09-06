using AnagramGameFR.ThemesWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnagramGameFR.Dependencies
{
	public class ListWords
	{
		private List<Words> _Words = new List<Words>();

		public ListWords()
		{
			Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "AnagramGameFR.ThemesWords");

			foreach(Type type in typelist)
			{
				string[] words = (string[])type.GetField("words").GetValue(null);

				foreach(string w in words)
					this._Words.Add(new Words((Themes)type.GetField("theme").GetValue(typeof(Themes)), w));
			}
		}

		//---------------------------------------------------------------------------------------------------------------

		public int GetNumberWords()
		{
			return this._Words.Count;
		}

		public int GetNumberWordsByTheme(Themes theme)
		{
			return this.GetWordsByTheme(theme).Count;
		}

		//---------------------------------------------------------------

		public List<Themes> GetThemes()
		{
			List<Themes> themes = new List<Themes>();

			foreach(Words w in this._Words)
				themes.Add(w._theme);

			return themes;
		}

		public Themes GetRandomTheme()
		{
			List<Themes> themes = this.GetThemes();

			return themes[(new Random()).Next(themes.Count)];
		}

		//---------------------------------------------------------------

		public List<string> GetWords()
		{
			List<string> words = new List<string>();

			foreach(Words w in this._Words)
				words.Add(w._word);

			return words;
		}

		public string GetRandomWord()
		{
			List<string> words = this.GetWords();

			return words[(new Random()).Next(words.Count)];
		}

		//---------------------------------------------------------------

		public List<string> GetWordsByTheme(Themes theme)
		{
			List<string> words = new List<string>();

			foreach(Words w in this._Words)
				if(w._theme == theme)
					words.Add(w._word);

			return words;
		}

		public string GetRandomWordByTheme(Themes theme)
		{
			List<string> words = this.GetWordsByTheme(theme);

			return words[(new Random()).Next(words.Count)];
		}

		//---------------------------------------------------------------

		public List<Words> GetWordsType()
		{
			return this._Words;
		}

		public Words GetRandomWordType()
		{
			return this._Words[(new Random()).Next(this._Words.Count)];
		}

		//---------------------------------------------------------------------------------------------------------------

		public Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
		{
			return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
		}
	}
}
