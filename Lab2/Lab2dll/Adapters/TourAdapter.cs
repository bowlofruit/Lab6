using System.Collections.Generic;

namespace Lab2dll
{
    class TourAdapter : IAdapter<Tour, TourDTO>
    {
        ExcursionAdapter adapter = new ExcursionAdapter();
        public TourDTO ConvertToDTO(Tour model)
        {
            return new TourDTO { Date = model.Date, Excursions = ModelListConvertor(model.Excursions) };
        }

        public Tour ConvertToModel(TourDTO dto)
        {
            return new Tour(dto.Cost, dto.Date, DTOListConvertor(dto.Excursions));
        }
        private List<ExcursionDTO> ModelListConvertor(List<Excursion> models)
        {
            List<ExcursionDTO> result = new List<ExcursionDTO>();
            foreach (var item in models)
            {
                result.Add(adapter.ConvertToDTO(item));
            }
            return result;
        }
        private List<Excursion> DTOListConvertor(List<ExcursionDTO> dTOs)
        {
            List<Excursion> result = new List<Excursion>();
            foreach (var item in dTOs)
            {
                result.Add(adapter.ConvertToModel(item));
            }
            return result;
        }
    }
}