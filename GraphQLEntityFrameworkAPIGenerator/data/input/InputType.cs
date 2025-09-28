using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InputType
{
    [Key]
    public byte InputTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string InputTypeDsc { get; set; } = null!;

    [InverseProperty("InputType")]
    public virtual ICollection<InputTypesReadType> InputTypesReadTypes { get; set; } = new List<InputTypesReadType>();

    [InverseProperty("InputType")]
    public virtual ICollection<Input> Inputs { get; set; } = new List<Input>();
}
