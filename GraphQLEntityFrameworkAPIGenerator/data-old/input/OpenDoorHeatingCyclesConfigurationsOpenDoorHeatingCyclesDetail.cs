using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("OpenDoorHeatingCyclesConfigId", "OpenDoorHeatingCyclesDetailsId", "Index")]
[Table("OpenDoorHeatingCyclesConfigurations_OpenDoorHeatingCyclesDetails")]
public partial class OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail
{
    [Key]
    public Guid OpenDoorHeatingCyclesConfigId { get; set; }

    [Key]
    public Guid OpenDoorHeatingCyclesDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("OpenDoorHeatingCyclesConfigId")]
    [InverseProperty("OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails")]
    public virtual OpenDoorHeatingCyclesConfiguration OpenDoorHeatingCyclesConfig { get; set; } = null!;

    [ForeignKey("OpenDoorHeatingCyclesDetailsId")]
    [InverseProperty("OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails")]
    public virtual OpenDoorHeatingCyclesDetail OpenDoorHeatingCyclesDetails { get; set; } = null!;
}
