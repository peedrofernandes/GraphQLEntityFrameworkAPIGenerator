using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIInputs")]
public partial class Uiinput
{
    [Key]
    [Column("UIInputId")]
    public byte UiinputId { get; set; }

    [Column("UIInputDsc")]
    [StringLength(50)]
    [Unicode(false)]
    public string UiinputDsc { get; set; } = null!;

    [Column("GIReadTypeId")]
    public byte GireadTypeId { get; set; }

    [Column("LLIReadTypeId")]
    public byte LlireadTypeId { get; set; }

    public bool NeedParams { get; set; }

    public bool IsSafetyRelevant { get; set; }

    [ForeignKey("GireadTypeId")]
    [InverseProperty("Uiinputs")]
    public virtual UigenericInputReadType GireadType { get; set; } = null!;

    [ForeignKey("LlireadTypeId")]
    [InverseProperty("Uiinputs")]
    public virtual ReadType LlireadType { get; set; } = null!;

    [InverseProperty("Uiinput")]
    public virtual ICollection<UigenericInputDetail> UigenericInputDetails { get; set; } = new List<UigenericInputDetail>();

    [ForeignKey("UiinputId")]
    [InverseProperty("UiinputsNavigation")]
    public virtual ICollection<ReadType> ReadTypes { get; set; } = new List<ReadType>();
}
