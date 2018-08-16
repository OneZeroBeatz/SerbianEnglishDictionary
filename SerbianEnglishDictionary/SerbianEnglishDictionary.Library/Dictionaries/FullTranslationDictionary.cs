using System.Collections.Generic;
using System.Linq;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.DictionaryCreators;

namespace SerbianEnglishDictionary.Library.Dictionaries
{
	public class FullTranslationDictionary : IDictionary
	{
		#region Protected fields

		private readonly Dictionary<string, string> _dictionary;

		#endregion

		#region Protected constructors

		public FullTranslationDictionary(DictionaryCreator dictionaryCreator)
		{
			_dictionary = dictionaryCreator.CreateDictionary();
		}

		#endregion

		#region Public methods

		public string GetTranslation(string firstWord)
		{
			string translation;
			return _dictionary.TryGetValue(firstWord, out translation) ? translation : "";
		}

		public List<string> GetWords()
		{
			return _dictionary.Keys.ToList();
		}

		#endregion
	}
}
