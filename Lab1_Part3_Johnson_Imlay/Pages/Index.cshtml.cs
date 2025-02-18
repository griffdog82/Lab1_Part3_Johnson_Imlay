//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace Lab1_Part3_Johnson_Imlay.Pages
//{
//    public class IndexModel : PageModel
//    {
//        private readonly ILogger<IndexModel> _logger;

//        public IndexModel(ILogger<IndexModel> logger)
//        {
//            _logger = logger;
//        }

//        public void OnGet()
//        {

//        }
//    }
//}
using Lab1_Part3_Johnson_Imlay.Pages.DataClasses;
using Lab1_Part3_Johnson_Imlay.Pages.DB;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lab1_Part3_Johnson_Imlay.Pages
{
    public class IndexModel : PageModel
    {
        public List<User> UserList { get; set; }

        public IndexModel()
        {
            UserList = new List<User>();
        }

        public void OnGet()
        {
            SqlDataReader userReader = DBClass.UserReader();
            while (userReader.Read())
            {
                UserList.Add(new User
                {
                    UserID = int.Parse(userReader["UserID"].ToString()),
                    Username = userReader["Username"].ToString(),
                    Password = userReader["Password"].ToString(),
                    Email = userReader["Email"].ToString(),
                    FirstName = userReader["FirstName"].ToString(),
                    LastName = userReader["LastName"].ToString(),
                    UserType = userReader["UserType"].ToString(),
                    Department = userReader["Department"] as string,
                    AdminType = userReader["AdminType"] as string,
                    BusinessPartnerID = userReader["BusinessPartnerID"] as int?
                });
            }

            // Close the database connection
            DBClass.Lab1DBConnection.Close();
        }
    }
}
