using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class AttributeType
{
    [Key]
    public byte AttributeTypeId { get; set; }

    [Unicode(false)]
    public string AttributeTypeName { get; set; } = null!;

    [InverseProperty("AttributeType")]
    public virtual ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();
}
