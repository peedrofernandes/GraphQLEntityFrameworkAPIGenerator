using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleMappingProductVariant
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [InverseProperty("ProductVariantNavigation")]
    public virtual ICollection<CycleMappingFileInfo> CycleMappingFileInfos { get; set; } = new List<CycleMappingFileInfo>();

    [InverseProperty("ProductVariantNavigation")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
