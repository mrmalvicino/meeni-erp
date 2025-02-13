using DomainModel.Common;
using DomainModel.Locations;
using Interfaces;
using System;

namespace DomainModel.Base
{
    public class Entity : IIdentifiable
    {
        private string _firstName;
        private string _lastName;

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOrganization { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Image Image { get; set; }
        public Address Address { get; set; }
        public Identification Identification { get; set; }

        public string BirthDateString
        {
            get
            {
                return BirthDate.ToString("yyyy-MM-dd");
            }

            set
            {
                DateTime birthDate;
                DateTime.TryParse(value, out birthDate);
                BirthDate = birthDate;
            }
        }

        public string OrganizationName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string FirstName
        {
            get
            {
                string[] nameArray = Name.Split(',');
                string firstName = nameArray[1];
                return firstName.TrimStart(' ');
            }

            set
            {
                _firstName = value;
                Name = $"{_lastName}, {_firstName}";
            }
        }

        public string LastName
        {
            get
            {
                string[] nameArray = Name.Split(',');
                string lastName = nameArray[0];
                return lastName;
            }

            set
            {
                _lastName = value;
                Name = $"{_lastName}, {_firstName}";
            }
        }
    }
}
