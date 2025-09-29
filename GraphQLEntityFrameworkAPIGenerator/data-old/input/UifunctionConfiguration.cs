using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIFunctionConfigurations")]
public partial class UifunctionConfiguration
{
    [Key]
    [Column("UIFunctionConfigurationId")]
    public Guid UifunctionConfigurationId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public byte Level { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("FunctionConfiguration")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [InverseProperty("UiuserFunctionConfiguration")]
    public virtual ICollection<SelectorConfiguration> SelectorConfigurations { get; set; } = new List<SelectorConfiguration>();

    [InverseProperty("UiuserFunctionConfiguration")]
    public virtual ICollection<Selector> Selectors { get; set; } = new List<Selector>();

    [ForeignKey("TableTarget")]
    [InverseProperty("UifunctionConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UifunctionConfiguration")]
    public virtual ICollection<UifunctionConfigurationsUifunctionDetail> UifunctionConfigurationsUifunctionDetails { get; set; } = new List<UifunctionConfigurationsUifunctionDetail>();
}
