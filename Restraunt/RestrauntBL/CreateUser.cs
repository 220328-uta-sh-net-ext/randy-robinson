namespace RestrauntBL
{
    public class CreateUser : CreateRestraunt
    {
        public CreateUser(string FirstName, string LastName) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
