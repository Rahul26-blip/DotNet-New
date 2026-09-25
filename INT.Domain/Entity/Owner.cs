using INT.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace INT.Domain.Entity
{
    public class Owner : AuditeEntity
    {
        [Key]
        public int OwnerId { get; set; }
        [Required]
        public string? OwnerName { get; set; }
        [Required]
        public string? OwnerEmail { get; set; }
       
    }
}
