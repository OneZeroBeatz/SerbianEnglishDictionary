using SerbianEnglishDictionary.Initializers.DictionaryReaders;
using SerbianEnglishDictionary.Initializers.EntitiesFilters;
using SerbianEnglishDictionary.Library.DictionaryCreators;

namespace SerbianEnglishDictionary.Initializers.DictionaryCreators
{
	public class DictionaryCreatorInitializer
	{
		private static DictionaryCreator _dictionaryCreator;

		public static DictionaryCreator GetCreator()
		{
			if (_dictionaryCreator == null)
				_dictionaryCreator = new DictionaryCreator(DictionaryReaderInitializer.Get(), EntitiesFilterInitializer.GetFilter());
			return _dictionaryCreator;
		}
	}
}
