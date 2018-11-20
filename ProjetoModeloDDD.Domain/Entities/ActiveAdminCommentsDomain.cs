using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class ActiveAdminCommentsDomain
    {
        public int Id { get; set; }
        public string Namespace { get; set; }
        public string Body { get; set; }
        public int Resource_id { get; set; }
        public string Resource_type { get; set; }
        public int Author_id { get; set; }
        public string Author_type { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
