using Interfaces;
using System;

namespace DomainModel
{
    public class Entity : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOrganization { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Image Image { get; set; }
        public Address Address { get; set; }
        public Identification Identification { get; set; }

        public string GetOrganizationName()
        {
            return Name;
        }

        public void SetOrganizationName(string name)
        {
            Name = name;
        }

        public string GetFirstName()
        {
            string[] nameArray = Name.Split(',');
            string firstName = nameArray[1];
            return firstName.TrimStart(' ');
        }

        public string GetLastName()
        {
            string[] nameArray = Name.Split(',');
            string lastName = nameArray[0];
            return lastName;
        }

        public void SetPersonName(string firstName, string lastName)
        {
            Name = $"{lastName}, {firstName}";
        }
    }
}
