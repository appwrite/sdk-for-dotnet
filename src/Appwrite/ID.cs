namespace Appwrite
{
    public static class ID
    {
        public static string Unique()
        {
            return "unique()";
        }

        public static string Custom(string id)
        {
            return id;
        }
    }
}