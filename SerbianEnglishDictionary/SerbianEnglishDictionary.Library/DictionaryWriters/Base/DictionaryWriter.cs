using System.IO;

namespace SerbianEnglishDictionary.Library.DictionaryWritters.Base
{
	public class DictionaryWriter
	{
		private readonly string _dictionaryPath;

		public DictionaryWriter(string dictionaryPath)
		{
			_dictionaryPath = dictionaryPath;
		}

		public void IncrementWordChoosingsCount(long lineIndex)
		{
			var lines = File.ReadAllLines(_dictionaryPath);
			using (var writer = new StreamWriter(_dictionaryPath))
			{
				for (var currentLine = 0; currentLine < lines.Length; ++currentLine)
				{
					if (currentLine == lineIndex)
					{
						var line = lines[lineIndex].Split(',');
						line[2] = (int.Parse(line[2]) + 1).ToString();
						writer.WriteLine(string.Join(",", line));
					}
					else
					{
						writer.WriteLine(lines[currentLine]);
					}
				}
			}

		}
	}
}
