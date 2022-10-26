using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Common
{
    internal static class UserCache
    {
        #region Props
        public static int UserID { set; get; }
        public static int RoleID { get; set; }
        public static String UserName { get; set; }
        public static String Name { get; set; }
        public static String LastName { get; set; }
        public static String Email { get; set; }
        public static String Mobile { get; set; }
        public static bool isLockedOut { get; set; }
        public static DateTime CreateDate { get; set; }
        public static DateTime LastActivityDate { get; set; }
        public static int FailedPasswordAttemptCount { get; set; }
        #endregion
    }
}