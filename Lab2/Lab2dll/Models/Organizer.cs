using System;
using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    public class Organizer : ICloneable, IComparable<Organizer>
    {
        public Organizer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public string Surname { get; private set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode() * 17 + Surname.GetHashCode();
        }

        public object Clone()
        {
            return new Organizer(Name, Surname);
        }

        public int CompareTo(Organizer other)
        {
            if (other is null) throw new ArgumentNullException("Некоректне значення параметру");
            return other.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Organizer {Name} {Surname}";
        }
    }
}