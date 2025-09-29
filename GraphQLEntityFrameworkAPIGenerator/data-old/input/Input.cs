using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Input
{
    [Key]
    public byte InputId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string InputDsc { get; set; } = null!;

    public byte InputTypeId { get; set; }

    public bool IsSafetyRelevant { get; set; }

    [InverseProperty("Input")]
    public virtual ICollection<GenericInputDetail> GenericInputDetails { get; set; } = new List<GenericInputDetail>();

    [ForeignKey("InputTypeId")]
    [InverseProperty("Inputs")]
    public virtual InputType InputType { get; set; } = null!;

    [ForeignKey("InputId")]
    [InverseProperty("Inputs")]
    public virtual ICollection<InputGroup> InputGroups { get; set; } = new List<InputGroup>();
}
