namespace AuthProject.Identities
{
    public class CustomIdentityUserDto
    {
        public CustomIdentityUserDto(string userName, string userEmail, string password)
        {
            UserName = userName;
            UserEmail = userEmail;
            Password = password;
        }

        public CustomIdentityUserDto()
        {
            
        }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}