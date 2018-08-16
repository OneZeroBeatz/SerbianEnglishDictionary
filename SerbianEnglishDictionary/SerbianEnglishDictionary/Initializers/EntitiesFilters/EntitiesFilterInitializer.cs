using SerbianEnglishDictionary.Initializers.CommandHandlers.EntitiesFilterCommandHandlers;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;

namespace SerbianEnglishDictionary.Initializers.EntitiesFilters
{
	public class EntitiesFilterInitializer
	{
		private static EntitiesFilter _entitiesFilter;

		public static EntitiesFilter GetFilter()
		{
			if (_entitiesFilter == null)
			{
				var commandHandler = EntitiesFilterCommandHandlerInitializer.Get();
				_entitiesFilter = commandHandler.GetEntitiesFilter(Config.Instance.EntitiesFilterType);
			}
			return _entitiesFilter;
		}
	}
}
