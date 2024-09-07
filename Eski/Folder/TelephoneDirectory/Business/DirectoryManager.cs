using System;
using System.Collections.Generic;
using Database;
using Entities;

namespace  Business
{
    public class DirectoryManager : IDirectoryService
    {
        IDirectoryDal _directoryDal;

        public DirectoryManager(IDirectoryDal directoryDal)
        {
            _directoryDal = directoryDal;
        }

        public void Add(Directory directory)
        {
            _directoryDal.Add(directory);
        }

        public void Delete(Directory directory)
        {
            _directoryDal.Delete(directory);
        }

        public List<Directory> GetByContainsName(string value)
        {
            return _directoryDal.GetByConatainsNameList(value);
        }

        public List<Directory> GetByContainsPhoneNumber(string value)
        {
            return _directoryDal.GetByConatainsPhoneList(value);
        }

        public Directory GetByName(string firstName, string lastName)
        {
            return _directoryDal.GetByName(firstName, lastName);
        }

        public List<Directory> GetByNameList(string firstName, string lastName)
        {
           return _directoryDal.GetByNameList(firstName, lastName);
        }

        public List<Directory> GetList()
        {
            return _directoryDal.GetAll();
        }

        public void Update(Directory directory)
        {
            _directoryDal.Update(directory);
        }
    }
}