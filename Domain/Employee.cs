namespace Domain
{
    public class Employee : BaseEntity
    {

        public int Id { get; set; } 

        public string FirstName { get; set; }    

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }


        // How to create a foreign key constraint using EFCore code first approach.

    }
}
