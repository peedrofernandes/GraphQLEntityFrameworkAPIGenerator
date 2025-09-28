using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromUisequenceConfigurationView
{
    public Guid ProjectId { get; set; }

    public Guid DisplayId { get; set; }

    [Column("UISequenceConfigurationId")]
    public Guid UisequenceConfigurationId { get; set; }

    [Column("UISequenceId")]
    public Guid UisequenceId { get; set; }

    public byte SequenceIndex { get; set; }

    [StringLength(50)]
    public string SequenceDescription { get; set; } = null!;

    [Column("GIReadTypeId")]
    public byte? GireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte? GireadTypePosition { get; set; }

    [Column("GIValue")]
    public byte? Givalue { get; set; }

    public bool UseNewBuffer { get; set; }

    [Column("UIStepId")]
    public Guid? UistepId { get; set; }

    public byte? StepIndex { get; set; }

    [StringLength(50)]
    public string? StepDescription { get; set; }

    public byte? Timer { get; set; }

    public byte? Timeout { get; set; }

    public bool? DisableFunctionLayer { get; set; }

    public byte? FeedbackCode { get; set; }

    [Column("UIConditionId")]
    public Guid? UiconditionId { get; set; }

    public byte? ConditionIndex { get; set; }

    [Column("ConditionGIReadTypeId")]
    public byte? ConditionGireadTypeId { get; set; }

    [Column("ConditionGIReadTypePos")]
    public byte? ConditionGireadTypePos { get; set; }

    [Column("ConditionGIValue")]
    public byte? ConditionGivalue { get; set; }

    public int Board { get; set; }
}
