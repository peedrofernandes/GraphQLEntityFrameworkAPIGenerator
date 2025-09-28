using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadsControlPilotParameter
{
    [Key]
    public Guid Id { get; set; }

    public byte ComplexLoadsNumber { get; set; }

    public byte? LoadId0 { get; set; }

    public byte? LoadValue0 { get; set; }

    public Guid? LoadModifierId0 { get; set; }

    public byte? LoadId1 { get; set; }

    public byte? LoadValue1 { get; set; }

    public Guid? LoadModifierId1 { get; set; }

    public byte? LoadId2 { get; set; }

    public byte? LoadValue2 { get; set; }

    public Guid? LoadModifierId2 { get; set; }

    public byte? LoadId3 { get; set; }

    public byte? LoadValue3 { get; set; }

    public Guid? LoadModifierId3 { get; set; }

    public byte? LoadId4 { get; set; }

    public byte? LoadValue4 { get; set; }

    public Guid? LoadModifierId4 { get; set; }

    public byte? LoadId5 { get; set; }

    public byte? LoadValue5 { get; set; }

    public Guid? LoadModifierId5 { get; set; }

    public byte? LoadId6 { get; set; }

    public byte? LoadValue6 { get; set; }

    public Guid? LoadModifierId6 { get; set; }

    public byte? LoadId7 { get; set; }

    public byte? LoadValue7 { get; set; }

    public Guid? LoadModifierId7 { get; set; }

    public byte? LoadId8 { get; set; }

    public byte? LoadValue8 { get; set; }

    public Guid? LoadModifierId8 { get; set; }

    public byte? LoadId9 { get; set; }

    public byte? LoadValue9 { get; set; }

    public Guid? LoadModifierId9 { get; set; }

    [ForeignKey("LoadId0")]
    [InverseProperty("LoadsControlPilotParameterLoadId0Navigations")]
    public virtual Load? LoadId0Navigation { get; set; }

    [ForeignKey("LoadId1")]
    [InverseProperty("LoadsControlPilotParameterLoadId1Navigations")]
    public virtual Load? LoadId1Navigation { get; set; }

    [ForeignKey("LoadId2")]
    [InverseProperty("LoadsControlPilotParameterLoadId2Navigations")]
    public virtual Load? LoadId2Navigation { get; set; }

    [ForeignKey("LoadId3")]
    [InverseProperty("LoadsControlPilotParameterLoadId3Navigations")]
    public virtual Load? LoadId3Navigation { get; set; }

    [ForeignKey("LoadId4")]
    [InverseProperty("LoadsControlPilotParameterLoadId4Navigations")]
    public virtual Load? LoadId4Navigation { get; set; }

    [ForeignKey("LoadId5")]
    [InverseProperty("LoadsControlPilotParameterLoadId5Navigations")]
    public virtual Load? LoadId5Navigation { get; set; }

    [ForeignKey("LoadId6")]
    [InverseProperty("LoadsControlPilotParameterLoadId6Navigations")]
    public virtual Load? LoadId6Navigation { get; set; }

    [ForeignKey("LoadId7")]
    [InverseProperty("LoadsControlPilotParameterLoadId7Navigations")]
    public virtual Load? LoadId7Navigation { get; set; }

    [ForeignKey("LoadId8")]
    [InverseProperty("LoadsControlPilotParameterLoadId8Navigations")]
    public virtual Load? LoadId8Navigation { get; set; }

    [ForeignKey("LoadId9")]
    [InverseProperty("LoadsControlPilotParameterLoadId9Navigations")]
    public virtual Load? LoadId9Navigation { get; set; }

    [ForeignKey("LoadModifierId0")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId0Navigations")]
    public virtual Modifier? LoadModifierId0Navigation { get; set; }

    [ForeignKey("LoadModifierId1")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId1Navigations")]
    public virtual Modifier? LoadModifierId1Navigation { get; set; }

    [ForeignKey("LoadModifierId2")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId2Navigations")]
    public virtual Modifier? LoadModifierId2Navigation { get; set; }

    [ForeignKey("LoadModifierId3")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId3Navigations")]
    public virtual Modifier? LoadModifierId3Navigation { get; set; }

    [ForeignKey("LoadModifierId4")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId4Navigations")]
    public virtual Modifier? LoadModifierId4Navigation { get; set; }

    [ForeignKey("LoadModifierId5")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId5Navigations")]
    public virtual Modifier? LoadModifierId5Navigation { get; set; }

    [ForeignKey("LoadModifierId6")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId6Navigations")]
    public virtual Modifier? LoadModifierId6Navigation { get; set; }

    [ForeignKey("LoadModifierId7")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId7Navigations")]
    public virtual Modifier? LoadModifierId7Navigation { get; set; }

    [ForeignKey("LoadModifierId8")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId8Navigations")]
    public virtual Modifier? LoadModifierId8Navigation { get; set; }

    [ForeignKey("LoadModifierId9")]
    [InverseProperty("LoadsControlPilotParameterLoadModifierId9Navigations")]
    public virtual Modifier? LoadModifierId9Navigation { get; set; }

    [InverseProperty("PilotParameters")]
    public virtual ICollection<StmLoadsControl> StmLoadsControls { get; set; } = new List<StmLoadsControl>();
}
