namespace SerbianEnglishDictionary.Communication.Messages.ServiceClasses
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.Single, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Multiple)]
    public abstract class ReceiveEntityService : IReceiveEntityService
    {
        
        public abstract CreateEntityResponse CreateEntity(CreateEntityRequest request);
    }
}
