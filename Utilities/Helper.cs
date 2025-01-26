using Interfaces;
using DomainModel;

namespace Utilities
{
    public static class Helper
    {
        public static T Instantiate<T>(object databaseId)
            where T : IIdentifiable, new()
        {
            int id = databaseId as int? ?? 0; // Convierte la columna en un entero o en 0 si es NULL

            if (0 < id)
            {
                T attribute = new T();
                attribute.Id = id;
                return attribute;
            }

            return default(T); // Devuelve null o el equivalente predeterminado en caso de ser un tipo de dato nativo
        }

        public static int GetId<T>(T attribute)
            where T : IIdentifiable
        {
            if (attribute != null)
            {
                return attribute.Id;
            }

            return 0;
        }

        public static void AssignLegalEntity<DestinyClass, OriginClass>(
            DestinyClass destinyObject,
            OriginClass originObject
        )
            where DestinyClass : LegalEntity, new()
            where OriginClass : LegalEntity, new()
        {
            destinyObject.Id = originObject.Id;
            destinyObject.CUIT = originObject.CUIT;
            destinyObject.Name = originObject.Name;
            destinyObject.Email = originObject.Email;
            destinyObject.Phone = originObject.Phone;
            destinyObject.LogoImage = originObject.LogoImage;
            destinyObject.Address = originObject.Address;

            if (originObject is InternalOrganization && destinyObject is InternalOrganization)
            {
                (destinyObject as InternalOrganization).ActivityStatus = (originObject as InternalOrganization).ActivityStatus;
                (destinyObject as InternalOrganization).AdmissionDate = (originObject as InternalOrganization).AdmissionDate;
                (destinyObject as InternalOrganization).PricingPlan = (originObject as InternalOrganization).PricingPlan;
            }
        }

        public static void AssignPerson<DestinyClass, OriginClass>(
            DestinyClass destinyObject,
            OriginClass originObject
        )
            where DestinyClass : Person, new()
            where OriginClass : Person, new()
        {
            destinyObject.Id = originObject.Id;
            destinyObject.DNI = originObject.DNI;
            destinyObject.CUIL = originObject.CUIL;
            destinyObject.FirstName = originObject.FirstName;
            destinyObject.LastName = originObject.LastName;
            destinyObject.Email = originObject.Email;
            destinyObject.Phone = originObject.Phone;
            destinyObject.BirthDate = originObject.BirthDate;
            destinyObject.ProfileImage = originObject.ProfileImage;
            destinyObject.Address = originObject.Address;

            if (originObject is Employee && destinyObject is Employee)
            {
                (destinyObject as Employee).ActivityStatus = (originObject as Employee).ActivityStatus;
                (destinyObject as Employee).AdmissionDate = (originObject as Employee).AdmissionDate;
            }

            if (originObject is User && destinyObject is User)
            {
                (destinyObject as User).Username = (originObject as User).Username;
                (destinyObject as User).Password = (originObject as User).Password;
                (destinyObject as User).Roles = (originObject as User).Roles;
            }
        }
    }
}
