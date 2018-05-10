using NUnit.Framework;
using System;
using FluentAssertions;
using Compilador.Domain.Exceptions;
using Compilador.Common.Tests;

namespace Compilador.Domain.Tests
{
    [TestFixture]
    public class SymbolTests
    {
        Symbol _symbol;

        [Test]
        public void Symbol_Test_ShouldValidateOk()
        {
            _symbol = ObjectMother.GetValidSymbol();
            Action action = () => _symbol.Validate();
            action.Should().NotThrow();
        }

        [Test]
        public void Symbol_Test_ShouldThrowEmptyNameException()
        {
            _symbol = ObjectMother.GetEmptyNameSymbol();
            Action action = () => _symbol.Validate();
            action.Should().Throw<EmptyNameException>();
        }

        [Test]
        public void Symbol_Test_ShouldThrowEmptyNameExceptionOnWhitespaceName()
        {
            _symbol = ObjectMother.GetWhitespaceNameSymbol();
            Action action = () => _symbol.Validate();
            action.Should().Throw<EmptyNameException>();
        }
    }
}
