using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsDetail
{
    [Key]
    public Guid CycleOptionsDetailsId { get; set; }

    public byte Input1 { get; set; }

    public byte InputValue1 { get; set; }

    public byte Input2 { get; set; }

    public byte InputValue2 { get; set; }

    public byte OptionTypeId { get; set; }

    public Guid? OptionId { get; set; }

    public byte NumberOfModifiers { get; set; }

    public byte Grouping1 { get; set; }

    public byte Grouping2 { get; set; }

    [InverseProperty("CycleOptionsDetails")]
    public virtual ICollection<CycleOptionsConfigurationsCycleOptionsDetail> CycleOptionsConfigurationsCycleOptionsDetails { get; set; } = new List<CycleOptionsConfigurationsCycleOptionsDetail>();
}
