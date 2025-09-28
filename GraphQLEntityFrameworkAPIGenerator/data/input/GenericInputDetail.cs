using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class GenericInputDetail
{
    [Key]
    public Guid GenericInputDetailId { get; set; }

    public byte InputId { get; set; }

    public byte ReadTypeId { get; set; }

    public byte ReadTypePos { get; set; }

    public Guid? ParametersId { get; set; }

    [InverseProperty("GenericInputDetail")]
    public virtual ICollection<GenericInputConfigurationsGenericInputDetail> GenericInputConfigurationsGenericInputDetails { get; set; } = new List<GenericInputConfigurationsGenericInputDetail>();

    [ForeignKey("InputId")]
    [InverseProperty("GenericInputDetails")]
    public virtual Input Input { get; set; } = null!;

    [ForeignKey("ReadTypeId")]
    [InverseProperty("GenericInputDetails")]
    public virtual ReadType ReadType { get; set; } = null!;
}
