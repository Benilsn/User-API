using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace User_API.services.auth
{
    public class PasswordHasher
    {
        
        internal protected static string Hash(string password)
        {

            byte[] salt = new byte[128 / 8];

            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }


            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(

                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;

        }
    }
}
