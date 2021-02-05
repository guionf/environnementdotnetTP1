using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    public class Author
    {
        private long id;
        private string firstname;
        private string lastname;

        public long Id { get => this.id; set => this.id = value; }
        public string Firstname { get => this.firstname; set => this.firstname = value; }
        public string Lastname { get => this.lastname; set => this.lastname = value; }
    }
}
