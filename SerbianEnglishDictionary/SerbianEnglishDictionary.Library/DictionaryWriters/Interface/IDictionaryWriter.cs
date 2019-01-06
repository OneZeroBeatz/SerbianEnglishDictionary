using System;

namespace SerbianEnglishDictionary.Library.DictionaryWriters.Interface
{
	public interface IDictionaryWriter
	{
		void AddEntity(Tuple<string, string> entity);
	}
}
