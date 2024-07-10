using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Entities.Exceptions
{
    class DomainException : ApplicationException // isso faz com que essa classe seja uma exceção
    {
        public DomainException(string message) : base(message) 
        {

        }
    }
}
