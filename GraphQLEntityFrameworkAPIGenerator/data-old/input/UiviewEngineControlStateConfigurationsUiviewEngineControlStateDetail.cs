using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiviewEngineControlStateConfigurationsId", "UiviewEngineControlStateDetailsId", "Index")]
[Table("UIViewEngineControlStateConfigurations_UIViewEngineControlStateDetails")]
public partial class UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetail
{
    [Key]
    [Column("UIViewEngineControlStateConfigurationsId")]
    public Guid UiviewEngineControlStateConfigurationsId { get; set; }

    [Key]
    [Column("UIViewEngineControlStateDetailsId")]
    public Guid UiviewEngineControlStateDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiviewEngineControlStateConfigurationsId")]
    [InverseProperty("UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails")]
    public virtual UiviewEngineControlStateConfiguration UiviewEngineControlStateConfigurations { get; set; } = null!;

    [ForeignKey("UiviewEngineControlStateDetailsId")]
    [InverseProperty("UiviewEngineControlStateConfigurationsUiviewEngineControlStateDetails")]
    public virtual UiviewEngineControlStateDetail UiviewEngineControlStateDetails { get; set; } = null!;
}
