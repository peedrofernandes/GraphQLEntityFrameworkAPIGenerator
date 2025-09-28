using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIDataModelTranslationDetails")]
public partial class UidataModelTranslationDetail
{
    [Key]
    [Column("UIDataModelTranslationDetailId")]
    public Guid UidataModelTranslationDetailId { get; set; }

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

    public int DataModelKeyValue { get; set; }

    public byte DataModelType { get; set; }

    public byte DataModelSubType { get; set; }

    [Column("UIDataModelKeyMappingId")]
    public Guid? UidataModelKeyMappingId { get; set; }

    public byte? DataModelNamespace { get; set; }

    [ForeignKey("UidataModelKeyMappingId")]
    [InverseProperty("UidataModelTranslationDetails")]
    public virtual UidataModelKeyMapping? UidataModelKeyMapping { get; set; }

    [InverseProperty("UidataModelTranslationDetail")]
    public virtual ICollection<UidataModelTranslationConfigurationsUidataModelTranslationDetail> UidataModelTranslationConfigurationsUidataModelTranslationDetails { get; set; } = new List<UidataModelTranslationConfigurationsUidataModelTranslationDetail>();
}
