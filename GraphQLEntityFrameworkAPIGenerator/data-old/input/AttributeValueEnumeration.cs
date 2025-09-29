using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Index("AttributeValueEnumeration1", Name = "UQ__Attribut__9048267E4CA7B1EB", IsUnique = true)]
public partial class AttributeValueEnumeration
{
    [Key]
    public int AttributeValueEnumerationId { get; set; }

    [Column("AttributeValueEnumeration")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AttributeValueEnumeration1 { get; set; }

    [ForeignKey("AttributeValueEnumerationId")]
    [InverseProperty("AttributeValueEnumerations")]
    public virtual ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();
}
