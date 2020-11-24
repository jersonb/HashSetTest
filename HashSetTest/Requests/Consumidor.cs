using Newtonsoft.Json;
using System.Collections.Generic;

namespace HashSetTest
{
    public class Consumidor
    {
        public string Id { get; set; }
        public List<ExemploVo> List { get; set; }
        public HashSet<Exemplo1> HashSet { get; set; }
        public HashSet<Exemplo2> HashSetById { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}