using System.Runtime.Serialization;

namespace Lab2dll
{
    [DataContract]
    class OrganizerDTO
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }
    }
}
