using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class ClienteDominioDomain
    {
        public int Id { get; set; }
        public int Client_id { get; set; }
        public string Dns { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
