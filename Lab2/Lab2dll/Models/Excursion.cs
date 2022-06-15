using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    public class Excursion : ICloneable, IComparable<Excursion>, INotifyPropertyChanged
    {
        [DataMember]
        private Organizer _organizer;
        [DataMember]
        private string _place;
        [DataMember]
        private FormConductorType _formConductorType;

        public Excursion(Organizer organizer, string place, FormConductorType formConductor)
        {
            Organizer = organizer;
            Place = place;
            FormConductor = formConductor;
        }
        public Organizer Organizer
        {
            get { return _organizer; }
            set
            {
                _organizer = value;
                OnPropertyChanged("Organizer");
            }
        }
        public string Place
        {
            get { return _place; }
            set
            {
                _place = value;
                OnPropertyChanged("Place");
            }
        }
        public FormConductorType FormConductor
        {
            get { return _formConductorType; }
            set
            {
                _formConductorType = value;
                OnPropertyChanged("FormConductor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

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
