using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Domain.Exceptions
{
    public class EmptyNameException : BusinessException
    {
        public EmptyNameException() : base("Não foi definido um nome")
        {
        }
    }
}
