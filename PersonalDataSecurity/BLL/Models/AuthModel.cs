namespace PersonalDataSecurity.BLL.Models
{
    struct AuthStruct
    {
        string Login;
        string Password;
        public AuthStruct(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public string login()
        {
            return this.Login;
        }

        public string password()
        {
            return this.Password;
        }
    }
}
