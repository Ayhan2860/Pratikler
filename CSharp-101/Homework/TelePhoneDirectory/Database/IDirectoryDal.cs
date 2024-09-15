using System;
using System.Collections.Generic;
using Entities;

namespace  Database
{
    public interface IDirectoryDal
    {
        List<TelephoneDirectory> GetAll();

        List<TelephoneDirectory> GetByNameList(string firstName, string lastName);

        List<TelephoneDirectory> GetByConatainsNameList(string value);

        List<TelephoneDirectory> GetByConatainsPhoneList(string value);
        TelephoneDirectory GetByName(string firstName, string lastName);

        void Add(TelephoneDirectory directory);
        void Delete(TelephoneDirectory directory);

        void Update(TelephoneDirectory directory);
    }
}