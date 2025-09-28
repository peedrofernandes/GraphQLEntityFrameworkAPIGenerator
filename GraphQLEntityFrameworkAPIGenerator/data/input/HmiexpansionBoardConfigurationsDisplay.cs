using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("HmiexpansionBoardConfigurationId", "DisplayId", "Index")]
[Table("HMIExpansionBoardConfigurations_Displays")]
public partial class HmiexpansionBoardConfigurationsDisplay
{
    [Key]
    [Column("HMIExpansionBoardConfigurationId")]
    public Guid HmiexpansionBoardConfigurationId { get; set; }

    [Key]
    public Guid DisplayId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("HMIExpansionBoardId")]
    public byte HmiexpansionBoardId { get; set; }

    [ForeignKey("DisplayId")]
    [InverseProperty("HmiexpansionBoardConfigurationsDisplays")]
    public virtual Display Display { get; set; } = null!;

    [ForeignKey("HmiexpansionBoardConfigurationId")]
    [InverseProperty("HmiexpansionBoardConfigurationsDisplays")]
    public virtual HmiexpansionBoardConfiguration HmiexpansionBoardConfiguration { get; set; } = null!;
}
