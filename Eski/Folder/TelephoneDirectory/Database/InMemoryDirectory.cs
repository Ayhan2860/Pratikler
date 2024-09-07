using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace  Database
{
    public class InMemoryDirectory : IDirectoryDal
    {
        List<Directory> _directory;

        public InMemoryDirectory()
        {
            _directory = new List<Directory>
            {
               new Directory{Id = 1, FirstName = "Sedat", LastName="Gürsoy", PhoneNumber ="45478998798"},
               new Directory{Id = 2, FirstName = "Mustafa", LastName="Yılmaz", PhoneNumber ="4527458782"},
               new Directory{Id = 3, FirstName = "Nuket", LastName="Karaağaç", PhoneNumber ="8759632471"},
               new Directory{Id = 4, FirstName = "Abdullah", LastName="Çoban", PhoneNumber ="5358769898"},
               new Directory{Id = 5, FirstName = "Sedat", LastName="Yörükoğlu", PhoneNumber ="5447896563"}
            };
        }

        public void Add(Directory directory)
        {
            _directory.Add(directory);
        }

        public void Delete(Directory directory)
        {
             Directory deleteToDirectory = _directory.FirstOrDefault(p=>p.FirstName == directory.FirstName || p.LastName == directory.LastName);
             _directory.Remove(deleteToDirectory);
        }

        public List<Directory> GetAll()
        {
            return _directory;
        }

        public List<Directory> GetByNameList(string firstName, string lastName)
        {
            var getByNameList = _directory.Where(p => p.FirstName == firstName || p.LastName == lastName).ToList();
            return getByNameList;
        }

        public Directory GetByName(string firstName, string lastName)
        {
            var getByNameList = _directory.Where(p => p.FirstName == firstName || p.LastName == lastName).FirstOrDefault();
            return getByNameList;
        }

        public void Update(Directory directory)
        {
            Directory updateToDirectory = _directory.FirstOrDefault(p=>p.FirstName == directory.FirstName||p.LastName == directory.LastName);
            
            updateToDirectory.FirstName = directory.FirstName;
            updateToDirectory.LastName = directory.LastName;
            updateToDirectory.PhoneNumber = directory.PhoneNumber;
        }

        public List<Directory> GetByConatainsNameList(string value)
        {
         
                return _directory.Where(p=>p.FirstName.ToLower().Contains(value) || p.LastName.ToLower().Contains(value)).ToList();
           
        }

        public List<Directory> GetByConatainsPhoneList(string value)
        {
            
                return _directory.Where(p=>p.PhoneNumber.ToLower().Contains(value)).ToList();
           
        }
    }
}