using System;                             
using System.Security.Cryptography;      
using System.Text;                       

namespace BookHub.Models
{
   
    public static class CryptoHelper
    {
        /// <summary>
        /// Descriptografa a senha do usuario.
        /// </summary>
        /// <param name="encryptedBase64">
        /// </param>
       
        public static string Decrypt(string encryptedBase64)
        {
            // Se nulo ou vazio, ignora
            if (string.IsNullOrEmpty(encryptedBase64))
                return string.Empty;

           
            byte[] cipherBytes = Convert.FromBase64String(encryptedBase64);

            byte[] plainBytes = ProtectedData.Unprotect(
                cipherBytes,
                null,
                DataProtectionScope.CurrentUser
            );

            return Encoding.UTF8.GetString(plainBytes);
        }

    }
}
