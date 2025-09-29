using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedFunctionMappingDetails")]
public partial class UiledFunctionMappingDetail
{
    [Key]
    [Column("UILedFunctionMappingDetailId")]
    public Guid UiledFunctionMappingDetailId { get; set; }

    public string LedName { get; set; } = null!;

    public int LedFunctionId { get; set; }

    public byte Compartment { get; set; }

    [InverseProperty("UiledFunctionMappingDetail")]
    public virtual ICollection<UiledFunctionMappingConfigurationsUiledFunctionMappingDetail> UiledFunctionMappingConfigurationsUiledFunctionMappingDetails { get; set; } = new List<UiledFunctionMappingConfigurationsUiledFunctionMappingDetail>();
}
