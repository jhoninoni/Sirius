using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    [Table("GER_CadSistema")]
    public class Sistema
    {
        [Key]
        public int CodSistema { get; set; }
        public string DesSistema { get; set; }
        public string ImgSistema { get; set; }
        public string DesPageDefault { get; set; }
        public string DesDescricaoSistema { get; set; }
        public string DesEmailAdministrador { get; set; }
        public int CodStatus { get; set; }
    }
}
