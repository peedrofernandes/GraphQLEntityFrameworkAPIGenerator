using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Modifier
{
    [Key]
    public Guid ModifiersId { get; set; }

    public byte NumModifiers { get; set; }

    public byte OverallOperationId { get; set; }

    public Guid ModifierDetails1 { get; set; }

    public Guid? ModifierDetails2 { get; set; }

    public Guid? ModifierDetails3 { get; set; }

    public Guid? ModifierDetails4 { get; set; }

    public Guid? ModifierDetails5 { get; set; }

    public Guid? ModifierDetails6 { get; set; }

    public Guid? ModifierDetails7 { get; set; }

    public Guid? ModifierDetails8 { get; set; }

    public byte ModifierType1 { get; set; }

    public byte ModifierType2 { get; set; }

    public byte ModifierType3 { get; set; }

    public byte ModifierType4 { get; set; }

    public byte ModifierType5 { get; set; }

    public byte ModifierType6 { get; set; }

    public byte ModifierType7 { get; set; }

    public byte ModifierType8 { get; set; }

    public byte ModifierOperator1 { get; set; }

    public byte ModifierOperator2 { get; set; }

    public byte ModifierOperator3 { get; set; }

    public byte ModifierOperator4 { get; set; }

    public byte ModifierOperator5 { get; set; }

    public byte ModifierOperator6 { get; set; }

    public byte ModifierOperator7 { get; set; }

    public byte ModifierOperator8 { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("LoadModifierId0Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId0Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId1Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId1Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId2Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId2Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId3Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId3Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId4Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId4Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId5Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId5Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId6Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId6Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId7Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId7Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId8Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId8Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [InverseProperty("LoadModifierId9Navigation")]
    public virtual ICollection<LoadsControlPilotParameter> LoadsControlPilotParameterLoadModifierId9Navigations { get; set; } = new List<LoadsControlPilotParameter>();

    [ForeignKey("ModifierDetails1")]
    [InverseProperty("ModifierModifierDetails1Navigations")]
    public virtual ModifiersDetail ModifierDetails1Navigation { get; set; } = null!;

    [ForeignKey("ModifierDetails2")]
    [InverseProperty("ModifierModifierDetails2Navigations")]
    public virtual ModifiersDetail? ModifierDetails2Navigation { get; set; }

    [ForeignKey("ModifierDetails3")]
    [InverseProperty("ModifierModifierDetails3Navigations")]
    public virtual ModifiersDetail? ModifierDetails3Navigation { get; set; }

    [ForeignKey("ModifierDetails4")]
    [InverseProperty("ModifierModifierDetails4Navigations")]
    public virtual ModifiersDetail? ModifierDetails4Navigation { get; set; }

    [ForeignKey("ModifierDetails5")]
    [InverseProperty("ModifierModifierDetails5Navigations")]
    public virtual ModifiersDetail? ModifierDetails5Navigation { get; set; }

    [ForeignKey("ModifierDetails6")]
    [InverseProperty("ModifierModifierDetails6Navigations")]
    public virtual ModifiersDetail? ModifierDetails6Navigation { get; set; }

    [ForeignKey("ModifierDetails7")]
    [InverseProperty("ModifierModifierDetails7Navigations")]
    public virtual ModifiersDetail? ModifierDetails7Navigation { get; set; }

    [ForeignKey("ModifierDetails8")]
    [InverseProperty("ModifierModifierDetails8Navigations")]
    public virtual ModifiersDetail? ModifierDetails8Navigation { get; set; }

    [ForeignKey("ModifierOperator1")]
    [InverseProperty("ModifierModifierOperator1Navigations")]
    public virtual ModifierOperator ModifierOperator1Navigation { get; set; } = null!;

    [ForeignKey("ModifierOperator2")]
    [InverseProperty("ModifierModifierOperator2Navigations")]
    public virtual ModifierOperator ModifierOperator2Navigation { get; set; } = null!;

    [ForeignKey("ModifierOperator3")]
    [InverseProperty("ModifierModifierOperator3Navigations")]
    public virtual ModifierOperator ModifierOperator3Navigation { get; set; } = null!;

    [ForeignKey("ModifierOperator4")]
    [InverseProperty("ModifierModifierOperator4Navigations")]
    public virtual ModifierOperator ModifierOperator4Navigation { get; set; } = null!;

    [ForeignKey("ModifierOperator7")]
    [InverseProperty("ModifierModifierOperator7Navigations")]
    public virtual ModifierOperator ModifierOperator7Navigation { get; set; } = null!;

    [ForeignKey("ModifierOperator8")]
    [InverseProperty("ModifierModifierOperator8Navigations")]
    public virtual ModifierOperator ModifierOperator8Navigation { get; set; } = null!;

    [ForeignKey("ModifierType1")]
    [InverseProperty("ModifierModifierType1Navigations")]
    public virtual ModifierType ModifierType1Navigation { get; set; } = null!;

    [ForeignKey("ModifierType2")]
    [InverseProperty("ModifierModifierType2Navigations")]
    public virtual ModifierType ModifierType2Navigation { get; set; } = null!;

    [ForeignKey("ModifierType3")]
    [InverseProperty("ModifierModifierType3Navigations")]
    public virtual ModifierType ModifierType3Navigation { get; set; } = null!;

    [ForeignKey("ModifierType4")]
    [InverseProperty("ModifierModifierType4Navigations")]
    public virtual ModifierType ModifierType4Navigation { get; set; } = null!;

    [ForeignKey("ModifierType5")]
    [InverseProperty("ModifierModifierType51s")]
    public virtual ModifierType ModifierType51 { get; set; } = null!;

    [ForeignKey("ModifierType5")]
    [InverseProperty("ModifierModifierType5Navigations")]
    public virtual ModifierOperator ModifierType5Navigation { get; set; } = null!;

    [ForeignKey("ModifierType6")]
    [InverseProperty("ModifierModifierType61s")]
    public virtual ModifierType ModifierType61 { get; set; } = null!;

    [ForeignKey("ModifierType6")]
    [InverseProperty("ModifierModifierType6Navigations")]
    public virtual ModifierOperator ModifierType6Navigation { get; set; } = null!;

    [ForeignKey("ModifierType7")]
    [InverseProperty("ModifierModifierType7Navigations")]
    public virtual ModifierType ModifierType7Navigation { get; set; } = null!;

    [ForeignKey("ModifierType8")]
    [InverseProperty("ModifierModifierType8Navigations")]
    public virtual ModifierType ModifierType8Navigation { get; set; } = null!;

    [InverseProperty("Modifiers")]
    public virtual ICollection<StmMaintain> StmMaintains { get; set; } = new List<StmMaintain>();

    [InverseProperty("Modifier1Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier1Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier2Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier2Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier3Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier3Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier4Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier4Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier5Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier5Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier6Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier6Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier7Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier7Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier8Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier8Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifier9Navigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifier9Navigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("ModifierNavigation")]
    public virtual ICollection<StmSetVariable> StmSetVariableModifierNavigations { get; set; } = new List<StmSetVariable>();

    [InverseProperty("Modifiers")]
    public virtual ICollection<TimeEstimationDetail> TimeEstimationDetails { get; set; } = new List<TimeEstimationDetail>();

    [InverseProperty("Modifier")]
    public virtual ICollection<TimeEstimation> TimeEstimations { get; set; } = new List<TimeEstimation>();

    [InverseProperty("KeyModifierId0Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId0Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId1Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId1Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId2Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId2Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId3Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId3Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId4Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId4Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId5Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId5Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId6Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId6Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId7Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId7Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId8Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId8Navigations { get; set; } = new List<UidataModelKeyMapping>();

    [InverseProperty("KeyModifierId9Navigation")]
    public virtual ICollection<UidataModelKeyMapping> UidataModelKeyMappingKeyModifierId9Navigations { get; set; } = new List<UidataModelKeyMapping>();
}
