using System.Data.SqlClient;

namespace Lab1_Part3_Johnson_Imlay.Pages.DB
{
    public class DBClass
    {
        // Use this class to define methods that make connecting to
        // and retrieving data from the DB easier.

        // Connection Object at Data Field Level
        public static SqlConnection Lab1DBConnection = new SqlConnection();

        // Connection String - How to find and connect to DB
        private static readonly String? Lab1DBConnString = 
            "Server=Localhost;Database=Lab1;Trusted_Connection=True";

        //Connection Methods:

        //Basic Product Reader

        //Leave alone for now, no need to overhaul. Maybe on Capstone
        public static SqlDataReader UserReader()
        {
            SqlCommand cmdProductRead = new SqlCommand();
            cmdProductRead.Connection = Lab1DBConnection;
            cmdProductRead.Connection.ConnectionString = Lab1DBConnString;
            cmdProductRead.CommandText = "SELECT * FROM [User]";
            cmdProductRead.Connection.Open(); // Open connection here, close in Model!

            SqlDataReader tempReader = cmdProductRead.ExecuteReader();

            return tempReader;
        }
        public static SqlDataReader BusinessPartnerReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BusinessPartner", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all Grants
        public static SqlDataReader GrantReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Grant]", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all GrantTeam records
        public static SqlDataReader GrantTeamReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GrantTeam", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all Projects
        public static SqlDataReader ProjectReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Project", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all ProjectAssignments
        public static SqlDataReader ProjectAssignmentReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProjectAssignment", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all Tasks
        public static SqlDataReader TaskReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Task", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all MeetingMinutes
        public static SqlDataReader MeetingMinuteReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MeetingMinute", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }

        // Retrieve all Messages
        public static SqlDataReader MessageReader()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Message", Lab1DBConnection);
            cmd.Connection.Open();
            SqlDataReader tempReader = cmd.ExecuteReader();
            return tempReader;
        }
    }
}