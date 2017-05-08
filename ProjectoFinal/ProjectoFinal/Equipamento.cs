using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Equipamento
    {
        string partnumber;
        string modelnum;
        string inventcode;
        string description;
        List<Material> pecas;
        string localizacao;
        Perfil empregado;
        double price;

        public Equipamento(string PartNumber, string ModelNum, string InventCode, string Description, List<Material> Pecas, string Localizacao, Perfil Empregado, double Price)
        {
            PartNumber = partnumber;
            ModelNum = modelnum;
            InventCode = inventcode;
            Description = description;
            Pecas = pecas;
            Localizacao = localizacao;
            Empregado = empregado;
            Price = price;
        }
        public string PartNumber { get; set; }
        public string ModelNum { get; set; } 
        public string InventCode { get; set; }
        public string Description { get; set; }
        public string Pecas { get; set; }
        public string Localizacao { get; set; }
        public string Empregado { get; set; }
        public string Price { get; set; }

    }
}
