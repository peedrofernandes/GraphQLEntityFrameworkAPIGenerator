using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIFunctionDetails")]
public partial class UifunctionDetail
{
    [Key]
    [Column("UIFunctionDetailId")]
    public Guid UifunctionDetailId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public byte FunctionId { get; set; }

    public byte TargetId { get; set; }

    public bool ToMainBoard { get; set; }

    public byte FunctionFlags { get; set; }

    public int RegulationFlags { get; set; }

    public byte? SlaveInputTypeId { get; set; }

    public byte? SlaveInputTypePosition { get; set; }

    public bool IgnoreVisualRegulationTable { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte FactoryRestoreIndex { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("UifunctionDetails")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UifunctionDetail")]
    public virtual ICollection<UifunctionConfigurationsUifunctionDetail> UifunctionConfigurationsUifunctionDetails { get; set; } = new List<UifunctionConfigurationsUifunctionDetail>();
}
