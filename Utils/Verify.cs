using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using MVCSoftwareSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MVCSoftwareSite.DBs
{
    public class Verify
    {
        public bool VerifySession(string SessionId, SoftwareSiteDb _db) {
            if (SessionId.IsNullOrEmpty())
            {
                return false;
            } else
            {                
                return _db.Sessions.Where(x => x.Id == SessionId).ToList().Count != 0;
            }
        }
    }
}
