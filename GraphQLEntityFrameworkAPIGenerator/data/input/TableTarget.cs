using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class TableTarget
{
    [Key]
    public byte Id { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsCodeMandatory { get; set; }

    public bool IsTargetReleasable { get; set; }

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<CrossLoadConfiguration> CrossLoadConfigurations { get; set; } = new List<CrossLoadConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Cycle> Cycles { get; set; } = new List<Cycle>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<GenericInputConfiguration> GenericInputConfigurations { get; set; } = new List<GenericInputConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<LoadConfiguration> LoadConfigurations { get; set; } = new List<LoadConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<LowLevelInputConfiguration> LowLevelInputConfigurations { get; set; } = new List<LowLevelInputConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Macro> Macros { get; set; } = new List<Macro>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<PilotGeneralizedProfile> PilotGeneralizedProfiles { get; set; } = new List<PilotGeneralizedProfile>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<PrmGianalogToTemperature> PrmGianalogToTemperatures { get; set; } = new List<PrmGianalogToTemperature>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Selector> Selectors { get; set; } = new List<Selector>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiclassBeventConfiguration> UiclassBeventConfigurations { get; set; } = new List<UiclassBeventConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UifunctionConfiguration> UifunctionConfigurations { get; set; } = new List<UifunctionConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UifunctionDetail> UifunctionDetails { get; set; } = new List<UifunctionDetail>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UigenericInputConfiguration> UigenericInputConfigurations { get; set; } = new List<UigenericInputConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Uimacro> Uimacros { get; set; } = new List<Uimacro>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiprmGianalogEncoder> UiprmGianalogEncoders { get; set; } = new List<UiprmGianalogEncoder>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiprmGianalogPotentiometer> UiprmGianalogPotentiometers { get; set; } = new List<UiprmGianalogPotentiometer>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiprmGidiscretePotentiometer> UiprmGidiscretePotentiometers { get; set; } = new List<UiprmGidiscretePotentiometer>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiprmGiincrementalEncoder> UiprmGiincrementalEncoders { get; set; } = new List<UiprmGiincrementalEncoder>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiprmGitouchSlider> UiprmGitouchSliders { get; set; } = new List<UiprmGitouchSlider>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UiregulationTable> UiregulationTables { get; set; } = new List<UiregulationTable>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UisequenceConfiguration> UisequenceConfigurations { get; set; } = new List<UisequenceConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Uisequence> Uisequences { get; set; } = new List<Uisequence>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<UisreventConfiguration> UisreventConfigurations { get; set; } = new List<UisreventConfiguration>();

    [InverseProperty("TableTargetNavigation")]
    public virtual ICollection<Uistep> Uisteps { get; set; } = new List<Uistep>();
}
