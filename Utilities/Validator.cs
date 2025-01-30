using Exceptions;
using System;
using System.Linq;
using System.Net;

namespace Utilities
{
    public static class Validator
    {
        public static bool URLExists(string URL)
        {
            if (Uri.TryCreate(URL, UriKind.Absolute, out Uri uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriResult);
                    request.Method = "HEAD";
                    request.Timeout = 5000;

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        return response.StatusCode == HttpStatusCode.OK;
                    }
                }
                catch (WebException)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int CountFilledStrings(object obj)
        {
            if (obj == null)
            {
                return 0;
            }

            int count = 0;

            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(string))
                {
                    var value = (string)prop.GetValue(obj);

                    if (!string.IsNullOrEmpty(value))
                    {
                        count++;
                    }
                }
                else if (!prop.PropertyType.IsPrimitive
                    && !prop.PropertyType.IsEnum
                    && prop.PropertyType != typeof(string))
                {
                    var subObj = prop.GetValue(obj);
                    count += CountFilledStrings(subObj);
                }
            }

            return count;
        }

        public static bool IsEmpty(object obj)
        {
            return CountFilledStrings(obj) == 0;
        }

        public static bool IsNumber(string text)
        {
            foreach (char c in text)
            {
                if (!(char.IsNumber(c)))
                {
                    return false;
                }
            }

            return true;
        }

        public static string RemoveSpaces(string text)
        {
            string temp = "";

            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    temp += c;
                }
            }

            return temp;
        }

        public static bool HasSpaces(string text)
        {
            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool HasOnlyLetters(string text)
        {
            foreach (char c in RemoveSpaces(text))
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthDate.Year;

            if (today.AddYears(-age) < birthDate.Date)
            {
                age--;
            }

            return age;
        }

        public static void ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ValidationException("Nombre de usuario incompleto.");
            }

            if (username.Length < 4)
            {
                throw new ValidationException("El nombre de usuario debe tener al menos 4 caracteres.");
            }

            if (HasSpaces(username))
            {
                throw new ValidationException("El nombre de usuario no puede contener espacios.");
            }
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ValidationException("Contraseña incompleta.");
            }

            bool hasValidLength = password.Length >= 8 && password.Length <= 20;

            if (!hasValidLength)
            {
                throw new ValidationException("La contraseña debe tener entre 8 y 20 caracteres.");
            }

            bool hasNumber = password.Any(char.IsDigit);

            if (!hasNumber)
            {
                throw new ValidationException("La contraseña debe contener al menos un número.");
            }

            bool hasLetter = password.Any(char.IsLetter);

            if (!hasLetter)
            {
                throw new ValidationException("La contraseña debe contener al menos una letra.");
            }
        }

        public static void ValidateEntityName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationException("Nombre de la organización incompleto.");
            }
        }

        public static void ValidateTaxCode(string taxCode)
        {
            string[] taxCodeArray = taxCode.Split('-');

            if (taxCodeArray.Length == 1)
            {
                if (!IsNumber(taxCode))
                {
                    throw new ValidationException("El código fiscal solo puede contener números.");
                }

                if (taxCode.Length < 8)
                {
                    throw new ValidationException("El DNI es inválido.");
                }

                if (8 < taxCode.Length && taxCode.Length != 11)
                {
                    throw new ValidationException("El CUIT/CUIL es inválido.");
                }
            }
            else if (taxCodeArray.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!IsNumber(taxCodeArray[i]))
                    {
                        throw new ValidationException("El CUIT/CUIL solo puede contener números.");
                    }
                }

                if (taxCodeArray[0].Length != 2 || taxCodeArray[1].Length != 8 || taxCodeArray[2].Length != 1)
                {
                    throw new ValidationException("El CUIT/CUIL es inválido.");
                }
            }
            else
            {
                throw new ValidationException("El código fiscal es inválido.");
            }
        }

        public static void ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ValidationException("Email inválido.");
            }
        }

        public static void ValidatePhone(string phone)
        {
            if (!IsNumber(phone))
            {
                throw new ValidationException("El teléfono solo puede contener números.");
            }

            if (phone.Length < 8)
            {
                throw new ValidationException("El teléfono debe tener al menos 8 dígitos.");
            }
        }

        public static void ValidateBirthDate(DateTime birthDate)
        {
            if (CalculateAge(birthDate) <= 0)
            {
                throw new ValidationException("La fecha de nacimiento no puede ser en el futuro.");
            }

            if (CalculateAge(birthDate) < 18)
            {
                throw new ValidationException("La fecha de nacimiento no es válida porque no es posible registrar menores de 18 años.");
            }
        }

        public static void ValidateURL(string URL)
        {
            if (!URLExists(URL))
            {
                throw new ValidationException("La URL de la imagen no es válida.");
            }
        }

        public static void ValidateStreetName(string streetName)
        {
            if (string.IsNullOrEmpty(streetName))
            {
                throw new ValidationException("Calle incompleta.");
            }

            if (streetName.Length < 4)
            {
                throw new ValidationException("Calle incompleta.");
            }
        }

        public static void ValidateStreetNumber(string streetNumber)
        {
            if (string.IsNullOrEmpty(streetNumber))
            {
                throw new ValidationException("Número de domicilio incompleto.");
            }

            if (!IsNumber(streetNumber))
            {
                throw new ValidationException("El número de domicilio solo puede contener números.");
            }
        }

        public static void ValidateCountryName(string countryName)
        {
            if (string.IsNullOrEmpty(countryName))
            {
                throw new ValidationException("Nombre del país incompleto.");
            }
        }

        public static void ValidateProvinceName(string provinceName)
        {
            if (string.IsNullOrEmpty(provinceName))
            {
                throw new ValidationException("Nombre de la provincia incompleto.");
            }
        }

        public static void ValidateCityName(string cityName)
        {
            if (string.IsNullOrEmpty(cityName))
            {
                throw new ValidationException("Nombre de la ciudad incompleto.");
            }
        }
    }
}
