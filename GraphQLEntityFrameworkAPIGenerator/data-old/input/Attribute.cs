using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Index("AttributeName", Name = "UQ__Attribut__B0EBDF2F502708F9", IsUnique = true)]
public partial class Attribute
{
    [Key]
    public int AttributeId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AttributeName { get; set; }

    public byte AttributeTypeId { get; set; }

    public int? AttributeValueMin { get; set; }

    public int? AttributeValueMax { get; set; }

    public float? AttributeValueResolution { get; set; }

    public float AttributeDefault { get; set; }

    [ForeignKey("AttributeTypeId")]
    [InverseProperty("Attributes")]
    public virtual AttributeType AttributeType { get; set; } = null!;

    [ForeignKey("AttributeId")]
    [InverseProperty("Attributes")]
    public virtual ICollection<AttributeValueEnumeration> AttributeValueEnumerations { get; set; } = new List<AttributeValueEnumeration>();
}
