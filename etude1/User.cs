namespace etude1
{
    public class User
    { public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }

        public User()
        {
        }

        public User(string username, string password, string fullname)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
        }
    }
}