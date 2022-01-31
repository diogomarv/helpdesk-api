using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Core.Entities
{
    public class User : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RemovedAt { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public Profile Profile { get; set; }
        public int IdProfile { get; set; }

    }
}
