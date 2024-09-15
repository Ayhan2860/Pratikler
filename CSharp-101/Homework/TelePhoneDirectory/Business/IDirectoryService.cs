using System;
using System.Collections.Generic;
using Entities;

namespace  Business
{
    public interface IDirectoryService
    {
        List<TelephoneDirectory> GetList();

        List<TelephoneDirectory> GetByNameList(string firstName, string lastName);

        TelephoneDirectory GetByName(string firstName, string lastName);

        List<TelephoneDirectory> GetByContainsName(string value);

        List<TelephoneDirectory> GetByContainsPhoneNumber(string value);

        void Add(TelephoneDirectory TelephoneDirectory);
        void Delete(TelephoneDirectory TelephoneDirectory);
        void Update(TelephoneDirectory TelephoneDirectory);
    }
}