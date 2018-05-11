using Compilador.Domain;
using Compilador.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compilador.Infra
{
    public class LexicalAnalyzer
    {

        private static readonly int[,] TransitionTable = {
        //d   l  (    )  [    ]   +   -   *   /   %   ,   .   :   =   >   <   "  #13
        { 3,  1, 24, 25, 42, 41,  8, 12, 26, 16, 21, 43,  1, 44, 29, 32, 35, 38, -1},//q0
        { 2,  1,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2, -1},//q1
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q2
        { 3,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  5,  4,  4,  4,  4,  4,  4},//q3
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q4
        { 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q5
        { 6,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7,  7},//q6
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q7
        { 3, 11, 11, 11, 11, 11,  9, 11, 11, 11, 11, 11, 11, 11, 10, 11, 11, 11, 11},//q8
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q9
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q10
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q11
        { 3, 15, 15, 15, 15, 15, 15, 13, 15, 15, 15, 15, 15, 15, 14, 15, 15, 15, 15},//q12
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q13
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q14
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q15
        {19, 19, 19, 19, 19, 19, 19, 19, 19, 17, 19, 19, 19, 19, 20, 19, 19, 19, 19},//q16
        {17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 18},//q17
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q18
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q19
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q20
        {22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 22, 22, 22, 22},//q21
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q22
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q23
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q24
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q25
        {28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 27, 28, 28, 28, 28},//q26
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q27
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q28
        {31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 30, 31, 31, 31, 31},//q29
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q30
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q31
        {33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 34, 33, 33, 33, 33},//q32
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q33
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q34
        {36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 36, 36, 36, 36},//q35
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q36
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q37
        {38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 39, 40},//q38
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q39
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q40
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q41
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q42
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},//q43
        {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1}};//q44

        private static readonly string[] reservedWords = { "algoritmo", "var", "inicio", "fimalgoritmo", "inteiro", "real", "caractere", "logico", "vetor", "escreval", "leia", "para", "de", "ate", "faca", "fimpara", "se", "senao", "fimse" };
        private static readonly string[] separators = { "(", ")", "[", "]", "\n", "\0", ",", ":", "." };
        private static readonly string[] operators = { "+", "-", "/", "%", "[]", "()", ">", "<", "=", "<=", ">=", "^" };

        public LexicalAnalyzer()
        {
            TableToken.ClearTable();
            TableSymbol.ClearTable();

            TableSymbol.AddSymbol(new Symbol { Id = 1, Name = "algoritmo" });
            TableSymbol.AddSymbol(new Symbol { Id = 2, Name = "var" });
            TableSymbol.AddSymbol(new Symbol { Id = 3, Name = "inicio" });
            TableSymbol.AddSymbol(new Symbol { Id = 4, Name = "fimalgoritmo" });
            TableSymbol.AddSymbol(new Symbol { Id = 5, Name = "inteiro" });
            TableSymbol.AddSymbol(new Symbol { Id = 6, Name = "real" });
            TableSymbol.AddSymbol(new Symbol { Id = 7, Name = "caractere" });
            TableSymbol.AddSymbol(new Symbol { Id = 8, Name = "logico" });
            TableSymbol.AddSymbol(new Symbol { Id = 9, Name = "vetor" });
            TableSymbol.AddSymbol(new Symbol { Id = 10, Name = "escreval" });
            TableSymbol.AddSymbol(new Symbol { Id = 11, Name = "leia" });
            TableSymbol.AddSymbol(new Symbol { Id = 12, Name = "para" });
            TableSymbol.AddSymbol(new Symbol { Id = 13, Name = "de" });
            TableSymbol.AddSymbol(new Symbol { Id = 14, Name = "ate" });
            TableSymbol.AddSymbol(new Symbol { Id = 15, Name = "faca" });
            TableSymbol.AddSymbol(new Symbol { Id = 16, Name = "fimpara" });
            TableSymbol.AddSymbol(new Symbol { Id = 17, Name = "se" });
            TableSymbol.AddSymbol(new Symbol { Id = 18, Name = "senao" });
            TableSymbol.AddSymbol(new Symbol { Id = 19, Name = "fimse" });
        }

        public void AnalyzeCode(string code)
        {
            code = code.ToLower();
            StringBuilder str = new StringBuilder();
            int estate = 0;
            Symbol symbol;
            bool literal = false;

            for (int i = 0; i < code.Length; i++)
            {
                while (estate != -1)
                {
                    if (i >= code.Length)
                        break;

                    if (char.IsDigit(code[i]))
                    {
                        estate = TransitionTable[estate, GetKeywordColumn('d')];
                    }
                    else if (char.IsLetter(code[i]))
                    {
                        estate = TransitionTable[estate, GetKeywordColumn('l')];
                    }
                    else if (char.IsWhiteSpace(code[i]) && literal == false)
                    {
                        break;
                    }
                    else if (!char.IsLetterOrDigit(code[i]))
                    {
                        if (!char.IsWhiteSpace(code[i]))
                        {
                            estate = TransitionTable[estate, GetKeywordColumn(code[i])];
                            if (code[i] == '\"')
                            {
                                if (literal == false)
                                    literal = true;
                                else
                                {
                                    literal = false;
                                }
                            }
                        }
                        if (literal == false && code[i] != '\"')
                            break;
                    }
                    if (estate == -1)
                    {
                        break;
                    }

                    str.Append(code[i]);
                    i++;
                }
                double num;
                if (!string.IsNullOrWhiteSpace(str.ToString()))
                {
                    symbol = new Symbol() { Id = TableSymbol.Table.Count + 1, Name = str.ToString() };
                    if (!TableSymbol.ContainsSymbol(symbol))
                        TableSymbol.AddSymbol(symbol);
                    if (reservedWords.Contains(symbol.Name))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.PALAVRA_RESERVADA });
                    }
                    else if (separators.Contains(symbol.Name))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.SEPARADOR });
                    }
                    else if (operators.Contains(symbol.Name))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.OPERADOR });
                    }
                    else if (symbol.Name.StartsWith("\\"))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.COMENTARIO });
                    }
                    else if (symbol.Name.StartsWith("\"") && symbol.Name.EndsWith("\""))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.LITERAL });
                    }
                    else if (double.TryParse(symbol.Name, out num))
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.NUMERO });
                    }
                    else
                    {
                        TableToken.AddToken(new Token() { Id = TableSymbol.GetSymbolId(symbol), Name = symbol.Name, Type = TypeToken.IDENTIFICADOR });
                    }
                }
                str = new StringBuilder();
                estate = 0;
            }
        }

        private int GetKeywordColumn(char c)
        {
            switch (c)
            {
                case 'd':
                    return 0;
                case 'l':
                    return 1;
                case '(':
                    return 2;
                case ')':
                    return 3;
                case '[':
                    return 4;
                case ']':
                    return 5;
                case '+':
                    return 6;
                case '-':
                    return 7;
                case '*':
                    return 8;
                case '/':
                    return 9;
                case '%':
                    return 10;
                case ',':
                    return 11;
                case '.':
                    return 12;
                case ':':
                    return 13;
                case '=':
                    return 14;
                case '>':
                    return 15;
                case '<':
                    return 16;
                case '"':
                    return 17;
                case '\n':
                    return 18;
                case '\0':
                    return -1;
                default:
                    break;
            }
            return -1;
        }
    }
}
