using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class HelpPollDTO
    {
        public HelpPoll Poll { get; set; }

        public IList<MultipleChoiceDto> MultipleChoiceAgeRange { get; set; }

        public IList<string> SelectedAgeRange { get; set; }

        public HelpPollDTO()
        {
            MultipleChoiceAgeRange = new List<MultipleChoiceDto>();

            MultipleChoiceAgeRange.Add(new MultipleChoiceDto { Name = "Entre 18 y 30" });
            MultipleChoiceAgeRange.Add(new MultipleChoiceDto { Name = "Entre 31 y 40" });
            MultipleChoiceAgeRange.Add(new MultipleChoiceDto { Name = "Entre 41 y 50" });
            MultipleChoiceAgeRange.Add(new MultipleChoiceDto { Name = "Entre 51 y 60" });
            MultipleChoiceAgeRange.Add(new MultipleChoiceDto { Name = "Más de 61" });

            SelectedAgeRange = new List<string>();
        }
    }

    public class MultipleChoiceDto
    {
        public bool Selected { get; set; }
        public string Name { get; set; }
    }
}