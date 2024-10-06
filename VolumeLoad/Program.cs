namespace VolumeLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OBS: PROGRAMA EM VERSÃO BETA!\n\nEste é um programa que calcula o volume load de treino completo.\n\n");

            Console.WriteLine("Informe o Titulo do treino: ");
            string Titulo = Console.ReadLine();

            Treino treino = new Treino();

            treino.titulo = Titulo;

            while (true) {
                Console.WriteLine("Qual grupo muscular você deseja adicionar?");
                string grupoMuscular = Console.ReadLine()!;


                while (true) {

                    Exercicio exercicio = new Exercicio();

                    exercicio.grupoMuscular = grupoMuscular;
                    
                    Console.WriteLine("Informe o Nome do Exercicio: ");
                    exercicio.nomeExercicio = Console.ReadLine()!;

                    Console.WriteLine("Informe a quantidade de séries do exercicio: ");
                    exercicio.numSeries = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de repetições: ");
                    exercicio.numReps =  Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o peso utilizado nas séries: ");
                    exercicio.pesoAparelho = Convert.ToDouble(Console.ReadLine());

                    exercicio.calculaCarga();

                    treino.adicionarExercicio(exercicio);
                    
                    Console.WriteLine($"Deseja adicionar mais algum exercicio a esse grupo muscular {exercicio.grupoMuscular} (S/N)");
                    string respostaExercicio = Convert.ToString(Console.ReadLine().ToUpper());

                    while (respostaExercicio != "S" && respostaExercicio != "N") {

                        if (respostaExercicio == "S") {
                            Console.WriteLine("Adicione os dados do exercicio.");
                        } else if (respostaExercicio == "N") {
                            Console.WriteLine($"Todos os exercicio foram adicionados ao seu \b{Titulo}");
                            
                        } else {
                            Console.WriteLine("Resposta invalida.");
                        }
                    }

                    if (respostaExercicio == "N") {
                        break;
                    } 
                }

                Console.WriteLine($"Deseja adicionar mais algum grupo muscular (S/N)");
                string respostaGrupo = Convert.ToString(Console.ReadLine().ToUpper());

                while (respostaGrupo != "S" && respostaGrupo != "N") {

                    if (respostaGrupo == "S") {
                        Console.WriteLine("Adicione o grupo muscular.");
                    } else if (respostaGrupo == "N") {
                        Console.WriteLine($"O programa encerra por aqui, iremos imrpimir o seu treino com o calculo do volume load de cada Grupo Muscular.");
                        
                    } else {
                        Console.WriteLine("Resposta invalida.");
                    }
                }

                if (respostaGrupo == "N") {
                    break;
                } 

            }


            treino.CalcularVolumeTotal();
            treino.ImprimirExerciciosVolume();           
        }
    }
}