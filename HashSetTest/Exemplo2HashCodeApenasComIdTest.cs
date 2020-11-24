using System;
using System.Collections.Generic;
using Xunit;

namespace HashSetTest
{
    public class Exemplo2HashCodeApenasComIdTest
    {
        [Fact]
        [Trait("Equals", "Hash Code Apenas com Id")]
        public void DeveConsiderarInstanciaPrimeiraIgualOutrasDiferente()
        {
            var obj1 = new Exemplo2(0, new DateTime(2020, 1, 1), "ex1");
            var obj2 = new Exemplo2(0, new DateTime(2020, 2, 2), "ex2");
            Assert.Equal(obj1, obj2);

            obj1 = new Exemplo2(0, new DateTime(2020, 1, 1), "ex1");
            obj2 = new Exemplo2(1, new DateTime(2020, 1, 1), "ex1");
            Assert.NotEqual(obj1, obj2);
        }

        [Fact]
        public void DeveConsiderarObjetosDiferentesComIdDiferente()
        {
            var list = new List<IExemplo>
            {
                new Exemplo2(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo2(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo2(0, new DateTime(2020, 1, 1), "ex1")
            };

            Assert.Equal(3, list.Count);

            var hashSet = new HashSet<IExemplo>
            {
                new Exemplo2(0, new DateTime(2020, 1, 1), "ex1"),
                new Exemplo2(0, new DateTime(2020, 2, 2), "ex2"),
                new Exemplo2(0, new DateTime(2020, 3, 4), "ex3")
            };

            Assert.Single(hashSet);
        }
    }
}