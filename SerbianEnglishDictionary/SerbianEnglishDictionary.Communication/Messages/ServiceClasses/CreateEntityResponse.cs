namespace SerbianEnglishDictionary.Communication.Messages.ServiceClasses
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Response", WrapperNamespace="http://localhost/ReceiveEntityService/", IsWrapped=true)]
    public partial class CreateEntityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/ReceiveEntityService/", Order=0)]
        public ResponseResult Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/ReceiveEntityService/", Order=1)]
        public string Description;
        
        public CreateEntityResponse()
        {
        }
        
        public CreateEntityResponse(ResponseResult Result, string Description)
        {
            this.Result = Result;
            this.Description = Description;
        }
    }
}
