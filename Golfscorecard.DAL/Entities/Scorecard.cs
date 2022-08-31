using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golfscorecard.DAL.Entities
{
    public class Scorecard
    {
        [Key]
        public int ScorecardId { get; set; }

        [Required]
        [Range(1, 18, ErrorMessage = "Amount be greater than 1 and less than 18.")]
        public int HoleNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string PlayerOne { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string PlayerTwo { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string PlayerThree { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string PlayerFour { get; set; } = string.Empty;
    }
}
