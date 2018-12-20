using System;
using System.Collections.Generic;
using SerbianEnglishDictionary.Library.Enums;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;

namespace SerbianEnglishDictionary.Library.CommandHandlers.EntitiesFilterCommandHandler
{
	public class EntitiesFilterCommandHandler
	{
		private readonly Dictionary<EntitiesFilterType, EntitiesFilter> _entitiesFilterMap;

		public EntitiesFilterCommandHandler()
		{
			_entitiesFilterMap = new Dictionary<EntitiesFilterType, EntitiesFilter>();
		}

		public void Register(EntitiesFilterType entitiesFilterType, EntitiesFilter concreteEntitiesFilter)
		{
			if (!_entitiesFilterMap.ContainsKey(entitiesFilterType))
				_entitiesFilterMap.Add(entitiesFilterType, concreteEntitiesFilter);
			else
				Console.WriteLine("Translation type {0} is already registered", entitiesFilterType);
		}

		public EntitiesFilter GetEntitiesFilter(EntitiesFilterType entitiesFilterType)
		{
			return _entitiesFilterMap[entitiesFilterType];
		}
	}
}
