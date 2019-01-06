namespace SerbianEnglishDictionary.Communication.Messages.ServiceClasses
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Entity", WrapperNamespace="http://localhost/ReceiveEntityService/", IsWrapped=true)]
    public partial class CreateEntityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/ReceiveEntityService/", Order=0)]
        public string EnglishEntity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/ReceiveEntityService/", Order=1)]
        public string SerbianEntity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/ReceiveEntityService/", Order=2)]
        public EntityType Type;
        
        public CreateEntityRequest()
        {
        }
        
        public CreateEntityRequest(string EnglishEntity, string SerbianEntity, EntityType Type)
        {
            this.EnglishEntity = EnglishEntity;
            this.SerbianEntity = SerbianEntity;
            this.Type = Type;
        }
    }
}
