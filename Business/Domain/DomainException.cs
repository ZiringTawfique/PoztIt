using System;
namespace Domain
{
    public sealed class DomainException : Exception
    {
        internal DomainException(string exception) : base(exception) { }
    }
}
