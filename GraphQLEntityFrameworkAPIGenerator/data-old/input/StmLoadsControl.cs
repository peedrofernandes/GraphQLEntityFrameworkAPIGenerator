using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmLoadsControl")]
public partial class StmLoadsControl
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(20)]
    public byte[] LoadsList { get; set; } = null!;

    public Guid? ConditionId { get; set; }

    public Guid? PilotParametersId { get; set; }

    public Guid? DeactivationConditionId { get; set; }

    public float TimeOn { get; set; }

    public float TimeOff { get; set; }

    public bool StartOff { get; set; }

    public byte PartialControl { get; set; }

    public byte ActivateOptions { get; set; }

    public bool Resume { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("StmLoadsControlConditions")]
    public virtual Condition? Condition { get; set; }

    [ForeignKey("DeactivationConditionId")]
    [InverseProperty("StmLoadsControlDeactivationConditions")]
    public virtual Condition? DeactivationCondition { get; set; }

    [ForeignKey("PilotParametersId")]
    [InverseProperty("StmLoadsControls")]
    public virtual LoadsControlPilotParameter? PilotParameters { get; set; }
}
