using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class UsuarioDomain
    {
        #region Propriedades

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password_digest { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public int Client_id { get; set; }
        public int Supervisor_id { get; set; }
        public string Phone_number { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Reset_token { get; set; }
        public bool Active { get; set; }
        public string Confirm_token { get; set; }
        public string Plan { get; set; }

        #endregion
    }
}
