using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedDriverParameters")]
public partial class UiledDriverParameter
{
    [Key]
    [Column("UILedDriverParametersId")]
    public Guid UiledDriverParametersId { get; set; }

    public string Description { get; set; } = null!;

    [StringLength(100)]
    public string LedName { get; set; } = null!;

    public byte LedTypeId { get; set; }

    public byte Parameter1 { get; set; }

    public byte? Parameter2 { get; set; }

    public byte? Parameter3 { get; set; }

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

    [ForeignKey("LedTypeId")]
    [InverseProperty("UiledDriverParameters")]
    public virtual UiledDriverType LedType { get; set; } = null!;

    [InverseProperty("UiledDriverParameters")]
    public virtual ICollection<UiledConfigurationsUiledDriverParameter> UiledConfigurationsUiledDriverParameters { get; set; } = new List<UiledConfigurationsUiledDriverParameter>();
}
