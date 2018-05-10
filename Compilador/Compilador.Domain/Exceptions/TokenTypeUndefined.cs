using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Domain.Exceptions
{
    public class TokenTypeUndefined : BusinessException
    {
        public TokenTypeUndefined() : base("O Token não teve um tipo definido")
        {
        }
    }
}
