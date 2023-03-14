namespace INS_Frontend.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>() { 
            new UserModel() { Username = "kieran", Password = "password", EmailAddress = "kieran@gmail.com", Role = "Admin"},
            new UserModel() { Username = "bruno", Password = "password", EmailAddress = "bruno@gmail.com", Role = "Support"}
        };

    }
}
