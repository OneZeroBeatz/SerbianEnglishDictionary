using SerbianEnglishDictionary.Library.DictionaryReaders.Base;

namespace SerbianEnglishDictionary.Library.DictionaryReaders
{
	public class SerbianToEnglishDictionaryReader : DictionaryReader
    {
		public SerbianToEnglishDictionaryReader(string dictionaryPath) : base(dictionaryPath)
		{
		}

		protected override string GetFirstWord(string pairInLine)
		{
			return pairInLine.Split(',')[1];
		}

		protected override string GetSecondWord(string pairInLine)
		{
			return pairInLine.Split(',')[0];
		}
	}
}
