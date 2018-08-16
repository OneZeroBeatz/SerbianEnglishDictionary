using System;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.NextWordChoosers.Base;

namespace SerbianEnglishDictionary.Library.NextWordChoosers
{
	public class RandomNextWordChooser : NextWordChooser
	{
		public RandomNextWordChooser(IDictionary dictionary) : base(dictionary)
		{
		}

		public override string GetNextWord()
		{
			var randomWordIndex = new Random().Next() % _firstWords.Count;
			return _firstWords[randomWordIndex];
		}
	}
}
