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

        public void Add(TelephoneDirectory directory)
        {
            _directoryDal.Add(directory);
        }

        public void Delete(TelephoneDirectory directory)
        {
            _directoryDal.Delete(directory);
        }

        public List<TelephoneDirectory> GetByContainsName(string value)
        {
            return _directoryDal.GetByConatainsNameList(value);
        }

        public List<TelephoneDirectory> GetByContainsPhoneNumber(string value)
        {
            return _directoryDal.GetByConatainsPhoneList(value);
        }

        public TelephoneDirectory GetByName(string firstName, string lastName)
        {
            return _directoryDal.GetByName(firstName, lastName);
        }

        public List<TelephoneDirectory> GetByNameList(string firstName, string lastName)
        {
           return _directoryDal.GetByNameList(firstName, lastName);
        }

        public List<TelephoneDirectory> GetList()
        {
            return _directoryDal.GetAll();
        }

        public void Update(TelephoneDirectory directory)
        {
            _directoryDal.Update(directory);
        }
    }
}