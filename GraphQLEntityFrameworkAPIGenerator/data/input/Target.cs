using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Target
{
    [Key]
    public byte TargetId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TargetDsc { get; set; } = null!;

    [InverseProperty("Target")]
    public virtual ICollection<FaultDetail> FaultDetails { get; set; } = new List<FaultDetail>();
}
