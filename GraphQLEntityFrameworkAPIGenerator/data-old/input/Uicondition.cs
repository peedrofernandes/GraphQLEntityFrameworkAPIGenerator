using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIConditions")]
public partial class Uicondition
{
    [Key]
    [Column("UIConditionId")]
    public Guid UiconditionId { get; set; }

    [Column("GIReadTypeId")]
    public byte GireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte GireadTypePosition { get; set; }

    [Column("GIValue")]
    public byte Givalue { get; set; }

    [InverseProperty("Uicondition")]
    public virtual ICollection<UisequenceConfigurationsUisequence> UisequenceConfigurationsUisequences { get; set; } = new List<UisequenceConfigurationsUisequence>();

    [InverseProperty("Uicondition")]
    public virtual ICollection<UistepsUicondition> UistepsUiconditions { get; set; } = new List<UistepsUicondition>();
}
