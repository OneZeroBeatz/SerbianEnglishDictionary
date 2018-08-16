using SerbianEnglishDictionary.Library.DictionaryReaders.Base;

namespace SerbianEnglishDictionary.Library.DictionaryReaders
{
	public class EnglishToSerbianDictionaryReader : DictionaryReader
	{
		public EnglishToSerbianDictionaryReader(string dictionaryPath) : base(dictionaryPath)
		{
		}

		protected override string GetFirstWord(string pairInLine)
		{
			return pairInLine.Split(',')[0];
		}

		protected override string GetSecondWord(string pairInLine)
		{
			return pairInLine.Split(',')[1];
		}
	}
}
