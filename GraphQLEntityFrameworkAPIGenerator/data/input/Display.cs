using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Display
{
    [Key]
    public Guid DisplayId { get; set; }

    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid? LowLevelInputConfigurationId { get; set; }

    public Guid? GenericInputConfigurationId { get; set; }

    public Guid? FunctionConfigurationId { get; set; }

    public Guid? SequenceConfigurationId { get; set; }

    public byte VisualBoardTypeId { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public Guid? StatusVariablesId { get; set; }

    [Column("UILedGroupsConfigurationsId")]
    public Guid? UiledGroupsConfigurationsId { get; set; }

    [Column("UIAudioConfigurationId")]
    public Guid? UiaudioConfigurationId { get; set; }

    [Column("UIAnimationConfigurationId")]
    public Guid? UianimationConfigurationId { get; set; }

    [Column("HMIExpansionBoardConfigurationsId")]
    public Guid? HmiexpansionBoardConfigurationsId { get; set; }

    public byte BrandId { get; set; }

    [Column("UISREventConfigurationId")]
    public Guid? UisreventConfigurationId { get; set; }

    [Column("UIViewEngineControlStateConfigurationsId")]
    public Guid? UiviewEngineControlStateConfigurationsId { get; set; }

    [Column("UIViewEngineViewsId")]
    public Guid? UiviewEngineViewsId { get; set; }

    [Column("UIDataModelTranslationConfigurationId")]
    public Guid? UidataModelTranslationConfigurationId { get; set; }

    [Column("UITouchDevicesId")]
    public Guid? UitouchDevicesId { get; set; }

    [Column("UILowPowerTimeId")]
    public Guid? UilowPowerTimeId { get; set; }

    [Column("UIDefaultPinConfigurationId")]
    public Guid? UidefaultPinConfigurationId { get; set; }

    public byte? ProductVariant { get; set; }

    public byte NodeAddress { get; set; }

    [Column("FaultF12Timeout")]
    public byte FaultF12timeout { get; set; }

    public byte StandByTimeout { get; set; }

    public byte GoingToSleepTimeout { get; set; }

    public byte StandByCommunicationTimeout { get; set; }

    public bool MainTimeToEnd { get; set; }

    public Guid? DebugPointerConfigurationsId { get; set; }

    [ForeignKey("BrandId")]
    [InverseProperty("Displays")]
    public virtual Brand Brand { get; set; } = null!;

    [ForeignKey("DebugPointerConfigurationsId")]
    [InverseProperty("Displays")]
    public virtual DebugPointerConfiguration? DebugPointerConfigurations { get; set; }

    [ForeignKey("FunctionConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UifunctionConfiguration? FunctionConfiguration { get; set; }

    [ForeignKey("GenericInputConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UigenericInputConfiguration? GenericInputConfiguration { get; set; }

    [ForeignKey("HmiexpansionBoardConfigurationsId")]
    [InverseProperty("Displays")]
    public virtual HmiexpansionBoardConfiguration? HmiexpansionBoardConfigurations { get; set; }

    [InverseProperty("Display")]
    public virtual ICollection<HmiexpansionBoardConfigurationsDisplay> HmiexpansionBoardConfigurationsDisplays { get; set; } = new List<HmiexpansionBoardConfigurationsDisplay>();

    [ForeignKey("LowLevelInputConfigurationId")]
    [InverseProperty("Displays")]
    public virtual LowLevelInputConfiguration? LowLevelInputConfiguration { get; set; }

    [ForeignKey("NodeAddress")]
    [InverseProperty("Displays")]
    public virtual HmiAvailableNode NodeAddressNavigation { get; set; } = null!;

    [ForeignKey("ProductVariant")]
    [InverseProperty("Displays")]
    public virtual CycleMappingProductVariant? ProductVariantNavigation { get; set; }

    [InverseProperty("HmiConfiguration")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [ForeignKey("SequenceConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UisequenceConfiguration? SequenceConfiguration { get; set; }

    [ForeignKey("StatusVariablesId")]
    [InverseProperty("Displays")]
    public virtual StatusVariable? StatusVariables { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("Displays")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [ForeignKey("UianimationConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UianimationConfiguration? UianimationConfiguration { get; set; }

    [ForeignKey("UiaudioConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UiaudioConfiguration? UiaudioConfiguration { get; set; }

    [ForeignKey("UidataModelTranslationConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UidataModelTranslationConfiguration? UidataModelTranslationConfiguration { get; set; }

    [ForeignKey("UidefaultPinConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UidefaultPinConfiguration? UidefaultPinConfiguration { get; set; }

    [ForeignKey("UiledGroupsConfigurationsId")]
    [InverseProperty("Displays")]
    public virtual UiledGroupsConfiguration? UiledGroupsConfigurations { get; set; }

    [ForeignKey("UilowPowerTimeId")]
    [InverseProperty("Displays")]
    public virtual UilowPowerTime? UilowPowerTime { get; set; }

    [ForeignKey("UisreventConfigurationId")]
    [InverseProperty("Displays")]
    public virtual UisreventConfiguration? UisreventConfiguration { get; set; }

    [ForeignKey("UitouchDevicesId")]
    [InverseProperty("Displays")]
    public virtual UitouchDevice? UitouchDevices { get; set; }

    [ForeignKey("UiviewEngineControlStateConfigurationsId")]
    [InverseProperty("Displays")]
    public virtual UiviewEngineControlStateConfiguration? UiviewEngineControlStateConfigurations { get; set; }

    [ForeignKey("UiviewEngineViewsId")]
    [InverseProperty("Displays")]
    public virtual UiviewEngineViewsConfiguratio? UiviewEngineViews { get; set; }

    [ForeignKey("VisualBoardTypeId")]
    [InverseProperty("Displays")]
    public virtual VisualBoardType VisualBoardType { get; set; } = null!;
}
