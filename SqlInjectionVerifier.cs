using System.Text.RegularExpressions;

namespace TesteAPI
{
    public static class SqlInjectionVerifier
    {
        private static readonly string[] SqlInjectionPatterns = { "char", "nchar", "varchar", "nvarchar", "alter", "begin", "cast", "create", "cursor", "declare", "delete", "drop", "end", "exec", "execute", "fetch", "insert", "kill", "open", "select", "sys", "sysobjects", "syscolumns", "table", "update", "commit", "rollback" };

        public static bool ContainsSqlInjection(this string input)
        {
            string pattern = string.Format(@"\b({0})\b", string.Join("|", SqlInjectionPatterns));

            return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        public static bool ContainsSqlInjection(this object obj)
        {
            var properties = obj.GetType().GetProperties().Where(p => p.PropertyType == typeof(string));

            foreach (var property in properties)
            {
                string value = property.GetValue(obj) as string;
                if (value != null && ContainsSqlInjection(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
