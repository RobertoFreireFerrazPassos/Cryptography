using AsymmetricEncryption.Example;
using FluentAssertions;
using System.Security.Cryptography;
using Xunit;

namespace AsymmetricEncryption.Test
{
    public class AsymmetricEncryptionTest
    {
        [Fact]
        public void MustEncryptAndDecrypt()
        {
            //var publicKey = "b14ca5898a4e4133bbce2ea2315a1916";
            //var privateKey = "83mfSuh9R13Xa5aFASDFfnm133e413bb";

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            
            string publicKey = rsa.ToXmlString(false); // false to get the public key   
            string privateKey = rsa.ToXmlString(true); // true to get the private key   

            var str = "string test";

            var encryptedString = RSAOperation.Encrypt(publicKey, str);

            var decryptedString = RSAOperation.Decrypt(privateKey, encryptedString);

            decryptedString.Should().Be(str);
        }
    }
}