using SerbianEnglishDictionary.Library.CommandHandlers.TranslationWayToReaderCommandHandler;
using SerbianEnglishDictionary.Library.DictionaryReaders;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Initializers.CommandHandlers.TranslationWayToReaderCommandHandlers
{
	public class TranslationWayToReaderCommandHandlerInitializer
	{
		private static TranslationWayToReaderCommandHandler _translationWayToReaderCommandHandler;

		public static TranslationWayToReaderCommandHandler Get()
		{
			if (_translationWayToReaderCommandHandler != null)
				return _translationWayToReaderCommandHandler;

			_translationWayToReaderCommandHandler = new TranslationWayToReaderCommandHandler();

			_translationWayToReaderCommandHandler.Register(TranslationWay.SerbianToEnglish, new SerbianToEnglishDictionaryReader(Config.Instance.DictionaryPath));
			_translationWayToReaderCommandHandler.Register(TranslationWay.EnglishToSerbian, new EnglishToSerbianDictionaryReader(Config.Instance.DictionaryPath));


			return _translationWayToReaderCommandHandler;
		}
	}
}
