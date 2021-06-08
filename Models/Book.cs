using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStorageMicroservice_Module_6_Task_1_.Models.Enums;

namespace BookStorageMicroservice_Module_6_Task_1_.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public Lenguages Lenguage { get; set; }
    }
}
