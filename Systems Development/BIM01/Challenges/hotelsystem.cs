using System;
using System.Collections.Generic;

class Program {
  
    struct Client{
      public string name;
      public double rent;
      public int id;
      public Client(string name, double rent,int id){
        this.name = name;
        this.rent = rent;
        this.id = id;
      }
    }

    static void Main(string[] args) {
       bool exit = false;
       int option = 0;
       int id = -1;
       List<Client> ClientList = new List<Client>();
       while(!exit){
         Console.WriteLine("[1] - Add Client\n[2] - Remove Client\n[3] - List Clients\n[0] - Exit");
         option = int.Parse(Console.ReadLine());
         Console.Clear();
         switch(option){
           case 1:
            AddClient(ClientList, id);
            Console.Clear();
           break;
           case 2:
           
           break;

           case 3:
            ListClients(ClientList);
            Console.ReadLine();
            Console.Clear();
           break;
             
           default:
              exit = true;
              Console.Clear();
           break;
         }
       }
    }

    static List<Client> AddClient(List<Client> newClientList, int id){
      id++;
      string name;
      double rent;
      Console.WriteLine("Insert client name : ");
      name = Console.ReadLine();
      Console.WriteLine("Insert the rent amount: ");
      rent = double.Parse(Console.ReadLine());
      newClientList.Add(new Client(name, rent, id));
      return newClientList;
    }

    static void ListClients(List<Client> MyClientList){
      foreach(Client client in MyClientList){
        Console.WriteLine($"Name: {client.name}\nRent: ${client.rent}\nID: {client.id}\n- - - - - - - - - - - -");
      }
    }
}