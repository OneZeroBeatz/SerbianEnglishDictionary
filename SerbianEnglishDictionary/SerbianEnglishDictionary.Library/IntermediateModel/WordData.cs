namespace SerbianEnglishDictionary.Library.IntermediateModel
{
	public class WordData
	{
		public long Index { get; private set; }
		public string FirstWord { get; private set; }
		public string SecondWord { get; private set; }
		public long ChoosingsCount { get; private set; }

		public WordData(long index, string firstWord, string secondWord, long choosingsCount)
		{
			Index = index;
			FirstWord = firstWord;
			SecondWord = secondWord;
			ChoosingsCount = choosingsCount;
		}
	}
}
