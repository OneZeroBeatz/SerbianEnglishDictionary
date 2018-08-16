using System.Collections.Generic;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;

namespace SerbianEnglishDictionary.Library.NextWordChoosers.Base
{
	public abstract class NextWordChooser
	{
		#region Protected fields

		protected List<string> _firstWords;

		#endregion

		#region Protected constructors

		protected NextWordChooser(IDictionary dictionary)
		{
			_firstWords = dictionary.GetWords();
		}

		#endregion

		#region Abstract methods

		public abstract string GetNextWord();

		#endregion
	}
}
