using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    public class Tour : ICloneable, IComparable<Tour>, INotifyPropertyChanged
    {
        [DataMember]
        private DateTime _date;
        [DataMember]
        private int _cost;
        [DataMember]
        private List<Excursion> _excursions;

        public Tour(int cost, DateTime date, List<Excursion> excursions)
        {
            Cost = cost;
            Date = date;
            Excursions = excursions;
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        public int Cost
        {
            get { return _cost; }
            set
            {
                _cost = value;
                OnPropertyChanged("Cost");
            }
        }
        public List<Excursion> Excursions
        {
            get { return _excursions; }
            set
            {
                _excursions = value;
                OnPropertyChanged("Excursions");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void AddExcursions(Excursion excursion)
        {
            Excursions.Add(excursion);
        }

        public object Clone()
        {
            return new Tour(Cost, Date, Excursions);
        }

        public int CompareTo(Tour other)
        {
            if (other is null) throw new ArgumentNullException("Некоректне значення параметру");
            return Cost.CompareTo(other.Cost);
        }

        public void RemoveExcursions(Excursion excursion)
        {
            Excursions.Remove(excursion);
        }

        public override string ToString()
        {
            return $"Info\nDate:{string.Format("{0:dd/MM/yyyy}", Date)} \nCost:{Cost}\n{string.Join("\n", Excursions.Select(p => string.Join("\t", p)))}\n";
        }
    }
}