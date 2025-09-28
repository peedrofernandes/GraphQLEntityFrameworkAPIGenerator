using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class PrmLoadFanDetail
{
    [Key]
    public Guid PrmLoadFanDetailsId { get; set; }

    [Column("K1Value")]
    public byte K1value { get; set; }

    [Column("K2Value")]
    public byte K2value { get; set; }

    [Column("K3Value")]
    public byte K3value { get; set; }

    [Column("K4Value")]
    public byte K4value { get; set; }

    public byte PowerPercentage { get; set; }

    [InverseProperty("PrmLoadFanDetails")]
    public virtual ICollection<PrmLoadFanConfigurationPrmLoadFanDetail> PrmLoadFanConfigurationPrmLoadFanDetails { get; set; } = new List<PrmLoadFanConfigurationPrmLoadFanDetail>();
}
