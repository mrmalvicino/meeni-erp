﻿using Interfaces;
using System;

namespace DomainModel
{
    public class Entity : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOrganizaiton { get; set; }
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
            //string[] nameArray = Name.Split(',');
            //string firstName = nameArray[1];
            //return firstName.TrimStart(' ');
            return Name;
        }

        public string GetLastName()
        {
            //string[] nameArray = Name.Split(',');
            //string lastName = nameArray[0];
            //return lastName;
            return Name;
        }

        public void SetPersonName(string firstName, string lastName)
        {
            Name = $"{lastName}, {firstName}";
        }

        public string GetCUIT()
        {
            //return TaxCode;
            return "";
        }

        public void SetCUIT(string CUIT)
        {
            //TaxCode = CUIT;
            //string[] CUITArray = CUIT.Split('-');

            //if (CUIT.Length == 11 && CUITArray.Length == 1)
            //{
            //    TaxCode = "";

            //    for (int i = 0; i < 2; i++)
            //    {
            //        TaxCode += CUIT[i];
            //    }

            //    TaxCode += "-";

            //    for (int i = 2; i < 10; i++)
            //    {
            //        TaxCode += CUIT[i];
            //    }

            //    TaxCode += "-";
            //    TaxCode += CUIT[10];
            //}
        }

        public string GetDNI()
        {
            //string[] taxCodeArray = TaxCode.Split('-');

            //if (taxCodeArray.Length == 1)
            //{
            //    return taxCodeArray[0];
            //}

            //return taxCodeArray[1].TrimStart('0');
            return "";
        }

        public void SetDNI(string DNI)
        {
            //TaxCode = DNI;
        }

        public bool IsOrganization()
        {
            //string[] nameArray = Name.Split(',');
            //return nameArray.Length == 1;
            return false;
        }

        public bool IdentificationIsDNI()
        {
            //string[] taxCodeArray = TaxCode.Split('-');
            //return taxCodeArray.Length == 1 && TaxCode.Length <= 8;
            return false;
        }
    }
}
