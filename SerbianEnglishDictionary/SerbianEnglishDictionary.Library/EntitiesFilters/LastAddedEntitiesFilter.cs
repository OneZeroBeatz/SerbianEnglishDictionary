using System.Collections.Generic;
using System.Linq;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;

namespace SerbianEnglishDictionary.Library.EntitiesFilters
{
	public class LastAddedEntitiesFilter : EntitiesFilter
	{
		public LastAddedEntitiesFilter(int entitiesCountLimit) : base(entitiesCountLimit)
		{
		}

		public override Dictionary<string, string> GetFilteredEntities(Dictionary<string, string> dictionary)
		{
			return dictionary.Skip(dictionary.Count - EntitiesCountLimit)
				.Take(EntitiesCountLimit)
				.ToDictionary(x => x.Key, y => y.Value);
		}
	}
}
