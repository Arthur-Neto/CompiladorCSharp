using Compilador.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Infra.Data
{
    public static class TableSymbol
    {
        public static List<Symbol> Table { get; set; } = new List<Symbol>();

        public static int AddSymbol(Symbol symbol)
        {
            Table.Add(symbol);
            return GetSymbolId(symbol);
        }

        public static int GetSymbolId(Symbol symbol)
        {
            foreach (var item in Table)
            {
                if (item.Name.Equals(symbol.Name))
                    return item.Id;
            }
            return -1;
        }

        public static bool ContainsSymbol(Symbol symbol)
        {
            foreach (var item in Table)
            {
                if (item.Name.Equals(symbol.Name))
                    return true;
            }
            return false;
        }

        public static void ClearTable()
        {
            Table.Clear();
        }
    }
}
