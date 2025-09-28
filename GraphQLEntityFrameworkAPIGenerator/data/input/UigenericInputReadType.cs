using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIGenericInputReadTypes")]
public partial class UigenericInputReadType
{
    [Key]
    [Column("UIReadTypeId")]
    public byte UireadTypeId { get; set; }

    [Column("UIReadTypeDsc")]
    [StringLength(50)]
    [Unicode(false)]
    public string UireadTypeDsc { get; set; } = null!;

    [InverseProperty("Srinput")]
    public virtual ICollection<UiclassBeventDetail> UiclassBeventDetails { get; set; } = new List<UiclassBeventDetail>();

    [InverseProperty("GireadType")]
    public virtual ICollection<Uiinput> Uiinputs { get; set; } = new List<Uiinput>();

    [InverseProperty("Srinput")]
    public virtual ICollection<UisreventDetail> UisreventDetails { get; set; } = new List<UisreventDetail>();
}
