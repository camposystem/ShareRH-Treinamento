using AppHotel.Domain.Entities;
using AppHotel.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Service.Processors
{ 

    public class ProcessorRoom
    {

       private RoomRepository _processorRom = new RoomRepository();
       public void InsertRoom(string category, int amount)
        {
            ProcessorCategory cat = new ProcessorCategory();
            var i = 0;
            while (amount > i)
            {
                i += 1;
                //Constroi o quarto com a categoria, ativo e não reservado
                Room room = new Room(cat.GetCategoryValue(category), amount, 0);
                _processorRom.Insert(room);

            }

        }

        public string GetRoom(int amount)
        {
            StringBuilder str = new StringBuilder("");
            foreach (var item in _processorRom.GetValue(amount.ToString()))
            {
                str.Append($"O quarto '{item.Key}' do tipo '{item.categories.Name}' foi gravada com sucesso.");
                str.AppendLine();
            }
            return str.ToString();
        }
    }
}
