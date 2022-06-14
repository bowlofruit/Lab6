using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    internal class TourDTO
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public List<ExcursionDTO> Excursions { get; set; }

        [DataMember]
        public int Cost { get; set; }
    }
}
