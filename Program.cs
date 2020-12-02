using System;
using sistema_orientacao_a_objeto.classes;

namespace sistema_orientacao_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            System.Console.WriteLine("Digite o nome do estudante: ");
            aluno.nome = Console.ReadLine();

            System.Console.WriteLine("Digite o curso do aluno: ");
            aluno.curso = Console.ReadLine();

            System.Console.WriteLine("Digite o RG do aluno: ");
            aluno.rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a média final do aluno: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor da mensalidade: ");
            Console.Write("R$");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            System.Console.WriteLine("O aluno é bolsista? (s/n) ");
            string resposta = Console.ReadLine();

            if(resposta == "s"){
                aluno.bolsista = true;
            } else{
                aluno.bolsista = false;
            }

            //Menu
            int opcao = 0;
            do{
                System.Console.WriteLine("Selecione uma opção: ");
                System.Console.WriteLine("[1] - Ver informações cadastradas");
                System.Console.WriteLine("[2] - Ver média do aluno");
                System.Console.WriteLine("[3] - Ver mensalidade do aluno");
                System.Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine("--------------------------------------------------------");
                        System.Console.WriteLine($"Nome do Aluno: {aluno.nome}");
                        System.Console.WriteLine("--------------------------------------------------------");
                        System.Console.WriteLine($"Curso do Aluno: {aluno.curso}");
                        System.Console.WriteLine("--------------------------------------------------------");
                        System.Console.WriteLine($"RG do Aluno: {aluno.rg}");
                        System.Console.WriteLine("--------------------------------------------------------");
                        System.Console.WriteLine($"Idade do aluno: {aluno.mediaFinal}");
                        System.Console.WriteLine("--------------------------------------------------------");
                        System.Console.WriteLine($"Mensalidade do aluno: R${aluno.valorMensalidade}");
                        System.Console.WriteLine("--------------------------------------------------------");
                        if(aluno.bolsista){
                            System.Console.WriteLine($"Valor da mensalidade com bolsa: R${aluno.VerMensalidade()}");
                            System.Console.WriteLine("--------------------------------------------------------");
                        }
                        Console.ResetColor();
                    break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine($"A média final do aluno {aluno.nome} é {aluno.VerMediaAluno()}");
                        Console.ResetColor();
                    break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine($"A mensalidade do aluno {aluno.nome} é R${aluno.VerMensalidade()}");
                        Console.ResetColor();
                    break;
                    case 0:
                        Console.Clear();
                    break;
                }
            } while(opcao!=0);
        }
    }
}
