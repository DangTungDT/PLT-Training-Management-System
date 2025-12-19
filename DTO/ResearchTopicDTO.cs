using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResearchTopicDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TopicCost { get; set; }
        public string KeyWord { get; set; }
        public int FacultyId { get; set; }
        public FacultyDTO Faculty { get; set; }
        public string TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; }

        public ICollection<ResearchTopicFileDTO> ResearchTopicFiles { get; set; }
        public ICollection<TopicObjectiveDTO> TopicObjectives { get; set; }
        public ICollection<TopicProgressDTO> TopicProgresses { get; set; }
    }
}
