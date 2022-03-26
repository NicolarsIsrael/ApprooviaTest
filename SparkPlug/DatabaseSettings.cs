using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
       string ConnectionString { get; set; }
         string CollectionName { get; set; }
         string DatabaseName { get; set; }
    }
}
