// using System;
// using System.Security.Cryptography;
// using System.Collections.Generic;
// using System.Collections;
// using System.Linq;
// using System.Net;
// using Microsoft.Extensions.Configuration;
// using System.Data.Common;
// using System.Reflection;

// class Program
// {

//     public static void Main()
//     {
//         Console.WriteLine("Get config content");

//         var builder = new ConfigurationBuilder()
//             .SetBasePath("C:/Users/woundmee/Desktop/c#-course/")
//             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//             .Build();

//             // var creds = builder.GetSection("credentials:zf:mz:password");
//             // Console.WriteLine(creds.Path);
            
//             var creds = new Credentials()
//             {
//                 zf = new Zf
//                 {
//                     mz = new Mz {
//                         user = builder["credentials:zf:mz:user"],
//                         password = builder["credentials:zf:mz:password"],
//                     },
//                     rt = new Rt {
//                         user = builder["credentials:zf:rt:user"],
//                         password = builder["credentials:zf:rt:password"],
//                     }
//                 }
//             };

//             Console.WriteLine(
//                 $"mz: username: {creds.zf.mz.user}, password: {creds.zf.mz.password}\n" + 
//                 $"rt: username: {creds.zf.rt.user}, password: {creds.zf.rt.password}"
//             );
//     }

//     public class Credentials
// {
//     public Zf? zf { get; set; }
// }

// public class Zf
// {
//     public Mz? mz { get; set; }
//     public Rt? rt { get; set; }
//     public Pesh? pesh { get; set; }
// }

// public class Mz
// {
//     public string? user { get; set; }
//     public string? password { get; set; }
// }

// public class Rt
// {
//     public string? user { get; set; }
//     public string? password { get; set; }
// }

// public class Pesh
// {
//     public string? user { get; set; }
//     public string? password { get; set; }
// }

// }