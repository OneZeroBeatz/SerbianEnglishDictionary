using SerbianEnglishDictionary.Initializers.Maps;
using SerbianEnglishDictionary.Library.DictionaryWriters.Base;

namespace SerbianEnglishDictionary.Initializers.DictionaryWriters
{
	public class DictionaryWriterInitializer
	{
		private static DictionaryWriter _dictionaryWriter;

		public static DictionaryWriter GetWriter()
		{
			if (_dictionaryWriter != null)
				return _dictionaryWriter;

			var dictionaryTypeToPathMap = DictionaryTypeToPathMapInitializer.GetMap();
			_dictionaryWriter = new DictionaryWriter(dictionaryTypeToPathMap.GetDictionaryPath(Config.Instance.DictionaryType));
			return _dictionaryWriter;
		}
	}
}
