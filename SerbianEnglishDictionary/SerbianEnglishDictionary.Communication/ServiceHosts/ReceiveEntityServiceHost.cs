using System;
using SerbianEnglishDictionary.Communication.Messages.ServiceClasses;
using SerbianEnglishDictionary.Library.DictionaryWriters.Interface;

namespace SerbianEnglishDictionary.Communication.ServiceHosts
{
	public class ReceiveEntityServiceHost : ReceiveEntityService
	{
		private readonly IDictionaryWriter _writer;

		public override CreateEntityResponse CreateEntity(CreateEntityRequest request)
		{
			_writer.AddEntity(request);
			return null;
		}
	}
}