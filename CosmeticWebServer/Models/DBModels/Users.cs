using System;
using System.Collections.Generic;

namespace CosmeticWebServer.Models.DBModels
{
    public partial class Users
    {
        public int IdUsers { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string UserPw { get; set; }
        public string Authority { get; set; }
    }
}
