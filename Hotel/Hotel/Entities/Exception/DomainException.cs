using System;

namespace Hotel.Entities.Exception
{
    class DomainException : ApplicationException
    {       
        public DomainException(string message) : base(message)
        {

        }
    
    }
}
