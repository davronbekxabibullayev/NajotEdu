using NajotEdu.Application.Abstraction;
using System.Security.Cryptography;
using System.Text;

namespace NajotEdu.Infrastructure.Providers
{
    public class HashProvider : IHashProvider
    {
        public string GetHash(string value)
        {
            const string peper = "NajotTalimQalampir";
            const int keySize = 64;
            const int iterations = 350000;

            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            var salt = new byte[keySize]; // bu yerda saltni biz uzgarmas qilib quydik aslida
                                          // kegingi qatordagi kabi bulishi va u ham 1 ta proporty
                                          // qilib alohid columnda saqlab olishimiz va unga ham
                                          // alohida tekshiruv quyishmiz kerak.

            //var salt = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(value),
                salt,
                iterations,
                hashAlgorithm,
                keySize);

            return Convert.ToHexString(hash) + peper;
        }
    }
}
