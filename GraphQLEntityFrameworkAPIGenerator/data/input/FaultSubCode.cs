using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("FaultCode", "FaultSubCode1")]
public partial class FaultSubCode
{
    [Key]
    public byte FaultCode { get; set; }

    [Key]
    [Column("FaultSubCode")]
    public byte FaultSubCode1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string FaultSubCodeDescription { get; set; } = null!;

    [ForeignKey("FaultCode")]
    [InverseProperty("FaultSubCodes")]
    public virtual FaultCode FaultCodeNavigation { get; set; } = null!;
}
