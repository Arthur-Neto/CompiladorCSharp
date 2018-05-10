using Compilador.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Common.Tests
{
    public static class ObjectMother
    {
        public static Symbol GetValidSymbol()
        {
            return new Symbol()
            {
                Name = "Tests"
            };
        }

        public static Token GetValidToken()
        {
            return new Token()
            {
                Id = 1,
                Name = "Tests"
            };
        }

        public static Token GetValidTokenWithType()
        {
            return new Token()
            {
                Id = 1,
                Name = "Tests",
                Type = TypeToken.COMENTARIO                
            };
        }

        public static Symbol GetEmptyNameSymbol()
        {
            return new Symbol()
            {
                Name = ""
            };
        }

        public static Symbol GetWhitespaceNameSymbol()
        {
            return new Symbol()
            {
                Name = ""
            };
        }

        public static Token GetInvalidIdToken()
        {
            return new Token()
            {
                Id = 0,
                Name = "Tests"
            };
        }

        public static Token GetEmptyNameToken()
        {
            return new Token()
            {
                Id = 1,
                Name = "",
                Type = TypeToken.COMENTARIO
            };
        }

        public static Token GetWhitespaceNameToken()
        {
            return new Token()
            {
                Id = 1,
                Name = " ",
                Type = TypeToken.COMENTARIO
            };
        }

        public static Token GetUndefinedTypeTokenEmptyMessage()
        {
            return new Token()
            {
                Id = 1,
                Name = "",
                Type = 0
            };
        }

        public static Token GetUndefinedTypeTokenWhitespaceMessage()
        {
            return new Token()
            {
                Id = 1,
                Name = " ",
                Type = 0
            };
        }
    }
}
