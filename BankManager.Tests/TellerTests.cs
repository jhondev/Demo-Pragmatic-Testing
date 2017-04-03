using NUnit.Framework;

namespace BankManager.Tests
{
    [TestFixture]
    public class TellerTests
    {
        private Teller _teller;
        [SetUp]
        public void SetUp()
        {
            _teller = new Teller();
        }

        [Test]
        public void CheckBalance_WithNoTransactions_ReturnsZeroBalance()
        {
            var accountBalance = _teller.CheckBalance();

            const int expectedBalance = 0;

            Assert.That(accountBalance, Is.EqualTo(expectedBalance),
                "Empty account should return cero balance");
        }

        [Test]
        public void ProcessTransaction_FirstTransaction_ReturnsCurrentBalanceSameAsTransasction()
        {
            const int depositAmount = 10;

            var accountBalance = _teller.ProcessTransaction(depositAmount);

            Assert.That(accountBalance, Is.EqualTo(depositAmount), 
                "First Transaction shourld return the same balance");
        }
    }
}
