using System;
using System.Linq;
using System.Collections.Generic;
class MainClass {

  struct Data{
    public int day, month, year;
    public void MostrarData(){
      if(day<10){
        Console.Write($"0{day}/");
      }else{
        Console.Write($"{day}/");
      }
      if(month<10){
        Console.Write($"0{month}/");
      }else{
        Console.Write($"{month}/");
      }

      Console.Write(year);
    }
  }

  public static void Main (string[] args) {
    Data data1 = new Data();
    Console.Write("Insira o ano: ");
    data1.year = int.Parse(Console.ReadLine());
    Console.Write("Insira o mês: "); 
    data1.month = int.Parse(Console.ReadLine());
    Console.Write("Insira o dia: "); 
    data1.day = int.Parse(Console.ReadLine());
    Console.Clear();
    if(!Validade(data1)){
      Console.WriteLine("Data inválida!");
    }else{
      Console.WriteLine("Data válida!");
    }
    data1.MostrarData();
  }

  static bool Validade(Data data1){
    bool bissexto = false;
    bool eValido = true;

    if(data1.year%4==0 || data1.year%400==0){
      bissexto = true;
    }
    if(data1.month<1 || data1.month>12){
      eValido = false;
    }

    if(data1.day<1 || data1.day>31){
      eValido = false;
    }

    if(data1.month == 2){ //bissexto == true
      if(bissexto){
        if(data1.day>28){
          eValido = false;
        }
      }else{
        if(data1.day>29){
          eValido = false;
        }
      }
    }else if(data1.month == 4 || data1.month == 6 || data1.month == 9 || data1.month == 11){
      if(data1.day>30){
          eValido = false;
      }
    }

    return eValido;
  }
}