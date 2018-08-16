using System.Collections.Generic;

namespace SerbianEnglishDictionary.Library.Dictionaries.Interface
{
	public interface IDictionary
	{
		string GetTranslation(string firstWord);

		List<string> GetWords();
	}
}
