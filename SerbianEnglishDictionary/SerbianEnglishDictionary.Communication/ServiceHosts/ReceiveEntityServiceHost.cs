using System;
using System.Collections.Generic;
using SerbianEnglishDictionary.Communication.Messages.ServiceClasses;
using SerbianEnglishDictionary.Library.DictionaryWriters.Interface;
using SerbianEnglishDictionary.Library.Enums;

namespace SerbianEnglishDictionary.Communication.ServiceHosts
{
	public class ReceiveEntityServiceHost : ReceiveEntityService
	{
		private readonly IDictionaryWriter _writer;
		private readonly Dictionary<EntityType, DictionaryType> _entityToDictionaryTypeMap;

		public ReceiveEntityServiceHost(IDictionaryWriter writer, Dictionary<EntityType, DictionaryType> entityToDictionaryTypeMap)
		{
			_writer = writer;
			_entityToDictionaryTypeMap = entityToDictionaryTypeMap;
		}

		public override CreateEntityResponse CreateEntity(CreateEntityRequest request)
		{
			try
			{
				var pair = new Tuple<string, string>(request.EnglishEntity, request.SerbianEntity);
				_writer.AddEntity(pair, _entityToDictionaryTypeMap[request.Type]);
				return new CreateEntityResponse(ResponseResult.OK, null);
			}
			catch (Exception e)
			{
				return new CreateEntityResponse(ResponseResult.FAILED, e.Message);
			}
		}
	}
}