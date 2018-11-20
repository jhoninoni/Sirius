using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JBS.CSC.Potal.Models
{
    public class UsuarioModel
    {
        public int CodUsuario { get; set; }
        public string DesLoginUsuario { get; set; }
        public string DesNomeUsuario { get; set; }
        public string DesEmailUsuario { get; set; }
        public DateTime? DatCadastroUsuario { get; set; }
        public int ValStatusUsuario { get; set; }
    }
}