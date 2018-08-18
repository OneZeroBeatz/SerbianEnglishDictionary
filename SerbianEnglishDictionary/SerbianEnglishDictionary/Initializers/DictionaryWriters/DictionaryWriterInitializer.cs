using SerbianEnglishDictionary.Library.DictionaryWritters.Base;

namespace SerbianEnglishDictionary.Initializers.DictionaryWriters
{
	public class DictionaryWriterInitializer
	{
		private static DictionaryWriter _dictionaryWriter;

		public static DictionaryWriter GetWriter()
		{
			if (_dictionaryWriter == null)
				_dictionaryWriter = new DictionaryWriter(Config.Instance.DictionaryPath);
			return _dictionaryWriter;
		}
	}
}
