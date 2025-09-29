using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UidataModelTranslationConfigurationId", "UidataModelTranslationDetailId", "Index")]
[Table("UIDataModelTranslationConfigurations_UIDataModelTranslationDetails")]
public partial class UidataModelTranslationConfigurationsUidataModelTranslationDetail
{
    [Key]
    [Column("UIDataModelTranslationConfigurationId")]
    public Guid UidataModelTranslationConfigurationId { get; set; }

    [Key]
    [Column("UIDataModelTranslationDetailId")]
    public Guid UidataModelTranslationDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UidataModelTranslationConfigurationId")]
    [InverseProperty("UidataModelTranslationConfigurationsUidataModelTranslationDetails")]
    public virtual UidataModelTranslationConfiguration UidataModelTranslationConfiguration { get; set; } = null!;

    [ForeignKey("UidataModelTranslationDetailId")]
    [InverseProperty("UidataModelTranslationConfigurationsUidataModelTranslationDetails")]
    public virtual UidataModelTranslationDetail UidataModelTranslationDetail { get; set; } = null!;
}
