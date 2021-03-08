using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerbianEnglishDictionary.Library.CommandHandlers.EntitiesFilterCommandHandler;
using SerbianEnglishDictionary.Library.CommandHandlers.TranslationWayToReaderCommandHandler;
using SerbianEnglishDictionary.Library.DictionaryReaders;
using SerbianEnglishDictionary.Library.EntitiesFilters;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Initializers.CommandHandlers.EntitiesFilterCommandHandlers
{
	public static class EntitiesFilterCommandHandlerInitializer
	{ 
		private static EntitiesFilterCommandHandler _entitiesFilterCommandHandler;

		public static EntitiesFilterCommandHandler Get()
		{
			if (_entitiesFilterCommandHandler != null)
				return _entitiesFilterCommandHandler;

			_entitiesFilterCommandHandler = new EntitiesFilterCommandHandler();

			_entitiesFilterCommandHandler.Register(EntitiesFilterType.All, new AllEntitiesFilter());
			_entitiesFilterCommandHandler.Register(EntitiesFilterType.LastAdded,new LastAddedEntitiesFilter(Config.Instance.EntitiesCountPercentage));

			return _entitiesFilterCommandHandler;
		}
	}
}
