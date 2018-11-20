using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class AdminUserDomain
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Encrypted_password { get; set; }
        public string Reset_password_token { get; set; }
        public DateTime? Reset_password_sent_at { get; set; }
        public DateTime? Remember_created_at { get; set; }
        public int Sign_in_count { get; set; }
        public DateTime? Current_sign_in_at { get; set; }
        public DateTime? Last_sign_in_at { get; set; }
        public Object Current_sign_in_ip { get; set; }
        public Object Last_sign_in_ip { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Client_id { get; set; }
        public string Phone { get; set; }

    }
}
