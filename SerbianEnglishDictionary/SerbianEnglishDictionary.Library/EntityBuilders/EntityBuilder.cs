using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Library.EntityBuilders
{
	public class EntityBuilder
	{
		private readonly TranslationWay _currentTranslationWay;

		public EntityBuilder(TranslationWay currentTranslationWay)
		{
			_currentTranslationWay = currentTranslationWay;
		}

		public Tuple<string, string> GetEntity(string firstWord, string translation)
		{
			if (_currentTranslationWay == TranslationWay.EnglishToSerbian)
				return new Tuple<string, string>(firstWord, translation);
			return new Tuple<string, string>(translation, firstWord);
		}
	}
}
