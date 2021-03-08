using System.Collections.Generic;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.EntitiesFilters
{
	public class AllEntitiesFilter : EntitiesFilter
	{
		public AllEntitiesFilter() : base(100)
		{
		}

		public override Dictionary<long, WordData> GetFilteredEntities(Dictionary<long, WordData> dictionary)
		{
			return dictionary;
		}
	}
}
