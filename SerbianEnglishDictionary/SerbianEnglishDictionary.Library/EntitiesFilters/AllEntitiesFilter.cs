using System.Collections.Generic;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;

namespace SerbianEnglishDictionary.Library.EntitiesFilters
{
	public class AllEntitiesFilter : EntitiesFilter
	{
		public AllEntitiesFilter(int entitiesCountLimit) : base(entitiesCountLimit)
		{
		}

		public override Dictionary<string, string> GetFilteredEntities(Dictionary<string, string> dictionary)
		{
			return dictionary;
		}
	}
}
