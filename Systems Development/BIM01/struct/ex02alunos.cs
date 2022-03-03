using System;
class MainClass {
  struct Aluno{
    public string nome;
    public float nota1,nota2,media;
    public int id;
    public bool aprovado;
    public Aluno(string nome, float nota1, float nota2, int id){
      this.nome = nome;
      this.nota1 = nota1;
      this.nota2 = nota2;
      this.media = (nota1+nota2/2);
      this.aprovado = media>=7 ? true : false;
      this.id = id;
    }
    public void Info(){
      if(!aprovado){
        string infoString;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{nome} |\t{nota1} |\t{nota2} |\t{media} |\tReprovado");
      }else{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{nome} |\t{nota1} |\t{nota2} |\t{media} |\tAprovado");
      }
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
   }
  public static void Main (string[] args) {
    int id = 0;
    Aluno[] ListaAlunos = new Aluno[15];
    foreach(Aluno aluno in ListaAlunos){
      string nome;
      float n1,n2;
      Console.Write($"Insira o nome do {(id+1)}° aluno: ");
      nome = Console.ReadLine();
      Console.Write($"Insira a primeira nota: ");
      n1 = float.Parse(Console.ReadLine());
      Console.Write($"Insira a segunda nota: ");
      n2 = float.Parse(Console.ReadLine());
      ListaAlunos[id] = (new Aluno(nome, n1, n2, id));
      id++;
      Console.Clear();
    }
    Console.WriteLine("Nome:\tNotas\tMédia:\t Situação:\n ");
    foreach(Aluno aluno in ListaAlunos){
      aluno.Info();
    }
  }
}
