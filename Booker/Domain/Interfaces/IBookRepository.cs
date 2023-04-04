﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);
        Book Add(Book book);

        void Update(Book book);
        void Delete(Book book);
    }
}
