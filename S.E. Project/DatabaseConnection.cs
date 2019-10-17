using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace S.E.Project
{
    class DatabaseConnection
    {
        static string conString = "Server = localhost; Uid = root; Password =  ; Database = church_sched_track; SslMode = none;";
        public MySqlConnection con = new MySqlConnection(conString);
        public static string lblCurName;
        public static string lblCurRole;
        public static string currStaff;      
        public static Boolean adding;
        public static Boolean updating;
        public static string curEvent;

        //for the event
        public static string eventID;
        public static string eventName;
        public static string eventDesc;

        //for the applicant
        public static string appID;
        public static string applName;
        public static string appfName;
        public static string appMI;
        public static string appAdd;

        //for the requirement
        public static string reqName;
        public static string reqDesc;
        public static string reqType;


        public int val(string str)
        {
            int ans = 0;
            string res = "";
            foreach (char x in str)
            {
                if (char.IsDigit(x))
                {
                    res = res + x.ToString();
                }
            }
            ans = int.Parse(res);
            return ans;
        }

    }
}
