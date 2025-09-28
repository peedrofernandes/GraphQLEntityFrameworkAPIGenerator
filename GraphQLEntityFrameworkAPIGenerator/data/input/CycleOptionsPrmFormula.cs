using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmFormula")]
public partial class CycleOptionsPrmFormula
{
    [Key]
    public Guid FormulaParamsId { get; set; }

    public byte NumberOfInputs { get; set; }

    public byte ResultingAttributeId { get; set; }

    public float Constant { get; set; }

    public byte InputId1 { get; set; }

    public float Coefficient1 { get; set; }

    public byte InputId2 { get; set; }

    public float Coefficient2 { get; set; }

    public byte InputId3 { get; set; }

    public float Coefficient3 { get; set; }

    public byte InputId4 { get; set; }

    public float Coefficient4 { get; set; }
}
