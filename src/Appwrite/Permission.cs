namespace Appwrite
{
    public static class Permission
    {
        public static string Read(string role)
        {
            return $"read(\"{role}\")";
        }

        public static string Write(string role)
        {
            return $"write(\"{role}\")";
        }

        public static string Create(string role)
        {
            return $"create(\"{role}\")";
        }

        public static string Update(string role)
        {
            return $"update(\"{role}\")";
        }

        public static string Delete(string role)
        {
            return $"delete(\"{role}\")";
        }
    }
}
