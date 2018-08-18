using System.Collections.Generic;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.EntitiesFilters.Interface
{
	public abstract class EntitiesFilter
	{
		protected readonly int EntitiesCountLimit;

		protected EntitiesFilter(int entitiesCountLimit)
		{
			EntitiesCountLimit = entitiesCountLimit;
		}

		public abstract Dictionary<long, WordData> GetFilteredEntities(Dictionary<long, WordData> dictionary);
	}
}
