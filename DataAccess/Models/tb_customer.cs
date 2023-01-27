using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class tb_customer : IEntity
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? lastname { get; set; }
        public string? content { get; set; }
    }
}
