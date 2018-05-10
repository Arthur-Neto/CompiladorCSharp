using Compilador.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Domain
{
    public class Symbol
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrEmpty(Name))
                throw new EmptyNameException();
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
