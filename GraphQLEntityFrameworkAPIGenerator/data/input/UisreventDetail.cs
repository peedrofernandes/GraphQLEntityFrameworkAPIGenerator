using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISREventDetails")]
public partial class UisreventDetail
{
    [Key]
    [Column("UISREventDetailId")]
    public Guid UisreventDetailId { get; set; }

    [Column("SRInputId")]
    public byte SrinputId { get; set; }

    [Column("SRInputPos")]
    public byte SrinputPos { get; set; }

    public byte Compartment { get; set; }

    [Column("SREvent")]
    public byte Srevent { get; set; }

    [Column("SREventPrmId")]
    public Guid? SreventPrmId { get; set; }

    [ForeignKey("SrinputId")]
    [InverseProperty("UisreventDetails")]
    public virtual UigenericInputReadType Srinput { get; set; } = null!;

    [InverseProperty("UisreventDetail")]
    public virtual ICollection<UisreventConfigurationsUisreventDetail> UisreventConfigurationsUisreventDetails { get; set; } = new List<UisreventConfigurationsUisreventDetail>();
}
