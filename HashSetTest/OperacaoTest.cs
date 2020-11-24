using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace HashSetTest
{
    public class OperacaoTest
    {
        private static Produtor ObterProdutor()
        {
            var produtor = new Produtor
            {
                List = new List<IExemplo>
                {
                    new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                    new ExemploVo(0, new DateTime(2020, 1, 1), "ex1"),
                    new ExemploVo(0, new DateTime(2020, 1, 1), "ex1")
                },
                HashSet = new List<IExemplo>
                {
                    new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                    new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                    new Exemplo1(0, new DateTime(2020, 1, 2), "ex1"),
                    new Exemplo1(0, new DateTime(2020, 1, 1), "ex1"),
                    new Exemplo1(0, new DateTime(2020, 1, 1), "ex2"),
                },
                HashSetById = new List<IExemplo>
                {
                    new Exemplo2(0, new DateTime(2020, 1, 1), "ex1"),
                    new Exemplo2(0, new DateTime(2020, 1, 1), "ex2"),
                    new Exemplo2(0, new DateTime(2020, 1, 2), "ex1"),
                    new Exemplo2(1, new DateTime(2020, 1, 1), "ex1"),
                    new Exemplo2(2, new DateTime(2020, 1, 1), "ex1"),
                }
            };

            return produtor;
        }

        [Fact]
        public void ConsumidorProdutorTest()
        {
            var produtor = ObterProdutor();

            var consumidor = JsonConvert.DeserializeObject<Consumidor>(produtor.ToString());

            Assert.Equal(3, consumidor.List.Count);
            Assert.Equal(3, consumidor.HashSet.Count);
            Assert.Equal(3, consumidor.HashSetById.Count);
        }

        [Fact]
        public void GerarArquivos()
        {
            var directory = @"..\..\..\Resultados\";

            var produtor = ObterProdutor();
            var pathProdutor = $"{directory}{nameof(produtor)}.json";
            GerarArquivo(produtor.ToString(), pathProdutor);

            var consumidor = JsonConvert.DeserializeObject<Consumidor>(produtor.ToString());
            var pathConsumidor = $"{directory}{nameof(consumidor)}.json";
            GerarArquivo(consumidor.ToString(), pathConsumidor);

            Assert.True(File.Exists(pathProdutor));
            Assert.True(File.Exists(pathConsumidor));
        }

        private static void GerarArquivo(string conteudo, string pathConsumidor)
        {
            if (File.Exists(pathConsumidor))
            {
                File.Delete(pathConsumidor);
            }

            File.WriteAllText(pathConsumidor, conteudo);
        }
    }
}