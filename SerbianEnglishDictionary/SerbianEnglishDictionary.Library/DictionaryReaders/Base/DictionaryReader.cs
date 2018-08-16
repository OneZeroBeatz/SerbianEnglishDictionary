using System.Collections.Generic;
using System.IO;

namespace SerbianEnglishDictionary.Library.DictionaryReaders.Base
{
	public abstract class DictionaryReader
	{
		private readonly string _dictionaryPath;

		protected DictionaryReader(string dictionaryPath)
		{
			_dictionaryPath = dictionaryPath;
		}
		
		public Dictionary<string, string> ReadFromSource()
		{
			var wordsPairsFromSource = new Dictionary<string,string>();
			using (var reader = new StreamReader(_dictionaryPath))
			{
				while (!reader.EndOfStream)
				{
					var pairInLine = reader.ReadLine();

					var firstWord = GetFirstWord(pairInLine);
					var secondWord = GetSecondWord(pairInLine);

					wordsPairsFromSource.Add(firstWord, secondWord);
				}
			}

			return wordsPairsFromSource;
		}

		protected abstract string GetFirstWord(string pairInLine);

		protected abstract string GetSecondWord(string pairInLine);

	}
}