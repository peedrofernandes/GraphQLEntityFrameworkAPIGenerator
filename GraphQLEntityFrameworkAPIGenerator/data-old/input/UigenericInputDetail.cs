using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIGenericInputDetails")]
public partial class UigenericInputDetail
{
    [Key]
    [Column("UIGenericInputDetailId")]
    public Guid UigenericInputDetailId { get; set; }

    [Column("UIInputId")]
    public byte UiinputId { get; set; }

    [Column("LLIReadTypeId")]
    public byte LlireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte GireadTypePosition { get; set; }

    [Column("LLIReadTypePosition")]
    public byte LlireadTypePosition { get; set; }

    public Guid? ParametersId { get; set; }

    [ForeignKey("LlireadTypeId")]
    [InverseProperty("UigenericInputDetails")]
    public virtual ReadType LlireadType { get; set; } = null!;

    [InverseProperty("UigenericInputDetail")]
    public virtual ICollection<UigenericInputConfigurationsUigenericInputDetail> UigenericInputConfigurationsUigenericInputDetails { get; set; } = new List<UigenericInputConfigurationsUigenericInputDetail>();

    [ForeignKey("UiinputId")]
    [InverseProperty("UigenericInputDetails")]
    public virtual Uiinput Uiinput { get; set; } = null!;
}
