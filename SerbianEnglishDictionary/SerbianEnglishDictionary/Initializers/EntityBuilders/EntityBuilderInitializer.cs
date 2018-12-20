using SerbianEnglishDictionary.Library.EntityBuilders;

namespace SerbianEnglishDictionary.Initializers.EntityBuilders
{
	public class EntityBuilderInitializer
	{
		private static EntityBuilder _entityBuilder;

		public static EntityBuilder GetEntityBuilder()
		{
			if (_entityBuilder != null)
				return _entityBuilder;
			
			_entityBuilder = new EntityBuilder(Config.Instance.TranslationWay);
			return _entityBuilder;
		}
	}
}
