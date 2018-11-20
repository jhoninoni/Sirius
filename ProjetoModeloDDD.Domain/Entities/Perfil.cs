using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Perfil
    {
        #region Contrutor

        public Perfil()
        {
            Sistema = new List<Sistema>();
        }

        #endregion

        #region Propriedades
        
        public int CodPerfil { get; set; }
        public int CodSistema { get; set; }
        public IEnumerable<Sistema> Sistema { get; set; }
        public string DescPerfil { get; set; }

        #endregion
    }
}
