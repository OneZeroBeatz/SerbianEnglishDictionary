using System.Collections.Generic;
using SerbianEnglishDictionary.Library.Enums;
using SerbianEnglishDictionary.Library.Maps;

namespace SerbianEnglishDictionary.Initializers.Maps
{
	public class DictionaryTypeToPathMapInitializer
	{
		private static DictionaryTypeToPathMap _map;

		public static DictionaryTypeToPathMap GetMap()
		{
			if (_map != null)
			{
				return _map;
			}

			var dictionaryTypeToPathMap = new Dictionary<DictionaryType, string>
			{
				{DictionaryType.WordsDictionary, "../../Source/WordsDictionary.csv"},
				{DictionaryType.SentencesDictionary, "../../Source/SendencesDictionary.csv"},
				{DictionaryType.PhrasesDictionary, "../../Source/PhrasesDictionary.csv"}
			};

			_map = new DictionaryTypeToPathMap(dictionaryTypeToPathMap);
			return _map;
		}
	}
}
