using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class AuthorizationsDomain
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Identifier { get; set; }
        public string Token { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
