using Likja.Conthread;

namespace Ticy.Web.Common
{
    public static class ViewHelper
    {
        public static string ConvertToHash(int id)
        {
            return id.ConvertToHash(Constants.HASH_SALT);
        }

        public static int ConvertToId(string hash)
        {
            return hash.ConvertToInt(Constants.HASH_SALT);
        }
    }
}