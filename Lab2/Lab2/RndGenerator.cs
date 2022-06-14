using Lab2dll;
using System;
using System.Collections.Generic;

namespace Lab2
{
    public static class RndGenerator
    {
        private static readonly Random random = new Random();
        private static FormConductorType RndType()
        {
            FormConductorType[] formConductorTypes = Enum.GetValues(typeof(FormConductorType)) as FormConductorType[];
            return formConductorTypes[random.Next(formConductorTypes.Length)];
        }
        public static DateTime RndDay()
        {
            return new DateTime(2022, random.Next(5, 12), random.Next(1, 30));
        }
        public static int RndCost()
        {
            return random.Next(500, 1000);
        }
        private static string RndPlace()
        {
            string[] places = { "Broadway", "Park Avenue", "St. Mark’s Place", "5th Avenue", "Washington Street", "Wall Street", "Crosby Street", "Doyers Street", "Riverside Drive", "Prospect Park West" };
            return places[random.Next(places.Length)];
        }
        private static string RndSurname()
        {
            string[] surname = { "Adams", "Wilson", "Burton", "Harris", "Stevens", "Robinson", "Lewis", "Walker", "Payne", "Baker" };
            return surname[random.Next(surname.Length)];
        }
        private static string RndName()
        {
            string[] name = { "James", "Robert", "John", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles" };
            return name[random.Next(name.Length)];
        }
        private static Organizer RndOrganize(string name, string surname)
        {
            return new Organizer(name, surname);
        }
        private static Excursion RndExcurs()
        {
            return new Excursion(RndOrganize(RndName(), RndSurname()), RndPlace(), RndType());
        }
        public static List<Excursion> RndListExcurs(int number)
        {
            List<Excursion> list = new List<Excursion>();
            for (int i = 0; i < number; i++)
            {
                list.Add(RndExcurs());
            }
            return list;
        }
    }
}
