using System;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Library.DictionaryWriters.Interface
{
	public interface IDictionaryWriter
	{
		void AddEntity(Tuple<string, string> entity, DictionaryType dictionaryType);
	}
}
