using SerbianEnglishDictionary.Initializer.CommandHandlerInitializer.TranslationTypeCommandHandlerInitializer;
using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base;

namespace SerbianEnglishDictionary.Initializers.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders
{
	public class DictionaryReaderInitializer
	{
		private static IDictionaryReader _dictionaryReader;

		public static IDictionaryReader Get()
		{
			if (_dictionaryReader == null)
				_dictionaryReader = TranslationTypeToReaderCommandHandlerInitializer.Get().GetDictionaryReader(Config.Instance.CurrentTranslationType);
			return _dictionaryReader;
		}
	}
}
