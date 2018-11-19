using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            ftp ftpClient = new ftp(@"ftp://192.168.1.149/", "user-ftp", "1234");
            ftpClient.download("/2/pass.txt", @"D:\downloaded\passfromftp.txt");
        }
    }
}
