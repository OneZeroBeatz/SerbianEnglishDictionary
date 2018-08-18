using SerbianEnglishDictionary.Initializers.DictionaryWriters;
using SerbianEnglishDictionary.Initializers.Translators;
using SerbianEnglishDictionary.Library.NextWordChoosers;
using SerbianEnglishDictionary.Library.NextWordChoosers.Base;

namespace SerbianEnglishDictionary.Initializers.NextWordChoosers
{
	public class NextWordChooserInitializer
	{
		private static NextWordChooser _nextWordChooser;

		public static NextWordChooser GetChooser()
		{
			if (_nextWordChooser == null)
				_nextWordChooser = new RandomNextWordChooser(DictionaryInitializer.GetDictionary(), DictionaryWriterInitializer.GetWriter());
			return _nextWordChooser;
		}
	}
}
