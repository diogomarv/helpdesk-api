using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Core.Entities
{
    public class Profile : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RemovedAt { get; set; }
        public string Type { get; set; }
        public bool Vacation { get; set; }
    }
}
