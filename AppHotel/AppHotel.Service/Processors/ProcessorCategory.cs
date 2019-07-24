using AppHotel.Domain.Entities;
using AppHotel.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using static AppHotel.Repository.CategoryRepository;
using static AppHotel.Repository.Repository<T>;

namespace AppHotel.Service.Processors
{
    public class ProcessorCategory
    {

        public event InsertNofify Salvar;

        private CategoryRepository _categoryRepository = new CategoryRepository();
  
        
        public void InsertCategory(string name, decimal price)
        {


            Category ctgry = new Category(name,price);
            _categoryRepository.Insert(ctgry);
            _categoryRepository.Salvar += _categoryRepository_Salvar;

        }

        private void _categoryRepository_Salvar(Category c)
        {
            throw new NotImplementedException();
        }

        public string GetCategory()
        {
            StringBuilder str = new StringBuilder("");
           foreach (var item in _categoryRepository.Get())
            {
                str.Append( $"A categoria '{item.Name}' com o valor de '{item.Price}' foi gravada com sucesso.");
                str.AppendLine();
            }
            return str.ToString();
        }

        public Category GetCategoryValue(string value)
        {
          return  _categoryRepository.GetValue(value);
        }
    }
}
