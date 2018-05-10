using Compilador.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Infra.Data
{
    public static class TableToken
    {
        public static List<Token> Table { get; set; } = new List<Token>();

        public static int AddToken(Token token)
        {
            Table.Add(token);
            return GetTokenId(token);
        }

        public static int GetTokenId(Token token)
        {
            foreach (var item in Table)
            {
                if (item.Type.Equals(token.Type))
                    return item.Id;
            }
            return -1;
        }

        public static bool ContainsToken(Token token)
        {
            foreach (var item in Table)
            {
                if (item.Name.Equals(token.Name))
                    return true;
            }
            return false;
        }
    }
}
