using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler;
using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Initializer.CommandHandlerInitializer.TranslationTypeCommandHandlerInitializer
{
	public class TranslationTypeToReaderCommandHandlerInitializer
	{
		private static TranslationTypeToReaderCommandHandler _translationTypeToReaderCommandHandler;

		public static TranslationTypeToReaderCommandHandler Get()
		{
			if (_translationTypeToReaderCommandHandler != null)
				return _translationTypeToReaderCommandHandler;

			_translationTypeToReaderCommandHandler = new TranslationTypeToReaderCommandHandler();

			_translationTypeToReaderCommandHandler.Register(TranslationType.SerbianToEnglish, new SerbianToEnglishDictionaryReader(Config.Instance.DictionaryPath));
			_translationTypeToReaderCommandHandler.Register(TranslationType.EnglishToSerbian, new EnglishToSerbianDictionaryReader(Config.Instance.DictionaryPath));


			return _translationTypeToReaderCommandHandler;
		}
	}
}
