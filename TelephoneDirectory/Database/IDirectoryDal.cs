using System;
using System.Collections.Generic;
using Entities;

namespace  Database
{
    public interface IDirectoryDal
    {
        List<Directory> GetAll();

        List<Directory> GetByNameList(string firstName, string lastName);

        List<Directory> GetByConatainsNameList(string value);

        List<Directory> GetByConatainsPhoneList(string value);
        Directory GetByName(string firstName, string lastName);

        void Add(Directory directory);
        void Delete(Directory directory);

        void Update(Directory directory);
    }
}