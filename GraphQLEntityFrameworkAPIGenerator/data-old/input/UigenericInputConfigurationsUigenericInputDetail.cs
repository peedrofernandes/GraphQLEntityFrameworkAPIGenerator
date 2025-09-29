using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UigenericInputConfigurationId", "UigenericInputDetailId", "Index")]
[Table("UIGenericInputConfigurations_UIGenericInputDetails")]
public partial class UigenericInputConfigurationsUigenericInputDetail
{
    [Key]
    [Column("UIGenericInputConfigurationId")]
    public Guid UigenericInputConfigurationId { get; set; }

    [Key]
    [Column("UIGenericInputDetailId")]
    public Guid UigenericInputDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UigenericInputConfigurationId")]
    [InverseProperty("UigenericInputConfigurationsUigenericInputDetails")]
    public virtual UigenericInputConfiguration UigenericInputConfiguration { get; set; } = null!;

    [ForeignKey("UigenericInputDetailId")]
    [InverseProperty("UigenericInputConfigurationsUigenericInputDetails")]
    public virtual UigenericInputDetail UigenericInputDetail { get; set; } = null!;
}
