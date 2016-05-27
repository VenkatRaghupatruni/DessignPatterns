using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;




namespace Sample
{
    class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        static void Main(string[] args)
        {
            string password = "some string";

            var data = Encoding.ASCII.GetBytes(password);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);

            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(data);


            /* To Store a Password
1.Generate a long random salt using a CSPRNG.
2.Prepend the salt to the password and hash it with a standard cryptographic hash function such as SHA256.
3.Save both the salt and the hash in the user's database record.

To Validate a Password
1.Retrieve the user's salt and hash from the database.
2.Prepend the salt to the given password and hash it using the same hash function.
3.Compare the hash of the given password with the hash from the database. If they match, the password is correct. Otherwise, the password is incorrect.
*/


            var hashedPassword = Encoding.ASCII.GetString(sha1data);
            var hashedPassword2 = Encoding.ASCII.GetString(md5data);

            
            Console.WriteLine(hashedPassword);
            Console.WriteLine(hashedPassword2);
            Console.Read();
        }


    }
}
