using System;

namespace HashSetTest
{
    public sealed class Exemplo1 : Exemplo, IEquatable<Exemplo1>
    {
        public Exemplo1(int id, DateTime data, string nome) : base(id, data, nome)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Exemplo1);
        }

        public bool Equals(Exemplo1 other)
        {
            return other != null &&
                   Id == other.Id &&
                   Data == other.Data &&
                   Nome == other.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Data, Nome);
        }
    }
}