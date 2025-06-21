namespace AplikacjaBankowa
{
    public class User
    {
        public int    Id       { get; }
        public string Username { get; }
        public int    RoleId   { get; }

        public User(int id, string username, int roleId)
        {
            Id = id;
            Username = username;
            RoleId = roleId;
        }
    }
}