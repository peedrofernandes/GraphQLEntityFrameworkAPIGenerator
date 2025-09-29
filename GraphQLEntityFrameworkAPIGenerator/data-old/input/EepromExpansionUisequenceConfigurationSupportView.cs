using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromExpansionUisequenceConfigurationSupportView
{
    public Guid ProjectId { get; set; }

    public Guid DisplayId { get; set; }

    public byte Board { get; set; }

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
}
