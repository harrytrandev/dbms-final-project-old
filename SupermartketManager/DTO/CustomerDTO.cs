using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class CustomerDTO
    {
        public string phone { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public int gender { get; set; }
        public int point { get; set; }
        public CustomerDTO(string phone, string name, string birthday, int gender, int point)
        {
            this.phone = phone;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.point = point;
        }
    }
}
