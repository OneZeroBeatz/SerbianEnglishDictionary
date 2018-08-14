using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base;

namespace SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders
{
	public class SerbianToEnglishDictionaryReader : BaseDictionaryReader
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
