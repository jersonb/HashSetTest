using System;
using System.Collections.Generic;
using Xunit;

namespace HashSetTest
{
    public class Exemplo1HashCodeComTodasPropriedadesTest
    {
        [Fact]
        [Trait("Equals", "Hash Code com todas as Propriedadas")]

        public void DeveConsiderarInstanciaPrimeiraIgualOutrasDiferente()
        {
            var obj1 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex1");
            var obj2 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex1");
            Assert.Equal(obj1, obj2);

            obj1 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex1");
            obj2 = new Exemplo1(0, new DateTime(2020, 2, 1), "ex1");
            Assert.NotEqual(obj1, obj2);

            obj1 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex1");
            obj2 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex2");
            Assert.NotEqual(obj1, obj2);

            obj1 = new Exemplo1(0, new DateTime(2020, 1, 1), "ex1");
            obj2 = new Exemplo1(1, new DateTime(2020, 1, 1), "ex1");
            Assert.NotEqual(obj1, obj2);
        }

        [Fact]
        public void DeveConsiderarObjetosDiferentesComQualquePropriedadeDiferente()
        {
            var list = new List<IExemplo>
            {
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex1")
            };

            Assert.Equal(3, list.Count);

            var hashSet = new HashSet<IExemplo>
            {
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 2), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 2), "ex1"),
                new Exemplo1(0, new DateTime(2020, 1, 1), "ex2")
            };

            Assert.Equal(3, hashSet.Count);
        }
    }
}