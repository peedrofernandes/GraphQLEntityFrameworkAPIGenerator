using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CycleMappingFileInfoId", "CycleMappingModelNumberId", "Index")]
[Table("CycleMappingFileInfo_CycleMappingModelNumber")]
public partial class CycleMappingFileInfoCycleMappingModelNumber
{
    [Key]
    public Guid CycleMappingFileInfoId { get; set; }

    [Key]
    public Guid CycleMappingModelNumberId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("CycleMappingFileInfoId")]
    [InverseProperty("CycleMappingFileInfoCycleMappingModelNumbers")]
    public virtual CycleMappingFileInfo CycleMappingFileInfo { get; set; } = null!;

    [ForeignKey("CycleMappingModelNumberId")]
    [InverseProperty("CycleMappingFileInfoCycleMappingModelNumbers")]
    public virtual CycleMappingModelNumber CycleMappingModelNumber { get; set; } = null!;
}
