using Compilador.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Domain
{
    public enum TypeToken
    {
        IDENTIFICADOR = 1, SEPARADOR, OPERADOR, LITERAL, NUMERO, COMENTARIO, PALAVRA_RESERVADA, UNDEFINED = 0
    }

    public class Token
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeToken Type { get; set; }

        public void Validate()
        {
            if (Id == 0)
                throw new IdentifierUndefinedException();
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrEmpty(Name)) { 
                if (Type == 0)
                    throw new TokenTypeUndefined();}

        }

        public string GetNameOrType()
        {
            if (string.IsNullOrEmpty(Name))
                return String.Format("{0}", Type.ToString());
            else
                return String.Format("{0}", Name);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name))
                return String.Format("{0} - {1}", Id, Type);
            else
                return String.Format("{0} - {1}", Id, Name);

        }
    }
}
