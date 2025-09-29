using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetIncompatibility")]
public partial class UistmSetIncompatibility
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(32)]
    public byte[] FunctionsList { get; set; } = null!;

    public Guid? ConditionId { get; set; }

    public byte RegulationValue { get; set; }

    [MaxLength(32)]
    public byte[] EnableFunctionsList { get; set; } = null!;

    public byte MinIndex { get; set; }

    public byte DefaultIndex { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("UistmSetIncompatibilities")]
    public virtual UifunctionCondition? Condition { get; set; }
}
