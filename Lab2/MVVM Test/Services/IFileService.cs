using Lab2dll;
using System.Collections.Generic;

namespace MVVM_Test
{
    interface IFileService
    {
        List<Tour> Open(string filename);
        void Save(string filename, List<Tour> phonesList);
    }
}