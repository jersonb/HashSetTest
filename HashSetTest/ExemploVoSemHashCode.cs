using System;
using System.Collections.Generic;
using Xunit;

namespace HashSetTest
{
    public class ExemploVoSemHashCode
    {
        [Fact]
        [Trait("Equals","Sem HashCode")]
        public void TodosDevemSerDiferentes()
        {
            var obj1 = new ExemploVo(0, new DateTime(2020, 1, 1), "ex1");
            var obj2 = new ExemploVo(0, new DateTime(2020, 1, 1), "ex1");
            Assert.NotEqual(obj1, obj2);
        }

        [Fact]
        public void DeveConsiderarObjetosDiferentesMesmoComTodasPropriedadesIguais()
        {
            var list = new List<IExemplo>
            {
                new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                new ExemploVo(0, new DateTime(2020, 1, 1), "ex1")
            };

            Assert.Equal(3, list.Count);

            var hashSet = new HashSet<IExemplo>
            {
                new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                new ExemploVo(0, new DateTime(2020, 1, 2), "ex1")
            };

            Assert.Equal(3, hashSet.Count);
        }
    }
}