using System;
using System.Collections.Generic;
using Entities;

namespace  Business
{
    public interface IDirectoryService
    {
        List<Directory> GetList();

        List<Directory> GetByNameList(string firstName, string lastName);

        Directory GetByName(string firstName, string lastName);

        List<Directory> GetByContainsName(string value);

        List<Directory> GetByContainsPhoneNumber(string value);

        void Add(Directory directory);
        void Delete(Directory directory);
        void Update(Directory directory);
    }
}