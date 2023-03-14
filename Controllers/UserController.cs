using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INS_Backend.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private static readonly string[] firstNames = new[]
        {
            "ben", "bob", "billy"
        };

        private static readonly string[] lastNames = new[]
        {
            "smith", "thatch", "roof"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "users")]
        [Authorize(Roles = "Admin")]
        public IEnumerable<User> Get()
        {
            // replace with database call
            return Enumerable.Range(1, 5).Select(index => new User
            {
                firstName = firstNames[Random.Shared.Next(firstNames.Length)],
                lastName = lastNames[Random.Shared.Next(lastNames.Length)],
                age = Random.Shared.Next(1, 100)
            })
          .ToArray();
        }
    }
}