using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JBS.CSC.Potal.Models
{
    public class SolicitacaoAcessoModel
    {
        #region Propriedades

        [Required(ErrorMessage ="Campo Obrigatório.")]
        public string DesLoginUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string DesNomeUsuario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string DesEmailUsuario { get; set; }

        public int? CodSistema { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string DesSolicitacao { get; set; }

        public DateTime? LogDatSolicitacao { get; set; }
        public string DesResposta { get; set; }
        public DateTime? LogDatResposta { get; set; }
        public int? CodStatusLeitura { get; set; }

        #endregion
    }
}