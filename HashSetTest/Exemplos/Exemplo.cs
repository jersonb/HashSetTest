using System;

namespace HashSetTest
{
    public abstract class Exemplo : IExemplo
    {
        protected Exemplo(int id, DateTime data, string nome)
        {
            Id = id;
            Data = data;
            Nome = nome;
        }

        public Exemplo(IExemplo exemplo)
        {
        }

        public int Id { get; }

        public DateTime Data { get; }

        public string Nome { get; }
    }
}