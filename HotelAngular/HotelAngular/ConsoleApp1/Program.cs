// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");


string Hash(string password)
{
    using (var sha256 = SHA256.Create())
    {
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

        var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        return hash;
    }
}

var pass = Hash("test");
var t = 1;