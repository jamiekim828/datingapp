namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        // after this, we need to add more column to database
        // possible by migration
        // API -> $ dotnet ef migrations add UserPasswordAdded
        // and then $ dotnet ef database update

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}