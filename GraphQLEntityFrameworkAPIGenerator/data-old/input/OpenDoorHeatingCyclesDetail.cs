using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class OpenDoorHeatingCyclesDetail
{
    [Key]
    public Guid OpenDoorHeatingCyclesDetailsId { get; set; }

    public int CycleName { get; set; }

    [StringLength(50)]
    public string Compartment { get; set; } = null!;

    public bool ConvFanFlag { get; set; }

    [InverseProperty("OpenDoorHeatingCyclesDetails")]
    public virtual ICollection<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail> OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails { get; set; } = new List<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail>();
}
