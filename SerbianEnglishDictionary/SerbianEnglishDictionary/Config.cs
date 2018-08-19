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

		public string DictionaryPath => GetDictionaryPath("DictionaryPath");

		public TranslationWay TranslationWay => GetTrasnlationWay("TranslationWay");

		public EntitiesFilterType EntitiesFilterType => GetEntitiesFilterType("EntitiesFilterType");

		public int EntitiesCountPercentage => GetEntitiesCountPercentage("EntitiesCountPercentage");


		#endregion

		#region Private methods

		private static string GetDictionaryPath(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}

		private static TranslationWay GetTrasnlationWay(string key)
		{
			var currentTranslationWay = ConfigurationManager.AppSettings[key];
		
			TranslationWay translationWay;
			if (Enum.TryParse(currentTranslationWay, out translationWay))
			{
				return translationWay;
			}
			
			throw new Exception("Cannot parse config file");
		}

		private static EntitiesFilterType GetEntitiesFilterType(string key)
		{
			var currentEntitiesFilter = ConfigurationManager.AppSettings[key];

			EntitiesFilterType entitiesFilterType;
			if (Enum.TryParse(currentEntitiesFilter, out entitiesFilterType))
			{
				return entitiesFilterType;
			}

			throw new Exception("Cannot parse config file");
		}

		private static int GetEntitiesCountPercentage(string key)
		{
			var currentEntitiesCountPercentage = ConfigurationManager.AppSettings[key];

			int entitiesCountPercentage;
			if (Int32.TryParse(currentEntitiesCountPercentage, out entitiesCountPercentage))
			{
				return entitiesCountPercentage;
			}

			throw new Exception("Cannot parse config file");
		}


		#endregion
	}
}
