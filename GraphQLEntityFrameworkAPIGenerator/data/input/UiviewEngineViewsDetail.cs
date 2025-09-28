using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIViewEngineViewsDetails")]
public partial class UiviewEngineViewsDetail
{
    [Key]
    [Column("UIViewEngineViewsDetailsId")]
    public Guid UiviewEngineViewsDetailsId { get; set; }

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
    [InverseProperty("UiviewEngineViewsDetailDoMacros")]
    public virtual Uimacro? DoMacro { get; set; }

    [ForeignKey("OnEntryMacroId")]
    [InverseProperty("UiviewEngineViewsDetailOnEntryMacros")]
    public virtual Uimacro? OnEntryMacro { get; set; }

    [ForeignKey("OnExitMacroId")]
    [InverseProperty("UiviewEngineViewsDetailOnExitMacros")]
    public virtual Uimacro? OnExitMacro { get; set; }

    [InverseProperty("UiviewEngineViewsDetails")]
    public virtual ICollection<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail> UiviewEngineViewsConfigurationsUiviewEngineViewsDetails { get; set; } = new List<UiviewEngineViewsConfigurationsUiviewEngineViewsDetail>();
}
