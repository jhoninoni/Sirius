using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class GrupoUsuarioDomain
    {
        public int Id { get; set; }
        public int Group_id { get; set; }
        public int User_id { get; set; }
        public DateTime? Entry_date { get; set; }
        public DateTime? Exit_date { get; set; }
        public bool Active { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
