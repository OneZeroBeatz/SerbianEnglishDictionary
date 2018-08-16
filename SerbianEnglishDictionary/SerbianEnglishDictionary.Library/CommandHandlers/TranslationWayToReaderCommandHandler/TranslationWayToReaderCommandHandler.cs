using System.Collections.Generic;
using SerbianEnglishDictionary.Library.DictionaryReaders.Base;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Library.CommandHandlers.TranslationWayToReaderCommandHandler
{
	public class TranslationWayToReaderCommandHandler
	{
		private readonly Dictionary<TranslationWay, DictionaryReader> _translationTypeToReaderMap;

		public TranslationWayToReaderCommandHandler()
		{
			_translationTypeToReaderMap = new Dictionary<TranslationWay, DictionaryReader>();
		}

		public void Register(TranslationWay translationWay, DictionaryReader dictionaryReader)
		{
			if (!_translationTypeToReaderMap.ContainsKey(translationWay))
				_translationTypeToReaderMap.Add(translationWay, dictionaryReader);
			else
				System.Console.WriteLine("Translation type {0} is already registered", translationWay);
		}

		public DictionaryReader GetDictionaryReader(TranslationWay translationWay)
		{
			return _translationTypeToReaderMap[translationWay];
		}
	}
}
