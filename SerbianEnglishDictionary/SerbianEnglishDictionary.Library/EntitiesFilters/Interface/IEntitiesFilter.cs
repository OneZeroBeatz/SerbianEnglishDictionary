using System.Collections.Generic;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.EntitiesFilters.Interface
{
	public abstract class EntitiesFilter
	{
		protected readonly int EntitiesCountPercentage;

		protected EntitiesFilter(int entitiesCountPercentage)
		{
			EntitiesCountPercentage = entitiesCountPercentage;
		}

		public abstract Dictionary<long, WordData> GetFilteredEntities(Dictionary<long, WordData> dictionary);
	}
}
