using System;
using System.IO;
using SerbianEnglishDictionary.Library.DictionaryWriters.Interface;

namespace SerbianEnglishDictionary.Library.DictionaryWriters.Base
{
	public class DictionaryWriter : IDictionaryWriter
	{
		private readonly string _dictionaryPath;

		public DictionaryWriter(string dictionaryPath)
		{
			_dictionaryPath = dictionaryPath;
		}

		public void AddEntity(Tuple<string, string> entity)
		{
			using (var writer = File.AppendText(_dictionaryPath))
			{
				//TODO: Add check if entity exists and add apropriate pair if just one word is same
				writer.WriteLine(string.Format("{0},{1},0", entity.Item1, entity.Item2));
			}	
		}

		public void IncrementEntityChoosingTimesCount(long lineIndex)
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
