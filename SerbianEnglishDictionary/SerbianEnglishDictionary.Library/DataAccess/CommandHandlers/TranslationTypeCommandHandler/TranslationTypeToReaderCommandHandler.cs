using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base;
using SerbianEnglishDictionary.Library.Enums;
using System.Collections.Generic;

namespace SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler
{
	public class TranslationTypeToReaderCommandHandler
	{
		private readonly Dictionary<TranslationType, IDictionaryReader> _translationTypeToReaderMap;

		public TranslationTypeToReaderCommandHandler()
		{
			_translationTypeToReaderMap = new Dictionary<TranslationType, IDictionaryReader>();
		}

		public void Register(TranslationType translationType, IDictionaryReader dictionaryReader)
		{
			if (!_translationTypeToReaderMap.ContainsKey(translationType))
				_translationTypeToReaderMap.Add(translationType, dictionaryReader);
			else
				System.Console.WriteLine("Translation type {0} is already registered", translationType);

		}

		public IDictionaryReader GetDictionaryReader(TranslationType translationType)
		{
			return _translationTypeToReaderMap[translationType];
		}

	}
}
