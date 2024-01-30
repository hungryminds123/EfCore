using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FullName
        {
            get
            {
                 return FirstName + " " + LastName;
            }
        }

        [JsonIgnore]
        public string FirstName { get; set; }

        [JsonIgnore]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
