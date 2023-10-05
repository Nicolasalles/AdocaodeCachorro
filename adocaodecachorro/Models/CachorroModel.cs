using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adocaodecachorro.Models
{
    public class CachorroModel
    {
        public int DogID { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public bool Castracao { get; set; }
        public char Sexo { get; set; }
      
        public static List<CachorroModel> CriarLista()
        {
            var lista = new List<CachorroModel>();

            lista.Add(new CachorroModel() { DogID=1, Nome = "Rodolfo", Raca = "Vira-Lata", Idade = 6, Castracao = true, Sexo = 'M' });
            lista.Add(new CachorroModel() { DogID=2, Nome = "Haru", Raca = "Fox Paulista", Idade = 3, Castracao = false, Sexo = 'F' });

            return lista;
        }
    }

}
