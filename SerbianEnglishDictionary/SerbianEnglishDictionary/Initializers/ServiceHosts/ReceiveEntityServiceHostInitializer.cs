using System;
using System.Collections.Generic;
using System.ServiceModel;
using SerbianEnglishDictionary.Communication.Messages.ServiceClasses;
using SerbianEnglishDictionary.Communication.ServiceHosts;
using SerbianEnglishDictionary.Initializers.DictionaryWriters;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Initializers.ServiceHosts
{
	public class ReceiveEntityServiceHostInitializer
	{
		private static ReceiveEntityService _service;

		public static void Initialize()
		{
			if (_service == null)
			{
				var dictionaryWriter = DictionaryWriterInitializer.GetWriter();
				var entityTypeToDictionaryTypeMap = new Dictionary<EntityType, DictionaryType>
				{
					{EntityType.Words, DictionaryType.WordsDictionary },
					{EntityType.Phrases, DictionaryType.PhrasesDictionary },
					{EntityType.Sentences, DictionaryType.SentencesDictionary}
				};

				_service = new ReceiveEntityServiceHost(dictionaryWriter, entityTypeToDictionaryTypeMap);
			}

			var servicehost = new ServiceHost(_service, new Uri("http://localhost:8083/ReceiveEntityService"));
			servicehost.Open();
		}
	}
}
