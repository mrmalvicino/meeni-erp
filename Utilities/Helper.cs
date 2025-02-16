﻿using Interfaces;
using DomainModel.Base;
using DomainModel.Organizations;
using DomainModel.Stakeholders;
using DomainModel.Users;

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

        public static void AssignEntity<DestinyClass, OriginClass>(
            DestinyClass destinyObject,
            OriginClass originObject
        )
            where DestinyClass : Entity, new()
            where OriginClass : Entity, new()
        {
            destinyObject.Id = originObject.Id;
            destinyObject.Name = originObject.Name;
            destinyObject.IsOrganization = originObject.IsOrganization;
            destinyObject.Email = originObject.Email;
            destinyObject.Phone = originObject.Phone;
            destinyObject.BirthDate = originObject.BirthDate;
            destinyObject.Image = originObject.Image;
            destinyObject.Address = originObject.Address;
            destinyObject.Identification = originObject.Identification;

            if (originObject is Organization && destinyObject is Organization)
            {
                (destinyObject as Organization).ActivityStatus = (originObject as Organization).ActivityStatus;
                (destinyObject as Organization).AdmissionDate = (originObject as Organization).AdmissionDate;
                (destinyObject as Organization).PricingPlan = (originObject as Organization).PricingPlan;
            }

            if (originObject is Partner && destinyObject is Partner)
            {
                (destinyObject as Partner).ActivityStatus = (originObject as Partner).ActivityStatus;
                (destinyObject as Partner).IsClient = (originObject as Partner).IsClient;
                (destinyObject as Partner).IsSupplier = (originObject as Partner).IsSupplier;
            }

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
