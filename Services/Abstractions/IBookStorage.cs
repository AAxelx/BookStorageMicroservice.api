using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStorageMicroservice_Module_6_Task_1_.Models;

namespace BookStorageMicroservice_Module_6_Task_1_.Services.Abstractions
{
    interface IBookStorage
    {
        void Add(Book book);
        Book GetById(int? id);
        void Update(Book book);
        void Delete(Book book);
    }
}
