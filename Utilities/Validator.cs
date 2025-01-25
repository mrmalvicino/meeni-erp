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

        public static void ValidateOrganizationName(string organizationName)
        {
            if (string.IsNullOrEmpty(organizationName))
            {
                throw new ValidationException("Nombre de la organización incompleto.");
            }
        }

        public static void ValidateFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ValidationException("Nombre incompleto.");
            }

            if (!HasOnlyLetters(firstName))
            {
                throw new ValidationException("El nombre solo puede contener letras.");
            }
        }

        public static void ValidateLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ValidationException("Apellido incompleto.");
            }

            if (!HasOnlyLetters(lastName))
            {
                throw new ValidationException("El apellido solo puede contener letras.");
            }
        }

        public static void ValidateDNI(string DNI)
        {
            if (!IsNumber(DNI))
            {
                throw new ValidationException("El DNI solo puede contener números.");
            }

            if (DNI.Length != 8)
            {
                throw new ValidationException("El DNI debe tener 8 dígitos.");
            }
        }

        public static void ValidateCUIT(string CUIT)
        {
            if (!IsNumber(CUIT))
            {
                throw new ValidationException("El CUIT solo puede contener números.");
            }

            if (CUIT.Length != 11)
            {
                throw new ValidationException("El CUIT debe tener 11 dígitos.");
            }
        }

        public static void ValidateCUIL(string CUIL)
        {
            if (!IsNumber(CUIL))
            {
                throw new ValidationException("El CUIL solo puede contener números.");
            }

            if (CUIL.Length != 11)
            {
                throw new ValidationException("El CUIL debe tener 11 dígitos.");
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
