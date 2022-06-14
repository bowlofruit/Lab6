using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    class ExcursionDTO
    {
        [DataMember]
        public OrganizerDTO Organizer { get; set; }

        [DataMember]
        public string Place { get; set; }

        [DataMember]
        public FormConductorType FormConductorType { get; set; }
    }
}
