using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JBS.CSC.Potal.Models
{
    public class SistemaModel
    {
        public int CodSistema { get; set; }
        public string DesSistema { get; set; }
        public string ImgSistema { get; set; }
        public string DesPageDefault { get; set; }
        public string DesDescricaoSistema { get; set; }
        public string DesEmailAdministrador { get; set; }
        public int CodStatus { get; set; }
    }
}