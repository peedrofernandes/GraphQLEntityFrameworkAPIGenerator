using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CrossLoadDetail
{
    [Key]
    public Guid CrossLoadDetailId { get; set; }

    public byte LoadId { get; set; }

    public byte CrossLoadTypeId { get; set; }

    public byte OnDelayTime { get; set; }

    public byte OffDelayTime { get; set; }

    public byte CouplesNum { get; set; }

    [MaxLength(16)]
    public byte[] LoadOn { get; set; } = null!;

    [MaxLength(16)]
    public byte[] LoadOff { get; set; } = null!;

    public short LoadOnDisconnected { get; set; }

    public short LoadOffDisconnected { get; set; }

    [InverseProperty("CrossLoadDetail")]
    public virtual ICollection<CrossLoadConfigurationsCrossLoadDetail> CrossLoadConfigurationsCrossLoadDetails { get; set; } = new List<CrossLoadConfigurationsCrossLoadDetail>();

    [ForeignKey("CrossLoadTypeId")]
    [InverseProperty("CrossLoadDetails")]
    public virtual CrossLoadType CrossLoadType { get; set; } = null!;

    [ForeignKey("LoadId")]
    [InverseProperty("CrossLoadDetails")]
    public virtual Load Load { get; set; } = null!;
}
