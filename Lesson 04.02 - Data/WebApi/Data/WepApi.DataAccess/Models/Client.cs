using System.Collections.Generic;

namespace WepApi.DataAccess.Models
{
    public class Client : DbBase
    {
        public Branch Branch { get; set; }

        public ICollection<WorksWith> Partners { get; set; }
    }
}