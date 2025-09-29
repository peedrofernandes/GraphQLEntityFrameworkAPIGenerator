using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Load
{
    [Key]
    public byte LoadId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LoadDsc { get; set; } = null!;

    public byte LoadTypeId { get; set; }

    public bool LoadsControl { get; set; }

    public bool IsSafetyRelevant { get; set; }

    [InverseProperty("Load")]
    public virtual ICollection<CrossLoadDetail> CrossLoadDetails { get; set; } = new List<CrossLoadDetail>();

    [InverseProperty("Load")]
    public virtual ICollection<LoadDetail> LoadDetails { get; set; } = new List<LoadDetail>();

    [ForeignKey("LoadTypeId")]
    [InverseProperty("Loads")]
    public virtual LoadType LoadType { get; set; } = null!;

    [InverseProperty("LoadId0Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId0Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId1Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId1Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId2Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId2Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId3Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId3Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId4Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId4Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId5Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId5Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId6Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId6Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId7Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId7Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId8Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId8Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadId9Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadId9Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [ForeignKey("LoadId")]
    [InverseProperty("Loads")]
    public virtual ICollection<LoadGroup> LoadGroups { get; set; } = new List<LoadGroup>();
}
