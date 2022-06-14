using System;
using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    public class Excursion : ICloneable, IComparable<Excursion>
    {
        public Excursion(Organizer organizer, string place, FormConductorType formConductor)
        {
            Organizer = organizer;
            Place = place;
            FormConductor = formConductor;
        }
        [DataMember]
        public Organizer Organizer { get; private set; }
        [DataMember]
        public string Place { get; private set; }
        [DataMember]
        public FormConductorType FormConductor { get; private set; }

        public object Clone()
        {
            return new Excursion(Organizer, Place, FormConductor);
        }

        public int CompareTo(Excursion other)
        {
            if (other is null) throw new ArgumentNullException("Некоректне значення параметру");
            return Organizer.CompareTo(other.Organizer);
        }
        public override int GetHashCode()
        {
            return (Organizer.GetHashCode() * 17 + Place.GetHashCode()) * 17 + FormConductor.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FormConductor} with {Organizer} in {Place}";
        }
    }
}
