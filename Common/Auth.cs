using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using Angular2CoreMVC.Models;
namespace Common
{
    public class Auth
    {
        public const string SessionAuth = "auth";
        private System.Collections.Generic.List<Users> AuthAccount = new System.Collections.Generic.List<Users>();
        public HttpContext httpContext;
        public Auth(System.Collections.Generic.List<Users> account)
        {
            httpContext.Session.SetString(SessionAuth, Newtonsoft.Json.JsonConvert.SerializeObject(account));
            var ss = httpContext.Session.GetString(SessionAuth);
            AuthAccount = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<Users>>(ss);
        }
        public System.Collections.Generic.List<Users> getUser()
        {
            try
            {
                return (AuthAccount.Count > 0 ? AuthAccount : null);
            }
            catch { return null; }
        }
        public bool isAuth()
        {
            if (httpContext.Session.Get(SessionAuth) != null)
                return true;
            return false;
        }
        public bool inRoles(string[] r)
        {
            if (r.Contains(""))
                return true;
            return false;
        }
        public void logout()
        {
            try { httpContext.Session.SetString(SessionAuth, null); }
            catch { return; }
        }
    }
    public class AuthStatic
    {
        //public static System.Guid id = Guid.Parse("f4191f70-2c4a-442e-a62d-b4b6833b33f4");
        //public const string username = "tuanmjnh";
        //public const string password = "aa2de065c899d53d7031b0975c56062f";//"Tuanmjnh@tm"; //"fc44d0279133a2f46178134ce9bf2167";//tuanmjnh@123
        //public const string salt = "1c114c58-69d9-41e6-bd3e-363906e04e50";
        //public const string full_name = "SuperAdmin";
        //public const string mobile = "0123456789";
        //public const string email = "SuperAdmin@SuperAdmin.com";
        //public const string address = "SuperAdmin";
        //public const string roles = Common.roles.superadmin;
        //public const string created_by = "f4191f70-2c4a-442e-a62d-b4b6833b33f4";
        //public const string created_at = DateTime.Now;
        //public const string updated_by = "f4191f70-2c4a-442e-a62d-b4b6833b33f4";
        //public const string updated_at = "SuperAdmin";
        ////public const string last_login = "SuperAdmin";
        //public const int flag = 1;
        //public static bool isAuthStatic(string username, string password)
        //{
        //    if (AuthStatic.username == username && AuthStatic.password == TM.Encrypt.CryptoMD5TM(password + AuthStatic.salt))
        //        return true;
        //    return false;
        //}
    }
    public class roles
    {
        public const string superadmin = "187eb627-0a7b-44a8-83c4-ceb4829709a3";
        public const string admin = "ee82e7f1-592c-4f5c-95fa-7cad30b14a2d";
        public const string mod = "238391cd-990d-4f3b-8d0c-0300416f9263";
        public const string director = "121ab8e5-1ad2-4b78-8ff2-4d953c9b71a8";
        public const string leader = "d0443498-09c4-4267-a7c9-2a20dde8e925";
        public const string staff = "dc67601d-ad74-4813-8293-8d4a07db1d31";
    }
}
