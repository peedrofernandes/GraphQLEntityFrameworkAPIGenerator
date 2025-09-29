using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class StatusVariable
{
    [Key]
    public Guid StatusVariableId { get; set; }

    public byte[] StatusVariables { get; set; } = null!;

    public byte[] StatusVariableGroups { get; set; } = null!;

    public byte ProductTypeId { get; set; }

    [InverseProperty("StatusVariables")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("ProductTypeId")]
    [InverseProperty("StatusVariables")]
    public virtual ProductType ProductType { get; set; } = null!;
}
