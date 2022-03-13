namespace OceanTrabFinal_2022.Models
{
    internal class Elevador
    {
        public int Andares { get; set; } // quantidade de andares do elevador
        public int Capacidade { get; set; } // capacidade máxima de pessoas
        public int andarAtual { get; set; } // andar atual do elevador
        public int pessoasAtual { get; set; } // ocupação atual
    }
}