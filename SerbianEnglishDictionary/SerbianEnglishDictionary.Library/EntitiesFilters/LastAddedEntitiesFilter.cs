using System.Collections.Generic;
using System.Linq;
using SerbianEnglishDictionary.Library.EntitiesFilters.Interface;
using SerbianEnglishDictionary.Library.IntermediateModel;

namespace SerbianEnglishDictionary.Library.EntitiesFilters
{
	public class LastAddedEntitiesFilter : EntitiesFilter
	{
		public LastAddedEntitiesFilter(int entitiesCountPercentage) : base(entitiesCountPercentage)
		{
		}

		public override Dictionary<long, WordData> GetFilteredEntities(Dictionary<long, WordData> dictionary)
		{
			var entitiesCountLimit = GetEntitiesCountLimit(dictionary.Count);

			return dictionary.Skip(dictionary.Count - entitiesCountLimit).Take(entitiesCountLimit).ToDictionary(x => x.Key, y => y.Value);
		}

		private int GetEntitiesCountLimit(int dictionaryCount)
		{
			return (dictionaryCount * EntitiesCountPercentage) / 100;
		}
	}
}
