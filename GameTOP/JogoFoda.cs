using System;
namespace GameTOP
{
    public class JogoFoda
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Passa());
            System.Console.WriteLine("\nKEKWKEKW \n");
            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Passa());
        }
    }
}