using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmFrozenBake")]
public partial class CycleOptionsPrmFrozenBake
{
    [Key]
    public Guid FrozenBakeParamsId { get; set; }

    public byte NumberOfTimeBands { get; set; }

    public byte AddTime1 { get; set; }

    public byte Time1 { get; set; }

    public byte AddTime2 { get; set; }

    public byte Time2 { get; set; }

    public byte AddTime3 { get; set; }

    public byte Time3 { get; set; }

    public byte AddTime4 { get; set; }

    public byte Time4 { get; set; }

    public byte AddTime5 { get; set; }

    public byte Time5 { get; set; }

    public byte AddTime6 { get; set; }

    public byte Time6 { get; set; }

    public byte AddTime7 { get; set; }

    public byte Time7 { get; set; }

    public byte AddTime8 { get; set; }

    public byte Time8 { get; set; }

    public byte AddTime9 { get; set; }

    public byte Time9 { get; set; }

    public byte AddTime10 { get; set; }
}
