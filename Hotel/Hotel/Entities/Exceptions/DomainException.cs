using System;


namespace Hotel.Entities.Execpitions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message):base (message)
        {

        }
    }
}
