using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromUigenericInputConfigurationView
{
    public Guid ProjectId { get; set; }

    public Guid DisplayId { get; set; }

    [Column("UIGenericInputConfigurationId")]
    public Guid UigenericInputConfigurationId { get; set; }

    public byte Index { get; set; }

    [Column("UIGenericInputDetailId")]
    public Guid UigenericInputDetailId { get; set; }

    [Column("UIInputId")]
    public byte UiinputId { get; set; }

    [Column("GIReadTypePosition")]
    public byte GireadTypePosition { get; set; }

    [Column("LLIReadTypePosition")]
    public byte LlireadTypePosition { get; set; }

    public Guid? ParametersId { get; set; }

    public int Board { get; set; }

    [Column("LLIReadTypeId")]
    public byte LlireadTypeId { get; set; }

    public bool IsReadTypeSafetyRelevant { get; set; }

    public bool IsInputSafetyRelevant { get; set; }
}
