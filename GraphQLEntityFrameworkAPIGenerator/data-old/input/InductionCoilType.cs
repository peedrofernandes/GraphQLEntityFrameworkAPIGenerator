using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionCoilType
{
    [Key]
    public byte CoilTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CoilTypeDesc { get; set; } = null!;

    [InverseProperty("CoilTypeNavigation")]
    public virtual ICollection<InductionCoilChannel> InductionCoilChannels { get; set; } = new List<InductionCoilChannel>();
}
