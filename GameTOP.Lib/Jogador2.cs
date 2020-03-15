using GameTOP.Interface;

namespace GameTOP.Lib
{    
    public class Jogador2 : iJogador
    {

        public readonly string _Nome;

        public Jogador2(string nome)
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return "Maradona estas pateando\n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo\n";
        }

        public string Passe()
        {
            return "Maradona estas pasando\n";
        }
    }
}