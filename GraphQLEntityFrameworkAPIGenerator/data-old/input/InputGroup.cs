using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InputGroup
{
    [Key]
    public byte InputGroupId { get; set; }

    [StringLength(50)]
    public string InputGroupDesc { get; set; } = null!;

    [ForeignKey("InputGroupId")]
    [InverseProperty("InputGroups")]
    public virtual ICollection<Input> Inputs { get; set; } = new List<Input>();
}
