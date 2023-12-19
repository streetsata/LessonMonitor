using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController   : ControllerBase
    {
        [HttpGet]
        public User[] Get(string userName)
        {
            var rnd = new Random();
            var users = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                var user = new User
                {
                    Name = userName + i,
                    Age = rnd.Next(18, 60)
                };

                users.Add(user);
            }

            return users.ToArray();
        }
    }
}