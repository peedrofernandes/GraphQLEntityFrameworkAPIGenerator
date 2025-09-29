using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class FaultCode
{
    [Key]
    [Column("FaultCode")]
    public byte FaultCode1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string FaultDescription { get; set; } = null!;

    [InverseProperty("FaultCodeNavigation")]
    public virtual ICollection<FaultSubCode> FaultSubCodes { get; set; } = new List<FaultSubCode>();
}
