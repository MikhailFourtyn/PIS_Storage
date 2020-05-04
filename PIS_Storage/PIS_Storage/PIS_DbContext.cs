using System;
using System.Data.Entity;

namespace PIS_Storage
{
    public class PIS_DbContext : DbContext
    {
        public PIS_DbContext() : base("DbConnectionString")
        {

        }
    }
}
