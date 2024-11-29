using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject1.Services
{
   
    public class AuthService
    {
        private const string LoggedInKey = "logged-in";
        private readonly IPreferences _preferences;
        private readonly DatabaseContext _context;
        public AuthService(DatabaseContext context) 
        {
            _preferences = Preferences.Default;
            _context = context;
        }
        public bool IsSignedIn => _preferences.ContainsKey(LoggedInKey);

        public async Task<MethodResult> SignupAsync(SignupModel model)
        {
            var user = new User
            {
                Name = model.Name,
                Username = model.userName,
                Password = model.userPassword
            };
            if(await _context.AddItemAsync<User>(user))
            {
                SetUser(user);
                return MethodResult.Success();
            }
            return MethodResult.Fail(null);

        }
        public async Task<MethodResult> SignIn(SigninModel model) 
        {
            var users = await _context.GetFileteredAsync<User>(u => u.Username == model.userName && u.Password == model.userPassword);
            var user = users.FirstOrDefault();
            if (user is not null)
            {
                SetUser(user);
                return MethodResult.Success();
            }
            return MethodResult.Fail("Incorrect credentials");


        }

        private void SetUser(User user)
        {
            var loggedInUser = new LoggedInUser(user.Id, user.Name);
            _preferences.Set(LoggedInKey, loggedInUser.ToJson());
        }

        public void SignOut()
        {
          
            _preferences.Remove(LoggedInKey);
        }
    }
}
