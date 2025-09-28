using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class SelectorConfiguration
{
    [Key]
    public Guid SelectorConfigurationId { get; set; }

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

    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("UIUserFunctionConfigurationId")]
    public Guid? UiuserFunctionConfigurationId { get; set; }

    [Column("GlobalUIMacroId")]
    public Guid? GlobalUimacroId { get; set; }

    [ForeignKey("GlobalUimacroId")]
    [InverseProperty("SelectorConfigurations")]
    public virtual Uimacro? GlobalUimacro { get; set; }

    [InverseProperty("SelectorConfiguration")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [InverseProperty("SelectorConfiguration")]
    public virtual ICollection<SelectorConfigurationsSelector> SelectorConfigurationsSelectors { get; set; } = new List<SelectorConfigurationsSelector>();

    [ForeignKey("UiuserFunctionConfigurationId")]
    [InverseProperty("SelectorConfigurations")]
    public virtual UifunctionConfiguration? UiuserFunctionConfiguration { get; set; }
}
