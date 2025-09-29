using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ProductTypeId", "VariableId")]
[Table("ProductTypes_Variables")]
public partial class ProductTypesVariable
{
    [Key]
    public byte ProductTypeId { get; set; }

    [Key]
    public int VariableId { get; set; }

    public byte ProductTypeVariableId { get; set; }

    public byte ProductTypeOffsetId { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("ProductTypesVariables")]
    public virtual ProductType ProductType { get; set; } = null!;

    [ForeignKey("VariableId")]
    [InverseProperty("ProductTypesVariables")]
    public virtual Variable Variable { get; set; } = null!;
}
