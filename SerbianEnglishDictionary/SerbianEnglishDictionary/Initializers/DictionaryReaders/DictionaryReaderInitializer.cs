using SerbianEnglishDictionary.Initializers.CommandHandlers.TranslationWayToReaderCommandHandlers;
using SerbianEnglishDictionary.Library.DictionaryReaders.Base;

namespace SerbianEnglishDictionary.Initializers.DictionaryReaders
{
	public class DictionaryReaderInitializer
	{
		private static DictionaryReader _dictionaryReader;

		public static DictionaryReader Get()
		{
			if (_dictionaryReader == null)
			{
				var readerCommandHandler = TranslationWayToReaderCommandHandlerInitializer.Get();
				_dictionaryReader = readerCommandHandler.GetDictionaryReader(Config.Instance.TranslationWay);
			}
			return _dictionaryReader;
		}
	}
}
