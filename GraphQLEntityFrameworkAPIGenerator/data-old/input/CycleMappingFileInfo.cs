using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleMappingFileInfo")]
public partial class CycleMappingFileInfo
{
    [Key]
    public Guid CycleMappingFileInfoId { get; set; }

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

    [StringLength(100)]
    public string FileId { get; set; } = null!;

    public byte HexEncoding { get; set; }

    public byte? ProductVariant { get; set; }

    [InverseProperty("CycleMappingFileInfo")]
    public virtual ICollection<CycleMappingFileInfoCycleMappingModelNumber> CycleMappingFileInfoCycleMappingModelNumbers { get; set; } = new List<CycleMappingFileInfoCycleMappingModelNumber>();

    [InverseProperty("CycleMappingFileInfo")]
    public virtual ICollection<CycleMapping> CycleMappings { get; set; } = new List<CycleMapping>();

    [ForeignKey("ProductVariant")]
    [InverseProperty("CycleMappingFileInfos")]
    public virtual CycleMappingProductVariant? ProductVariantNavigation { get; set; }
}
