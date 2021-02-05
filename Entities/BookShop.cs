using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    public class BookShop
    {
        private long id;
        private string name;

        public long Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
    }
}
