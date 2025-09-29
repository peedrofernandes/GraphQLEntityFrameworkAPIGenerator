using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UisequenceConfigurationId", "UisequenceId", "Index")]
[Table("UISequenceConfigurations_UISequences")]
public partial class UisequenceConfigurationsUisequence
{
    [Key]
    [Column("UISequenceConfigurationId")]
    public Guid UisequenceConfigurationId { get; set; }

    [Key]
    [Column("UISequenceId")]
    public Guid UisequenceId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("UIConditionId")]
    public Guid? UiconditionId { get; set; }

    [ForeignKey("UiconditionId")]
    [InverseProperty("UisequenceConfigurationsUisequences")]
    public virtual Uicondition? Uicondition { get; set; }

    [ForeignKey("UisequenceId")]
    [InverseProperty("UisequenceConfigurationsUisequences")]
    public virtual Uisequence Uisequence { get; set; } = null!;

    [ForeignKey("UisequenceConfigurationId")]
    [InverseProperty("UisequenceConfigurationsUisequences")]
    public virtual UisequenceConfiguration UisequenceConfiguration { get; set; } = null!;
}
