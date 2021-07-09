using SqlServerLibrary;
using System;

namespace SqlServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            SqlServerLib ssl = new SqlServerLib();

            ssl.Connect("localhost\\sqlexpress", "prs");

             var vendor = ssl.VendorGetByPK(5);
             vendor.Phone = "999";
             vendor.Email = "test@system.com";
             var rc = ssl.VendorChange(vendor);
             Console.WriteLine($"The change {(rc ? "worked!" : "failed!")}");


          //  var newVendor = new Vendor()
          //  {
          //      Id = 0,
           //     Code = "XX",
           //     Name = "XX",
           //     Address = "XX",
           //     City = "XX",
           //     State = "XX",
           //     Zip = "XX",
           //     Phone = "XXXXX",
           //     Email = "XXX@XX"
          //  };
           // ssl.VendorCreate(newVendor);


            // var vendor = ssl.VendorGetByPK(2);

            //var vendors = ssl.VendorGetAll();

            //var user = ssl.UserGetByPK(8);
            // user.Phone = "999";
            // user.Email = "test@system.com";
            // var rc = ssl.UserChange(user);
            // Console.WriteLine($"The change {(rc ?"worked!" : "failed!")}");

            // var newUser = new User()
            // {
            //   Id = 0,
            //   Username = "XX",
            //   Password = "XX",
            //   FirstName = "XX",
            //   LastName = "XX",
            //   Phone = "XX",
            //   Email = "XX",
            //   Reviewer = false,
            //   Admin = false
            // };
            // ssl.UserCreate(newUser);

            //var user = ssl.UserGetByPK(3);

            // var users = ssl.UserGetAll();


            ssl.Disconnect();


        }
    }
}
