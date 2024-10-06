using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeLoad
{
    public class Treino
    {
        public string? titulo { get; set; }
        public double VolumeTotal;

        List<Exercicio> listaExercicios = new List<Exercicio>();
        // List<string> grupos = new List<string>();
        Dictionary<string, double> volumePorGrupo = new Dictionary<string, double>();


        public void adicionarExercicio(Exercicio exercicio){
            listaExercicios.Add(exercicio);
        }

        // public void calcularVolumeTotal() {
        //     foreach (Exercicio exercicio in listaExercicios) {
        //         if (!grupos.Contains(exercicio.grupoMuscular)) {
        //             grupos.Add(exercicio.grupoMuscular);
        //         }
        //     }

        //     foreach (string grupo in grupos) {
        //         double TotalGrupo = 0;
        //         foreach(Exercicio exercicio in listaExercicios) {
        //             if (grupo == exercicio.grupoMuscular) {
        //                 TotalGrupo += exercicio.cargaTrabalho;
        //             }
        //         }
        //         grupos.Add(TotalGrupo.ToString());
        //     }
        // }

    public void CalcularVolumeTotal()
    {
        // Dicionário para armazenar o volume total de cada grupo muscular

        // Itera sobre os exercícios e soma a carga de trabalho por grupo muscular
        foreach (Exercicio exercicio in listaExercicios)
        {
            if (volumePorGrupo.ContainsKey(exercicio.grupoMuscular))
            {
                // Se o grupo já existe no dicionário, soma a carga de trabalho
                volumePorGrupo[exercicio.grupoMuscular] += exercicio.cargaTrabalho;
            }
            else
            {
                // Caso contrário, adiciona o grupo e inicializa com a carga de trabalho do exercício atual
                volumePorGrupo[exercicio.grupoMuscular] = exercicio.cargaTrabalho;
            }
        }

    }
        public void ImprimirExerciciosVolume() {
            Console.WriteLine("Exercicios: \n");
            foreach (Exercicio exercicio in listaExercicios) {
                Console.WriteLine($"Nome exercicios: {exercicio.nomeExercicio}\nReps/Series: {exercicio.numReps} x {exercicio.numSeries}\nPeso: {exercicio.pesoAparelho}\nVolume do Exercicio: {exercicio.cargaTrabalho}\n\n");
            }
            
            // Exibe o volume total por grupo muscular (se necessário)
            foreach (var grupo in volumePorGrupo)
            {
                Console.WriteLine($"\nGrupo Muscular: {grupo.Key}, Volume Total: {grupo.Value}\n");
            }
        }
    }
}