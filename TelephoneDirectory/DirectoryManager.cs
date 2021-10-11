using System.Collections.Generic;
using System;

namespace TelephoneDirectory
{
    public class DirectoryManager : IDirectoryService
    {
        public void Add(Directory directory)
        {
            Console.WriteLine($"{directory.FirstName} { directory.LastName} rehbere eklendi.");
        }

        public void Delete(Directory directory)
        {
            throw new System.NotImplementedException();
        }

        public Directory GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Directory> GetList()
        {
            InMemory memory = new InMemory();
            return memory.GetAll();
        }

        public void Update(Directory directory)
        {
            throw new System.NotImplementedException();
        }
    }
}