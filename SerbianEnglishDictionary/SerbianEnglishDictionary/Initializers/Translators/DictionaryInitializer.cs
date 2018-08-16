using SerbianEnglishDictionary.Initializers.DictionaryCreators;
using SerbianEnglishDictionary.Library.Dictionaries;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;

namespace SerbianEnglishDictionary.Initializers.Translators
{
	public class DictionaryInitializer
	{
		private static IDictionary _dictionary;

		public static IDictionary GetDictionary()
		{
			if (_dictionary == null)
				_dictionary = new FullTranslationDictionary(DictionaryCreatorInitializer.GetCreator());
			return _dictionary;
		}
	}
}
