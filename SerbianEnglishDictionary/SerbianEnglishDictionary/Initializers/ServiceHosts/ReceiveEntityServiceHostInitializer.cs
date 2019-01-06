using System;
using System.ServiceModel;
using SerbianEnglishDictionary.Communication.Messages.ServiceClasses;
using SerbianEnglishDictionary.Communication.ServiceHosts;

namespace SerbianEnglishDictionary.Initializers.ServiceHosts
{
	public class ReceiveEntityServiceHostInitializer
	{
		private static ReceiveEntityService _service;

		public static void Initialize()
		{
			if (_service == null)
				_service = new ReceiveEntityServiceHost();

			var servicehost = new ServiceHost(_service, new Uri("http://localhost/ReceiveEntityService"));
			servicehost.Open();
			

		}
	}
}
