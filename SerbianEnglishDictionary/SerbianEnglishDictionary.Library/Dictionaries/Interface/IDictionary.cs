using System.Collections.Generic;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.Dictionaries.Interface
{
	public interface IDictionary
	{
		string GetTranslation(string firstWord);

		List<WordData> GetWords();
	}
}
