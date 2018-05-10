using Compilador.Common.Tests;
using NUnit.Framework;
using System;
using FluentAssertions;
using Compilador.Domain.Exceptions;

namespace Compilador.Domain.Tests
{
    [TestFixture]
    public class TokenTests
    {
        Token _token;

        [Test]
        public void Symbol_Test_ShouldValidateOk()
        {
            _token = ObjectMother.GetValidToken();
            Action action = () => _token.Validate();
            action.Should().NotThrow();
        }

        [Test]
        public void Symbol_Test_ShouldValidateWithTypeOk()
        {
            _token = ObjectMother.GetValidTokenWithType();
            Action action = () => _token.Validate();
            action.Should().NotThrow();
        }

        [Test]
        public void Symbol_Test_ShouldThrowIdentifierUndefinedException()
        {
            _token = ObjectMother.GetInvalidIdToken();
            Action action = () => _token.Validate();
            action.Should().Throw<IdentifierUndefinedException>();
        }

        [Test]
        public void Symbol_Test_ShouldNotThrowEmptyNameException()
        {
            _token = ObjectMother.GetEmptyNameToken();
            Action action = () => _token.Validate();
            action.Should().NotThrow();
        }

        [Test]
        public void Symbol_Test_ShouldEmptyNameExceptionOnWhitespaceName()
        {
            _token = ObjectMother.GetWhitespaceNameToken();
            Action action = () => _token.Validate();
            action.Should().NotThrow();
        }

        [Test]
        public void Symbol_Test_ShouldThrowTokenTypeUndefinedOnEmptyName()
        {
            _token = ObjectMother.GetUndefinedTypeTokenEmptyMessage();
            Action action = () => _token.Validate();
            action.Should().Throw<TokenTypeUndefined>();
        }

        [Test]
        public void Symbol_Test_ShouldThrowTokenTypeUndefinedOnWhitespaceName()
        {
            _token = ObjectMother.GetUndefinedTypeTokenWhitespaceMessage();
            Action action = () => _token.Validate();
            action.Should().Throw<TokenTypeUndefined>();
        }
    }
}
