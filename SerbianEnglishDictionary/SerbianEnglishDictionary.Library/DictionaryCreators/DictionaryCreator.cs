using System.Collections.Generic;
using SerbianEnglishDictionary.Library.DictionaryReaders.Base;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.DictionaryCreators
{
	public class DictionaryCreator
	{
		private readonly DictionaryReader _reader;
		private readonly EntitiesFilter _filter;

		public DictionaryCreator(DictionaryReader reader, EntitiesFilter filter)
		{
			_reader = reader;
			_filter = filter;
		}

		public Dictionary<long, WordData> CreateDictionary()
		{
			var dictionary = _reader.ReadFromSource();
			return _filter.GetFilteredEntities(dictionary);
		}
	} 
}
