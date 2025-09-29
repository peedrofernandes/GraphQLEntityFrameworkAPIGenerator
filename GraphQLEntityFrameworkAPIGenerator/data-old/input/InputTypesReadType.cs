using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("InputTypeId", "ReadTypeId")]
[Table("InputTypes_ReadTypes")]
public partial class InputTypesReadType
{
    [Key]
    public byte InputTypeId { get; set; }

    [Key]
    public byte ReadTypeId { get; set; }

    public bool NeedParams { get; set; }

    [ForeignKey("InputTypeId")]
    [InverseProperty("InputTypesReadTypes")]
    public virtual InputType InputType { get; set; } = null!;

    [ForeignKey("ReadTypeId")]
    [InverseProperty("InputTypesReadTypes")]
    public virtual ReadType ReadType { get; set; } = null!;
}
