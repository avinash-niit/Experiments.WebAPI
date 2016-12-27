using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace Experiments.WebAPI.Common
{
    public class TempCacher
    {
        public static object Get(string key) {
            return MemoryCache.Default[key];
        }

        public static void Add(string key, object value){
            MemoryCache.Default.Add(key, value, DateTimeOffset.Now.AddHours(1));
        }

        public static void Delete(string key) {
            MemoryCache.Default.Remove(key);
        }
    }
}