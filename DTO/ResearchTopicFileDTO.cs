using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResearchTopicFileDTO
    {
        public int ResearchTopicId { get; set; }
        public ResearchTopicDTO ResearchTopic { get; set; }
        public int FileId { get; set; }
        public FilesDTO File { get; set; }
    }
}
