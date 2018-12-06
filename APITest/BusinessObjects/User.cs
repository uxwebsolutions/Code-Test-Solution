using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
    public class User: Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public Role UserRole { get; set; }
    }
}
