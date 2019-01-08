using SerbianEnglishDictionary.Initializers.Maps;
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
			var dictionaryTypeToDictionaryPathMap = DictionaryTypeToPathMapInitializer.GetMap();
			var dictionaryType = Config.Instance.DictionaryType;

			_translationWayToReaderCommandHandler.Register(TranslationWay.SerbianToEnglish, new SerbianToEnglishDictionaryReader(dictionaryTypeToDictionaryPathMap.GetDictionaryPath(dictionaryType)));
			_translationWayToReaderCommandHandler.Register(TranslationWay.EnglishToSerbian, new EnglishToSerbianDictionaryReader(dictionaryTypeToDictionaryPathMap.GetDictionaryPath(dictionaryType)));


			return _translationWayToReaderCommandHandler;
		}
	}
}
