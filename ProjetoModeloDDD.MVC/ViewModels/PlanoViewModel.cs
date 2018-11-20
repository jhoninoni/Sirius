using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class PlanoViewModel
    {
        public int Id { get; set; }
    
        public List<string> Empresas { get; set; }

        public List<string> Grupos { get; set; }

        public List<string> Indicadores { get; set; }

        public string OQue { get; set; }        

        public string Porque { get; set; }

        public decimal Quanto { get; set; }

        public string Como { get; set; }

        public DateTime DataPrevistaInicio { get; set; }

        public DateTime DataPrevistaFim { get; set; }

        public DateTime DataRealizadaInicio { get; set; }

        public DateTime DataRealizadaFim { get; set; }
       
    }
}