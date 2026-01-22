using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LessonScheduleDTO
    {
        public int Id { get; set; }

        public int LessonPlanId { get; set; }
        public LessonPlanDTO LessonPlan { get; set; }

        /// <summary>
        /// 2 = Monday, 3 = Tuesday, ..., 8 = Sunday
        /// </summary>
        public int DayOfWeek { get; set; }

        /// <summary>
        /// 'M' = Morning, 'A' = Afternoon
        /// </summary>
        public string Session { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
