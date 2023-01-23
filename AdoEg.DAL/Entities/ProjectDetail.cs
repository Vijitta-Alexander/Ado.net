using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEg.DAL.Entities
{
    public class ProjectDetail
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public string? ClientName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
