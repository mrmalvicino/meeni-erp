using Interfaces;

namespace Utilities
{
    public static class Helper
    {
        public static T InstantiateNull<T>(object databaseId)
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
    }

}
