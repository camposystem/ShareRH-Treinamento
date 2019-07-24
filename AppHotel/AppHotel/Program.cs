using AppHotel.Service.Processors;
using System;
using System.Text.RegularExpressions;

namespace AppHotel.Application
{
    class Program
    {
        //TODO: verificar lista de memoria
        public static ProcessorCategory category = new ProcessorCategory();
        public static ProcessorRoom room = new ProcessorRoom();
   
        static void Main(string[] args)
        {
            

            GetScreenInitial();
        }

        private static void GetScreenInitial()
        {
            var continuar = true;
            do
            {
                var itemMenu = GetMenuinitial();
                var pattern = "[124]";
                if (Regex.IsMatch(itemMenu, pattern))
                {
                    switch (itemMenu)
                    {
                        case "1":
                            GetScreenCategory();
                            break;
                        case "2":
                            GetScreenRoom();
                            break;
                        //case "3":
                        //    GetTelaSaldo();
                        //    break;
                        //case "4":
                        //    Console.Clear();
                        //    continuar = false;
                        //    break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }

                }

            } while (continuar);
        }

        private static string  GetMenuinitial()
        {
            

            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Aplicativo Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar Categoria");
            Console.WriteLine("2 - Cadastrar Quarto");
            //Console.WriteLine("3 - Saldo detalhado");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.Write("Selecione a opção: ");
            return Console.ReadLine();
        }

        private static void GetScreenCategory()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Categoria");
            Console.WriteLine();
            Console.Write("Informe nome da categoria: ");
            string OpcaoNome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Informe o preço: ");
            decimal opcaoPreco = Convert.ToDecimal(Console.ReadLine());


            category.InsertCategory(OpcaoNome, (decimal)opcaoPreco);

            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Categoria");
            Console.WriteLine();
            Console.WriteLine(category.GetCategory());
            Console.ReadKey();



        }
        private static void GetScreenRoom()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Quarto");
            Console.WriteLine();
            Console.WriteLine("Tipo de Categoria");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Singe");
            Console.WriteLine("2 - Standart");
            Console.WriteLine("3 - Luxo");
            Console.WriteLine();
            Console.Write("Selecione a opção: ");
            string OptionCategory = Console.ReadLine();
            Console.WriteLine();
            Console.Write($"Informe Quantidade Quarto: ");
            int OptionAmount =int.Parse(Console.ReadLine());

            room.InsertRoom(OptionCategory, OptionAmount);
            

            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Quarto");
            Console.WriteLine();
            Console.WriteLine(room.GetRoom(OptionAmount));
            Console.ReadKey();




        }
    }
}
