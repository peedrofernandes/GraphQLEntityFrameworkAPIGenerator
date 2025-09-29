using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadGroup
{
    [Key]
    public byte LoadGroupId { get; set; }

    [StringLength(50)]
    public string LoadGroupDsc { get; set; } = null!;

    [ForeignKey("LoadGroupId")]
    [InverseProperty("LoadGroups")]
    public virtual ICollection<Load> Loads { get; set; } = new List<Load>();
}
