using Microsoft.AspNetCore.Http.HttpResults;
using AccountModule.Controllers;
using AccountModule.Models;
namespace Testing
{
    public class Tests
    {
        private AccountController controller;
        [SetUp]
        public void Setup()
        {
            controller = new AccountController();
        }

        [Test]
        public void TestMethodForGetAccount()
        {
            IEnumerable<Account> result = controller.GetAccounts();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostAccount()
        {
            var newItem = new Account
            {
                Account_number = 12345612,
                Acc_holder_name = "Karnisha",
                Account_type = "Savings",
                Balance_amount = 10000,
                Phone_number =9047897652
            };
            var actionResult = controller.PostAccounts(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostAccountNull()
        {
            var newItem = new Account
            {
                Account_number = 12345612,
                Acc_holder_name = null,
                Account_type = null,
                Balance_amount = 10000,
                Phone_number =9047897652
            };
            var actionResult = controller.PostAccounts(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}