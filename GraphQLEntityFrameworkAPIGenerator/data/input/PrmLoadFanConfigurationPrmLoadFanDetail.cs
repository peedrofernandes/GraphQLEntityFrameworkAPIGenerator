using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("Id", "PrmLoadFanDetailsId", "Index")]
[Table("PrmLoadFanConfiguration_PrmLoadFanDetails")]
public partial class PrmLoadFanConfigurationPrmLoadFanDetail
{
    [Key]
    public Guid Id { get; set; }

    [Key]
    public Guid PrmLoadFanDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("PrmLoadFanConfigurationPrmLoadFanDetails")]
    public virtual PrmLoadFanConfiguration IdNavigation { get; set; } = null!;

    [ForeignKey("PrmLoadFanDetailsId")]
    [InverseProperty("PrmLoadFanConfigurationPrmLoadFanDetails")]
    public virtual PrmLoadFanDetail PrmLoadFanDetails { get; set; } = null!;
}
