using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIRegulationTables")]
public partial class UiregulationTable
{
    [Key]
    [Column("UIRegulationTableId")]
    public Guid UiregulationTableId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public bool StepRegulation { get; set; }

    public byte RegulationNum { get; set; }

    public byte MainDataType { get; set; }

    public byte VisualDataType { get; set; }

    [MaxLength(2040)]
    public byte[] MainValues { get; set; } = null!;

    [MaxLength(2040)]
    public byte[] VisualValues { get; set; } = null!;

    public double MainInitialValue { get; set; }

    public short VisualInitialValue { get; set; }

    public double MainStep { get; set; }

    public byte VisualStep { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [MaxLength(384)]
    public byte[] MainExtendValues { get; set; } = null!;

    [MaxLength(384)]
    public byte[] VisualExtendValues { get; set; } = null!;

    [ForeignKey("TableTarget")]
    [InverseProperty("UiregulationTables")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UiregulationTable")]
    public virtual ICollection<UifunctionConfigurationsUifunctionDetail> UifunctionConfigurationsUifunctionDetails { get; set; } = new List<UifunctionConfigurationsUifunctionDetail>();
}
