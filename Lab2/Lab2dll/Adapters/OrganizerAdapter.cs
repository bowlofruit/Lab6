namespace Lab2dll
{
    class OrganizerAdapter : IAdapter<Organizer, OrganizerDTO>
    {
        public OrganizerDTO ConvertToDTO(Organizer model)
        {
            return new OrganizerDTO { Name = model.Name, Surname = model.Surname };
        }

        public Organizer ConvertToModel(OrganizerDTO dto)
        {
            return new Organizer(dto.Name, dto.Surname);
        }
    }
}