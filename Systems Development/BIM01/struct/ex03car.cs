using System;
using System.Linq;
using System.Collections.Generic;
class MainClass {
  
  struct Carro{
    public string modelo, cor;
    public int ano, id;
    public bool cadastrado;
    public Carro(string modelo, string cor, int ano, int id){
      this.modelo = modelo;
      this.cor = cor;
      this.ano = ano;
      this.id = id;
      cadastrado = true;
    }

    public void Info(){
      Console.WriteLine(" - - - - - - - - - - - - - - - - -");
      Console.WriteLine($"Modelo: {modelo}\nCor: {cor}\nAno de fabricação: {ano}\nID: {id}");
    }
  }

  public static void Main (string[] args) {
    Carro[] ListaCarros = new Carro[500];
    int id = 0, op = 0;
    bool escolheuSair = false;
    while(!escolheuSair){
      Console.WriteLine("[1] - Cadastrar Carro\n[2] - Consultar por ano de fabricação\n[3] - Consultar por modelo\n[4] - Consultar por cor\n[5] - Exibir todos os carros cadastrados\n[6] - Alterar dado de um carro\n[7] - Excluir um carro\n[0] - Sair");
      op = int.Parse(Console.ReadLine());
      Console.Clear();
      switch(op){
        default:
          Console.WriteLine("Essa opção não existe! Pressione ENTER para VOLTAR.");
          Console.ReadLine();
          Console.Clear(); //opção inexistente
        break;
        case 0:
          escolheuSair = true;
          Console.Clear(); //sair
        break;
        case 1: //adicionar
          ListaCarros[id] = Cadastrar(ListaCarros, id);
          id++;
          Console.Clear();
        break;
        case 2: //listar via ano
          ExibirPorAno(ListaCarros);
          Console.Clear();
        break;
        case 3: //listar via modelo
          ExibirPorModelo(ListaCarros);
          Console.Clear();
        break;
        case 4: //listar via cor
          ExibirPorCor(ListaCarros);
          Console.Clear();
        break;
        case 5: //listar
          ExibirCarros(ListaCarros);
          Console.Clear();
        break;
        case 6: //alterar
          ListaCarros = Alterar(ListaCarros);
        break;
        case 7: //excluir
          ListaCarros = Excluir(ListaCarros);
        break;
      }
    }
  }

  static Carro Cadastrar(Carro[] ListaCarros, int id){
    string modelo, cor;
    int ano;
    Console.WriteLine("- - - - - Registro de Carro - - - - -");
    Console.Write("Insira o modelo do carro: ");
    modelo = Console.ReadLine();
    Console.Write("Insira a cor do carro: ");
    cor = Console.ReadLine();
    Console.Write("Insira o ano de fabricação do carro: ");
    ano = int.Parse(Console.ReadLine());
    ListaCarros[id] = new Carro(modelo, cor, ano, id);
    return ListaCarros[id];
  }

  static Carro[] Excluir(Carro[] ListaCarros){
    int id;
    bool foiExibido = false;
    string confirmar;
    Console.Write("Insira o ID do carro a ser excluído: ");
    id = int.Parse(Console.ReadLine());
    Console.Clear();
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.id == id){
        MeuCarro.Info();
        foiExibido = true;
        Console.Write("Deseja excluir esse carro? [S/N]");
        confirmar = Console.ReadLine();
        if(confirmar =="S" || confirmar=="s"){
          ListaCarros = ListaCarros.Where((source, index) =>index != id).ToArray();
          Console.WriteLine("Carro excluído com sucesso!");
        }else{
          Console.WriteLine("Exclusão cancelada com sucesso.");
        }
      }
    }
    if(!foiExibido){
      Console.WriteLine("Carro não encontrado.");
    }
    Console.ReadLine();
    Console.Clear();
    return ListaCarros;
  }

  static Carro[] Alterar(Carro[] ListaCarros){
    bool foiExibido = false, saiu = false;
    int id = 0;
    Console.Write("Insira o ID do carro a ser alterado: ");
    id = int.Parse(Console.ReadLine());
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.id == id){
        Console.Clear();
        foiExibido = true;
        MeuCarro.Info();
        while(!saiu){
        Console.WriteLine("\nQual elemento deseja alterar?\n[1] - Modelo | [2] - Cor | [3] - Ano de fabricação | [0] - Sair");
        int op = int.Parse(Console.ReadLine());
        Console.Clear();
        switch(op){
            default:
              Console.WriteLine("Essa opção não existe! Pressione ENTER para VOLTAR.");
              Console.ReadLine();
              Console.Clear();
            break;
            case 0:
              saiu = true;
              Console.Clear();
            break;
            case 1:
              Console.Write("Insira o modelo do carro: ");
              ListaCarros[id].modelo = Console.ReadLine();
              Console.WriteLine("Alteração feita com sucesso!");
              Console.ReadLine();
              Console.Clear();
            break;
            case 2:
              Console.Write("Insira a cor do carro: ");
              ListaCarros[id].cor = Console.ReadLine();
              Console.WriteLine("Alteração feita com sucesso!");
              Console.ReadLine();
              Console.Clear();
            break;
            case 3:
              Console.Write("Insira o ano de fabricação do carro: ");
              ListaCarros[id].ano = int.Parse(Console.ReadLine());
              Console.WriteLine("Alteração feita com sucesso!");
              Console.ReadLine();
              Console.Clear();
            break;

          }          
        }
      }
    }
    if(!foiExibido){
      Console.WriteLine("Carro não encontrado.");
    }
    Console.ReadLine();
    Console.Clear();
    return ListaCarros;
  }

  static void ExibirCarros(Carro[] ListaCarros){
    Console.WriteLine("LISTA DE CARROS:\n");
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.cadastrado){
        MeuCarro.Info();
      }
    }
    Console.ReadLine();
  }

  static void ExibirPorAno(Carro[] ListaCarros){
    int ano;
    bool foiExibido = false;
    Console.Write("Insira o ano de fabricação: ");
    ano = int.Parse(Console.ReadLine());
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.ano == ano){
        MeuCarro.Info();
        foiExibido = true;
      }
    }
    if(!foiExibido){ /*caso nenhum carro for encontrado*/
      Console.WriteLine("Nenhum carro encontrado.");
    } 
    Console.ReadLine();
  }

  static void ExibirPorCor(Carro[] ListaCarros){
    string cor;
    bool foiExibido = false;
    Console.Write("Insira a cor do carro: ");
    cor = Console.ReadLine();
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.cor == cor){
        MeuCarro.Info();
        foiExibido = true;
      }
    }
    if(!foiExibido){
      Console.WriteLine("Nenhum carro encontrado.");
    }
    Console.ReadLine();
  }

  static void ExibirPorModelo(Carro[] ListaCarros){
    string modelo = "";
    bool foiExibido = false;
    Console.Write("Insira o modelo do carro: ");
    modelo = Console.ReadLine();
    foreach(Carro MeuCarro in ListaCarros){
      if(MeuCarro.modelo == modelo){
        MeuCarro.Info();
        foiExibido = true;
      }
    }
    if(!foiExibido){
      Console.WriteLine("Nenhum carro encontrado.");
    }
    Console.ReadLine();
  }
}