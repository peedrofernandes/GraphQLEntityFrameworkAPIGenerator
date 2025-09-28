using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadType
{
    [Key]
    public byte LoadTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LoadTypeDsc { get; set; } = null!;

    public bool NeedParams { get; set; }

    [InverseProperty("LoadType")]
    public virtual ICollection<Load> Loads { get; set; } = new List<Load>();

    [ForeignKey("LoadTypeId")]
    [InverseProperty("LoadTypes")]
    public virtual ICollection<PilotType> PilotTypes { get; set; } = new List<PilotType>();
}
