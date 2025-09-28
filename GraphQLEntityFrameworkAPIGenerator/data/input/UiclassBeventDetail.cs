using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIClassBEventDetails")]
public partial class UiclassBeventDetail
{
    [Key]
    [Column("UIClassBEventDetailId")]
    public Guid UiclassBeventDetailId { get; set; }

    [Column("SRInputId")]
    public byte SrinputId { get; set; }

    [Column("SRInputPos")]
    public byte SrinputPos { get; set; }

    public byte Compartment { get; set; }

    [Column("SREvent")]
    public byte Srevent { get; set; }

    [ForeignKey("SrinputId")]
    [InverseProperty("UiclassBeventDetails")]
    public virtual UigenericInputReadType Srinput { get; set; } = null!;

    [InverseProperty("UiclassBeventDetail")]
    public virtual ICollection<UiclassBeventConfigurationsUiclassBeventDetail> UiclassBeventConfigurationsUiclassBeventDetails { get; set; } = new List<UiclassBeventConfigurationsUiclassBeventDetail>();
}
