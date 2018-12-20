using System.Collections.Generic;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.DictionaryWriters.Base;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.NextWordChoosers.Base
{
	public abstract class NextWordChooser
	{
		#region Protected fields

		protected readonly List<WordData> WordsData;
		protected readonly DictionaryWriter DictionaryWriter;

		#endregion

		#region Protected constructors

		protected NextWordChooser(IDictionary dictionary, DictionaryWriter dictionaryWriter)
		{
			DictionaryWriter = dictionaryWriter;
			WordsData = dictionary.GetWords();
		}

		#endregion

		#region Abstract methods

		public abstract string GetNextWord();

		#endregion
	}
}
