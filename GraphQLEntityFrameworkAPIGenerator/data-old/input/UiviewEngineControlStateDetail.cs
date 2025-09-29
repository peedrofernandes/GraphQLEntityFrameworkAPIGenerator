using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIViewEngineControlStateDetails")]
public partial class UiviewEngineControlStateDetail
{
    [Key]
    [Column("UIViewEngineControlStateDetailsId")]
    public Guid UiviewEngineControlStateDetailsId { get; set; }

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

    public Guid? OnEntryMacroId { get; set; }

    public Guid? DoMacroId { get; set; }

    public Guid? OnExitMacroId { get; set; }

    [ForeignKey("DoMacroId")]
    [InverseProperty("UiviewEngineControlStateDetailDoMacros")]
    public virtual Uimacro? DoMacro { get; set; }

    [ForeignKey("OnEntryMacroId")]
    [InverseProperty("UiviewEngineControlStateDetailOnEntryMacros")]
    public virtual Uimacro? OnEntryMacro { get; set; }

    [ForeignKey("OnExitMacroId")]
    [InverseProperty("UiviewEngineControlStateDetailOnExitMacros")]
    public virtual Uimacro? OnExitMacro { get; set; }

    [InverseProperty("UiviewEngineControlStateDetails")]
    public virtual ICollection<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail> UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails { get; set; } = new List<UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail>();
}
