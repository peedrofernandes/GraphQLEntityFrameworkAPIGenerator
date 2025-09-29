using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleName
{
    [Key]
    public int Id { get; set; }

    [Column("CycleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CycleName1 { get; set; } = null!;

    public byte CycleHeading { get; set; }

    public byte CycleSubHeading { get; set; }

    public byte CycleGroup { get; set; }

    public bool IsForSubcycles { get; set; }

    [ForeignKey("CycleGroup")]
    [InverseProperty("CycleNames")]
    public virtual CycleGroup CycleGroupNavigation { get; set; } = null!;

    [ForeignKey("CycleHeading")]
    [InverseProperty("CycleNames")]
    public virtual CycleHeading CycleHeadingNavigation { get; set; } = null!;

    [InverseProperty("CycleNameNavigation")]
    public virtual ICollection<Cycle> Cycles { get; set; } = new List<Cycle>();
}
