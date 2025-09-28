using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class FaultDetail
{
    [Key]
    public Guid FaultDetailsId { get; set; }

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

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte FaultId { get; set; }

    public byte Code { get; set; }

    public byte SubCode { get; set; }

    public byte EngineeringCode { get; set; }

    public bool PauseCycle { get; set; }

    public bool DirectToFault { get; set; }

    public Guid? FaultParametersId { get; set; }

    public bool HasSubCycle { get; set; }

    public int SubCycleNameId { get; set; }

    public byte Phase { get; set; }

    public Guid? DebounceParametersId { get; set; }

    public byte TargetId { get; set; }

    public Guid? MacroId { get; set; }

    public bool AllowClearWithoutRemovingFault { get; set; }

    public bool ClearFaultAfterColdReset { get; set; }

    public bool CancelCycleOnly { get; set; }

    public bool EngineeringCodeMethod { get; set; }

    [ForeignKey("DebounceParametersId")]
    [InverseProperty("FaultDetails")]
    public virtual DebounceMethodParameter? DebounceParameters { get; set; }

    [InverseProperty("FaultDetails")]
    public virtual ICollection<FaultConfigurationsFaultDetail> FaultConfigurationsFaultDetails { get; set; } = new List<FaultConfigurationsFaultDetail>();

    [ForeignKey("MacroId")]
    [InverseProperty("FaultDetails")]
    public virtual Macro? Macro { get; set; }

    [ForeignKey("TargetId")]
    [InverseProperty("FaultDetails")]
    public virtual Target Target { get; set; } = null!;
}
