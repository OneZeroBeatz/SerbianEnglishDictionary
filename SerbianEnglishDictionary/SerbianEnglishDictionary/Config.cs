using SerbianEnglishDictionary.Library.Enums;
using System;
using System.Configuration;

namespace SerbianEnglishDictionary
{
	public class Config
	{
		#region Instance

		private static Config _instance;

		private Config() { }

		public static Config Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Config();
				return _instance;
			}
		}

		#endregion

		#region Properties

		public string DictionaryPath { get { return GetDictionaryPath("DictionaryPath"); } }

		public TranslationType CurrentTranslationType { get { return GetCurrentTrasnlationType("CurrentTranslationType"); } }

		#endregion

		#region Private methods

		private string GetDictionaryPath(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}

		private TranslationType GetCurrentTrasnlationType(string key)
		{
			var currentTranslationType = ConfigurationManager.AppSettings[key];
			foreach (var enumeration in Enum.GetNames(typeof(TranslationType)))
			{
				TranslationType translationType;
				if (Enum.TryParse(currentTranslationType, out translationType))
				{
					return translationType;
				}
			}
			throw new Exception("Cannot parse config file");
		}


		#endregion
	}
}
