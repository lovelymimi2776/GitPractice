namespace ProjectApp
{
    public class Login
    {
        public bool Authenticate(string username, string password)
        {
            return username == "admin" && password == "123456";
        }
    }
}