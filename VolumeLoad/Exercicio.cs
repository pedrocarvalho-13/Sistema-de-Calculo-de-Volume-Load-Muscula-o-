using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeLoad
{
    public class Exercicio
    {
        public string nomeExercicio { get; set; }
        public string grupoMuscular { get; set; }
        public double numSeries { get; set; }
        public double numReps { get; set; }
        public double pesoAparelho { get; set; }
        public double cargaTrabalho { get; set; }

        public void calculaCarga() {
            cargaTrabalho = numSeries * numReps * pesoAparelho;
        }

    }
}