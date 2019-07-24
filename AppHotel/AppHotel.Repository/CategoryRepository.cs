using AppHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AppHotel.Repository.Repository<T>;

namespace AppHotel.Repository
{
    public class CategoryRepository: Repository<Category>
    {


        public event InsertNotify Salvar;
        public Category GetValue(string value)
        {
            return Get().Find(x => x.Name == value);
        }

    }
}
