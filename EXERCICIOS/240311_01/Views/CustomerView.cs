using System;
using System.Collections.Generic;
using System.Linq;
using _01_04_2024_1.Models;
using _01_04_2024_1.Controllers;

namespace _01_04_2024_1.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;
        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("MENU CLIENTES");
            Console.WriteLine("------------------------------------");
            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir cliente");
                Console.WriteLine("2 - Consultar cliente");
                Console.WriteLine("3 - Listar clientes");
                Console.WriteLine("4 - Exportar itens para delimitado")
                Console.WriteLine("0 - Retornar");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                            Console.WriteLine("");
                        break;
                        case 1:
                            insertCustomer();
                        break;
                        case 2:
                            SearchCustomer();
                        break;
                        case 3:
                            ListCustomers();
                        break;
                        default:
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida.");
                            Console.ResetColor();
                            Console.WriteLine("");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    menu = -1;
                }
            }while(aux);
        }
        private void insertCustomer()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("-----------------------");
            Customer customer = new Customer();
            Console.Write("Nome: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Email: ");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            int aux = 0;
            do{
                Console.WriteLine("Deseja informar endereço?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if(aux == 0)
                    {
                        break;
                    }
                    else
                    {
                        aux = -1;
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                catch
                {
                    aux = -1;
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }while(aux != 0);

            try
            {
                customerController.Insert(customer);
                Console.WriteLine("Inserido com sucesso");
            }
            catch
            {
                Console.WriteLine("Erro ao inserir!");
            }
        }

        private void SearchCustomer()
        {
            int aux = -1;
            do
            {
                Console.WriteLine("Pesquisar cliente");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 - Busca por id");
                Console.WriteLine("2 - Busca por nome");
                Console.WriteLine("0 - Sair");

                aux = Convert.ToInt16(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Informe o id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome:");
                        string nome = Console.ReadLine();
                        ShowCustomerByName(nome);
                    break;
                    case 0:
                    break;
                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida!");
                    break;
                }
            } while (aux != 0);
        }

        private void ShowCustomerById(int id)
        {
            Customer c = customerController.GetCustomerById(id);
            if(c != null)
            {
                Console.WriteLine(c.ToString());
            }
            else
            {
                Console.WriteLine($"O consumidor de id {id} não foi encontrado");
            }
        }
        private void ShowCustomerByName(string nome)
        {
            List<Customer> result = customerController.GetByName(nome);
            if(result == null)
            {
                Console.WriteLine("Não encontrado");
                return;
            }
            if(result.Count == 0)
            {
                Console.WriteLine("Não encontrado");
                return;
            }
            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }
        private void ListCustomers()
        {
            List<Customer> result = customerController.Get();
            if(result == null)
            {
                Console.WriteLine("Não encontrado");
                return;
            }
            if(result.Count == 0)
            {
                Console.WriteLine("Não encontrado");
                return;
            }
            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}