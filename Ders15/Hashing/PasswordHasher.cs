using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class PasswordHasher
    {
        // Parolayı Hashler ve Salt ile birlikte döner
        public static (string hash, string salt) HashPassword(string password)
        {
            // Random bir salt oluştur
            var saltBytes = GenerateSalt();
            var saltString = Convert.ToBase64String(saltBytes);

            // Salt'ı parola ile birleştir ve hashle
            var hashedPassword = HashWithSalt(password, saltBytes);
            
            return (hashedPassword, saltString);
        }
        
        // Parola ve salt ile hash oluştur
        private static string HashWithSalt(string password, byte[] saltBytes)
        {
            using (var sha256 = SHA256.Create())
            {
                // Parolayı ve salt'ı birleştir
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var passwordWithSalt = Combine(passwordBytes, saltBytes);

                // Hash oluştur
                var hashBytes = sha256.ComputeHash(passwordWithSalt);

                // Hash'i Base64 string olarak döndür
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Salt oluşturur
        private static byte[] GenerateSalt(int size = 16)
        {
            var salt = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        // İki byte array'i birleştirir
        private static byte[] Combine(byte[] first, byte[] second)
        {
            var combined = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, combined, 0, first.Length);
            Buffer.BlockCopy(second, 0, combined, first.Length, second.Length);
            return combined;
        }

        // Hash'in doğruluğunu kontrol eder
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var hashToVerify = HashWithSalt(password, saltBytes);

            return storedHash == hashToVerify;
        }
    }
}
