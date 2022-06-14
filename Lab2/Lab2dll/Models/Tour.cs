using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2dll
{
    public class Tour : ICloneable, IComparable<Tour>
    {
        public Tour(int cost, DateTime date, List<Excursion> excursions)
        {
            Cost = cost;
            Date = date;
            Excursions = excursions;
        }
        public DateTime Date { get; private set; }
        public int Cost { get; private set; }
        public List<Excursion> Excursions { get; private set; }

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
