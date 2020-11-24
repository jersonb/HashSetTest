using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HashSetTest
{
    public class Produtor
    {
        public string Id => Guid.NewGuid().ToString();

        public List<IExemplo> List { get; set; }
        public List<IExemplo> HashSet { get; set; }
        public List<IExemplo> HashSetById { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}