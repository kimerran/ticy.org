using System.Linq;
using HashidsNet;

namespace Ticy.Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ConvertToHash(this int id, string salt = "ticy.likja.com")
        {
            var saltString = salt;

            var hashId = new Hashids(saltString, 6);

            return hashId.Encode(id);
        }

        public static int ConvertToInt(this string hashid, string salt = "ticy.likja.com")
        {
            var saltString = salt;

            var hashId = new Hashids(saltString, 6);

            var decoded =  hashId.Decode(hashid).ToList();

            if (decoded.Any()) {
                return decoded.FirstOrDefault();
            }
            return 0;
        }
    }
}
