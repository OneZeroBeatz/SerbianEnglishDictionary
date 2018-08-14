using SerbianEnglishDictionary.Library.IntermediateModel;
using System.Collections.Generic;
using System.IO;

namespace SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base
{
	public abstract class BaseDictionaryReader : IDictionaryReader
	{
		private string _dictionaryPath;

		protected BaseDictionaryReader(string dictionaryPath)
		{
			_dictionaryPath = dictionaryPath;
		}

		public List<WordsPair> ReadFromSource()
		{
			var wordsPairsFromSource = new List<WordsPair>();
			using (var reader = new StreamReader(_dictionaryPath))
			{
				while (!reader.EndOfStream)
				{
					var pairInLine = reader.ReadLine();
					var wordsPair = new WordsPair
					{
						FirstWord = GetFirstWord(pairInLine),
						SecondWord = GetSecondWord(pairInLine)
					};
					wordsPairsFromSource.Add(wordsPair);
				}
			}

			return wordsPairsFromSource;
		}

		protected abstract string GetFirstWord(string pairInLine);

		protected abstract string GetSecondWord(string pairInLine);
	}
}