using System;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public string _nome { get; set; }
        public Jogador1(string nome = "Ronaldo")
        {
            _nome = nome;
        }
        public string Chuta()
        {
            return $"{_nome} esta chutando.";
        }
        public string Corre()
        {
            return $"{_nome} esta correndo.";
        }
        public string Passa()
        {
            return $"{_nome} esta passando.";
        }
    }
}