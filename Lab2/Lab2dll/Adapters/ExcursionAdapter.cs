namespace Lab2dll
{
    class ExcursionAdapter : IAdapter<Excursion, ExcursionDTO>
    {
        private OrganizerAdapter adapter = new OrganizerAdapter();
        public ExcursionDTO ConvertToDTO(Excursion model)
        {
            return new ExcursionDTO
            {
                Organizer = adapter.ConvertToDTO(model.Organizer),
                Place = model.Place,
                FormConductorType = model.FormConductor
            };
        }

        public Excursion ConvertToModel(ExcursionDTO dto)
        {
            return new Excursion(adapter.ConvertToModel(dto.Organizer), dto.Place, dto.FormConductorType);
        }
    }
}