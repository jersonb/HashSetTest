using System;

namespace HashSetTest
{
    public sealed class Exemplo2 : Exemplo, IEquatable<Exemplo2>
    {
        public Exemplo2(int id, DateTime data, string nome) : base(id, data, nome)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Exemplo2);
        }

        public bool Equals(Exemplo2 other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}