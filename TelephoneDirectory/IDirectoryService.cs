using System.Collections.Generic;
namespace TelephoneDirectory
{
    public interface IDirectoryService
    {
        List<Directory> GetList();
        void Add(Directory directory);
        void Delete(Directory directory);
        void Update(Directory directory);
        Directory GetById(int id);
    }
}