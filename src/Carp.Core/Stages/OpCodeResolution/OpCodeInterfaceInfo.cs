using AsmResolver.Net.Cts;

namespace Carp.Core.Stages.OpCodeResolution
{
    public class OpCodeInterfaceInfo
    {
        public OpCodeInterfaceInfo(TypeDefinition interfaceType, MethodDefinition getCode, MethodDefinition run)
        {
            InterfaceType = interfaceType;
            GetCodeMethod = getCode;
            RunMethod = run;
        }
        
        public TypeDefinition InterfaceType { get; }
        
        public MethodDefinition GetCodeMethod { get; }
        
        public MethodDefinition RunMethod { get; }
    }
}