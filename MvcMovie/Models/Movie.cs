﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestScenarioFramework.Attributes;

namespace MvcMovie.Models
{
    [TestScenarioEntity]
    public class Movie
    {
        [TestScenarioMember]
        public int MovieId { get; set; }

        [TestScenarioMember]
        public string Title { get; set; }

        [TestScenarioMember]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [TestScenarioMember]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public virtual List<Actor> Actors { get; set; }
    }
}
