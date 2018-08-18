using System.Collections.Generic;
using System.IO;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.DictionaryReaders.Base
{
	public abstract class DictionaryReader
	{
		private readonly string _dictionaryPath;

		protected DictionaryReader(string dictionaryPath)
		{
			_dictionaryPath = dictionaryPath;
		}
		
		public Dictionary<long, WordData> ReadFromSource()
		{
			var wordsPairsFromSource = new Dictionary<long, WordData>();
			using (var reader = new StreamReader(_dictionaryPath))
			{
				long lineIndex = 0;
				while (!reader.EndOfStream)
				{
					var wordDataInLine = reader.ReadLine();
					var wordData = GetWordData(lineIndex, wordDataInLine);
					wordsPairsFromSource.Add(lineIndex++, wordData);
				}
			}

			return wordsPairsFromSource;
		}

		protected abstract string GetFirstWord(string wordDataInLine);

		protected abstract string GetSecondWord(string wordDataInLine);

		private WordData GetWordData(long lineIndex, string wordDataInLine)
		{
			var firstWord = GetFirstWord(wordDataInLine);
			var secondWord = GetSecondWord(wordDataInLine);
			var choosingsCount = GetChoosingsCount(wordDataInLine);

			return new WordData(lineIndex, firstWord, secondWord, choosingsCount);
		}

		private long GetChoosingsCount(string wordDataInLine)
		{
			return long.Parse(wordDataInLine.Split(',')[2]);
		}
		
	}
}