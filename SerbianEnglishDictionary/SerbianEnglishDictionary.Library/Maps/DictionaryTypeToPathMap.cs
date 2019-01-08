using System.Collections.Generic;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Library.Maps
{
	public class DictionaryTypeToPathMap
	{
		private readonly Dictionary<DictionaryType, string> _dictionaryTypeToPathMap;

		public DictionaryTypeToPathMap(Dictionary<DictionaryType, string> dictionaryTypeToPathMap)
		{
			_dictionaryTypeToPathMap = dictionaryTypeToPathMap;
		}
	
		public string GetDictionaryPath(DictionaryType dictionaryType)
		{
			return _dictionaryTypeToPathMap[dictionaryType];
		}
	}
}
