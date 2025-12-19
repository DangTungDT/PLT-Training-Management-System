using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LessonActivityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }
        public int? TimeMinutes { get; set; }
        public int LessonPlanId { get; set; }
        public LessonPlanDTO LessonPlan { get; set; }

    }
}
