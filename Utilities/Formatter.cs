namespace Utilities
{
    public static class Formatter
    {
        public static string FormatIdentificationCode(string code)
        {
            string[] arr = code.Split('-');

            if (code.Length == 13 && arr.Length == 3)
            {
                return code;
            }

            if (code.Length == 11 && arr.Length == 1)
            {
                string CUIT = "";

                for (int i = 0; i < 2; i++)
                {
                    CUIT += code[i];
                }

                CUIT += "-";

                for (int i = 2; i < 10; i++)
                {
                    CUIT += code[i];
                }

                CUIT += "-";
                CUIT += code[10];

                return CUIT;
            }

            return code;
        }
    }
}
