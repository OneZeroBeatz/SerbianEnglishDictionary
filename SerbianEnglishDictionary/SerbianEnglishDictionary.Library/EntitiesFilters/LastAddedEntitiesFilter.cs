using System.Collections.Generic;
using System.Linq;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.EntitiesFilters
{
	public class LastAddedEntitiesFilter : EntitiesFilter
	{
		public LastAddedEntitiesFilter(int entitiesCountLimit) : base(entitiesCountLimit)
		{
		}

		public override Dictionary<long, WordData> GetFilteredEntities(Dictionary<long, WordData> dictionary)
		{
			return dictionary.Skip(dictionary.Count - EntitiesCountLimit)
				.Take(EntitiesCountLimit)
				.ToDictionary(x => x.Key, y => y.Value);
		}
	}
}
