using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AccountModule.Models;
namespace AccountModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private static List<Account> accounts = new List<Account> { };

        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> GetAccounts()
        {
            return accounts;
        }

        [HttpPost]
        public IActionResult PostAccounts(Account account)
        {
            accounts.Add(account);
            return Ok(account);
        }
    }
}

