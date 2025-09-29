using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleMappingUri
{
    [Key]
    public Guid UriTreeId { get; set; }

    public byte NumberOfTrees { get; set; }

    public byte? SetCycleTreeLevels1 { get; set; }

    [MaxLength(50)]
    public byte[]? SetCycleTree1 { get; set; }

    public byte? SetCycleTreeLevels2 { get; set; }

    [MaxLength(50)]
    public byte[]? SetCycleTree2 { get; set; }

    public byte? SetCycleTreeLevels3 { get; set; }

    [MaxLength(50)]
    public byte[]? SetCycleTree3 { get; set; }

    public byte? SetCycleTreeLevels4 { get; set; }

    [MaxLength(50)]
    public byte[]? SetCycleTree4 { get; set; }

    [InverseProperty("UriTree")]
    public virtual ICollection<CycleMappingCycleOptionsConfiguration> CycleMappingCycleOptionsConfigurations { get; set; } = new List<CycleMappingCycleOptionsConfiguration>();
}
