using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class ProductTypesVariablesVariableGroupsView
{
    public byte ProductTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProductTypeDsc { get; set; } = null!;

    public byte ProductTypeVariableId { get; set; }

    public byte ProductTypeOffsetId { get; set; }

    public int VariableId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Variable { get; set; } = null!;

    public byte DataType { get; set; }

    public bool IsBitmap { get; set; }

    public bool IsWritable { get; set; }

    public byte VariableGroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VariableGroupDescription { get; set; } = null!;
}
