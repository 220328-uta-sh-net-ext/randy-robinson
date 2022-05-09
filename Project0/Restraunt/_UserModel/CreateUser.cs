namespace UserModel
{
    public class CreateUser
    {

        //Properties of this class.
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        private bool IsAdmin { get; set; }
        public int UserTagNumber = 3332979;
        public int AdminTag = 3332900;
        private enum UserEnum { Admin = 0, RegUser = 1, }
        public CreateUser()
        {
            UserTagNumber++;
            UserName = " Havelpot ";
            FirstName = "-";
            LastName = "-";
            Password = "-";

        }
        public CreateUser(string firstName, string lastName, string userName)
        {
            UserTagNumber = UserTagNumber++;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;

        }
        public override string ToString()
        {
            string result = $"User Name: {UserName}\nFirstName: {FirstName}\nLastName:{LastName}\nUserTagNumber: {UserTagNumber}";
            return result;
        }
    }
}