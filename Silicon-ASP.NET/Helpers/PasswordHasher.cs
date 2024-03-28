//using System.Security.Cryptography;
//using System.Text;

//namespace Infrastructure.Helpers;

//public class PasswordHasher
//{
//    public static (string, string) GenerateSecurePassword(string password)
//    {
//        using var hmac = new HMACSHA512();
//        var securitykey = hmac.Key;
//        var hashPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

//        return (Convert.ToBase64String(securitykey),  Convert.ToBase64String(hashPassword));
//    }

//    public static bool ValidateSecurePassword(string password, string hash, string securitykey)
//    {
//        using var hmac = new HMACSHA512(Convert.FromBase64String(securitykey));

//        var hashedPassword = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));

//        var userPassword = Convert.FromBase64String(hash);

//        for (var i = 0;  i < hashedPassword.Length; i++)
//        {
//            if (hashedPassword[i] != hash[i])
//                return false;
//        }
//        return true;

//    }
//}
