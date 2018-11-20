using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    [Table("GER_CadSolicitacaoAcesso")]
    public class SolicitacaoAcesso
    {
        #region Propriedades

        public string DesLoginUsuario { get; set; }
        public string DesNomeUsuario { get; set; }
        public string DesEmailUsuario { get; set; }
        public int? CodSistema { get; set; }

        [Key]
        public string DesSolicitacao { get; set; }

        public DateTime? LogDatSolicitacao { get; set; }

        public string DesResposta { get; set; }
        public DateTime? LogDatResposta { get; set; }
        public int? CodStatusLeitura { get; set; }

        #endregion
    }
}
