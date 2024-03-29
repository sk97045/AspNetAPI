﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        [MaxLength(200)]
        public string Description { get; set; }

        [Required(ErrorMessage = "You should provide a new value")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
