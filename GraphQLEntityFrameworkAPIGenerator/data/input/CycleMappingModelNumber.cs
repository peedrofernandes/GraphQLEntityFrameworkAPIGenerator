using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleMappingModelNumber")]
public partial class CycleMappingModelNumber
{
    [Key]
    public Guid CycleMappingModelNumberId { get; set; }

    [StringLength(50)]
    public string ModelNumber { get; set; } = null!;

    [InverseProperty("CycleMappingModelNumber")]
    public virtual ICollection<CycleMappingFileInfoCycleMappingModelNumber> CycleMappingFileInfoCycleMappingModelNumbers { get; set; } = new List<CycleMappingFileInfoCycleMappingModelNumber>();
}
