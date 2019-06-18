using System;

namespace NServiceBus.AttributeConventions.Contracts
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class MessageAttribute : Attribute
    {
        
    }
}
