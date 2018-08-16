using System.Collections.Generic;

namespace SerbianEnglishDictionary.Library.EntitiesFilters.Interface
{
	public abstract class EntitiesFilter
	{
		protected readonly int EntitiesCountLimit;

		protected EntitiesFilter(int entitiesCountLimit)
		{
			EntitiesCountLimit = entitiesCountLimit;
		}

		public abstract Dictionary<string, string> GetFilteredEntities(Dictionary<string, string> dictionary);
	}
}
