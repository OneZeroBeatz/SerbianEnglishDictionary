using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.DictionaryCreators;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.Dictionaries
{
	public class FullTranslationDictionary : IDictionary
	{
		#region Protected fields

		private readonly Dictionary<long, WordData> _dictionary;

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
			var wordData = _dictionary.Values.FirstOrDefault(x => x.FirstWord.Equals(firstWord, StringComparison.OrdinalIgnoreCase));
			return wordData != null ? wordData.SecondWord : string.Empty;
		}


		public List<WordData> GetWords()
		{
			return _dictionary.Values.ToList();
		}

		#endregion
	}
}
