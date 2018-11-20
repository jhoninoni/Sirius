using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class MensagemDomain
    {
        public int Id { get; set; }
        public int? User_from_id { get; set; }
        public int? User_to_id { get; set; }
        public int? Group_id { get; set; }
        public int? Client_id { get; set; }
        //public string Message { get; set; }
        //public DateTime Created_at { get; set; }
        //public DateTime Updated_at { get; set; }
        //public string File { get; set; }
        //public string Channel { get; set; }
        //public Int64? Timetoken { get; set; }
        //public string File_name { get; set; }
        //public bool? Send { get; set; }
        //public bool? Read { get; set; }
        //public bool? Delivered { get; set; }
    }
}
