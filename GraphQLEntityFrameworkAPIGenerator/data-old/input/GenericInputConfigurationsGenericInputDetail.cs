using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("GenericInputConfigurationId", "GenericInputDetailId", "Index")]
[Table("GenericInputConfigurations_GenericInputDetails")]
public partial class GenericInputConfigurationsGenericInputDetail
{
    [Key]
    public Guid GenericInputConfigurationId { get; set; }

    [Key]
    public Guid GenericInputDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("GenericInputConfigurationId")]
    [InverseProperty("GenericInputConfigurationsGenericInputDetails")]
    public virtual GenericInputConfiguration GenericInputConfiguration { get; set; } = null!;

    [ForeignKey("GenericInputDetailId")]
    [InverseProperty("GenericInputConfigurationsGenericInputDetails")]
    public virtual GenericInputDetail GenericInputDetail { get; set; } = null!;
}
