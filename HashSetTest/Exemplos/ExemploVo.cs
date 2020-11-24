using System;

namespace HashSetTest
{
    public sealed class ExemploVo : IExemplo
    {
        public ExemploVo(int id, DateTime data, string nome)
        {
            Id = id;
            Data = data;
            Nome = nome;
        }

        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string Nome { get; set; }
    }
}