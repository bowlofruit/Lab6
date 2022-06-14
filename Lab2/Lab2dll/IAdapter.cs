namespace Lab2dll
{
    interface IAdapter<T1, T2>
    {
        T1 ConvertToModel(T2 DTO);
        T2 ConvertToDTO(T1 model);
    }
}