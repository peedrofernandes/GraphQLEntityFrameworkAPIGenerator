using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmTime")]
public partial class CycleOptionsPrmTime
{
    [Key]
    public Guid TimeOptionsId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    public string? Notes { get; set; }

    public byte? NumberOfSelections { get; set; }

    public byte UserCookTimeSelectionBehavior { get; set; }

    public byte UserCookTimeDisplayBehavior { get; set; }

    public int UserCookTime1 { get; set; }

    public int UserCookTime2 { get; set; }

    public int UserCookTime3 { get; set; }

    public int? UserCookTime4 { get; set; }

    public int? UserCookTime5 { get; set; }

    public int? UserCookTime6 { get; set; }

    public int Step { get; set; }

    public byte Units { get; set; }

    public int UserCookTimeDefaultSelection { get; set; }

    public byte Name1 { get; set; }

    public byte Name2 { get; set; }

    public byte Name3 { get; set; }

    public byte Name4 { get; set; }

    public byte Name5 { get; set; }

    public byte Name6 { get; set; }

    public byte NameDefault { get; set; }

    [ForeignKey("UserCookTimeDisplayBehavior")]
    [InverseProperty("CycleOptionsPrmTimes")]
    public virtual CycleTimeOptionsDisplayBehaviorLabel UserCookTimeDisplayBehaviorNavigation { get; set; } = null!;

    [ForeignKey("UserCookTimeSelectionBehavior")]
    [InverseProperty("CycleOptionsPrmTimes")]
    public virtual CycleTimeOptionsSelectionBehaviorLabel UserCookTimeSelectionBehaviorNavigation { get; set; } = null!;
}
