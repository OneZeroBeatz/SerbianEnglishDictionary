namespace SerbianEnglishDictionary.Communication.Messages.ServiceClasses
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/ReceiveEntityService/", ConfigurationName="IReceiveEntityService")]
    public interface IReceiveEntityService
    {
        
        // CODEGEN: Generating message contract since the wrapper name (Entity) of message CreateEntityRequest does not match the default value (CreateEntity)
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ReceiveEntityService/:createEntityRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CreateEntityResponse CreateEntity(CreateEntityRequest request);
    }
}
