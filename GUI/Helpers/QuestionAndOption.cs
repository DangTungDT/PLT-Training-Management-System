using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace GUI.Helpers
{
    public class QuestionAndOption
    {
        public string TypeQuestion { get; set; }
        public string ContentQuetion { get; set; }
        public decimal ScoreQuetion { get; set; }
        public List<QuestionOptionDTO> Options { get; set; }

    }
}
