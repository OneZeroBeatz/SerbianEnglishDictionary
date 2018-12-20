using System;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.DictionaryWriters.Base;
using SerbianEnglishDictionary.Library.NextWordChoosers.Base;

namespace SerbianEnglishDictionary.Library.NextWordChoosers
{
	public class RandomNextWordChooser : NextWordChooser
	{
		public RandomNextWordChooser(IDictionary dictionary, DictionaryWriter dictionaryWriter)
			: base(dictionary, dictionaryWriter)
		{
		}

		public override string GetNextWord()
		{
			var randomWordIndex = new Random().Next() % WordsData.Count;
			DictionaryWriter.IncrementEntityChoosingTimesCount(WordsData[randomWordIndex].Index);
			return WordsData[randomWordIndex].FirstWord;
		}
	}
}
