using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Domain.Exceptions
{
    public class IdentifierUndefinedException : BusinessException
    {
        public IdentifierUndefinedException() : base("Id não definido")
        {
        }
    }
}
