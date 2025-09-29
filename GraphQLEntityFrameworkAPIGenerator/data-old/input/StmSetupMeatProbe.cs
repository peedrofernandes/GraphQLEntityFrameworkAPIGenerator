using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmSetupMeatProbe")]
public partial class StmSetupMeatProbe
{
    [Key]
    public Guid Id { get; set; }

    public float MeatProbeOffset { get; set; }
}
