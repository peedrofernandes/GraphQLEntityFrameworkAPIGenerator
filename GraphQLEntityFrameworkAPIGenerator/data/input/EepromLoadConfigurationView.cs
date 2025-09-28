using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromLoadConfigurationView
{
    public Guid ProjectId { get; set; }

    public Guid BoardId { get; set; }

    public Guid LoadConfigurationId { get; set; }

    public byte Index { get; set; }

    public Guid LoadDetailId { get; set; }

    public byte LoadId { get; set; }

    public byte PilotTypeId { get; set; }

    public byte? Pin1 { get; set; }

    public byte? Pin2 { get; set; }

    public byte? Pin3 { get; set; }

    public byte? Pin4 { get; set; }

    public bool OnLevel1 { get; set; }

    public bool OnLevel2 { get; set; }

    public bool OnLevel3 { get; set; }

    public bool OnLevel4 { get; set; }

    public Guid? PilotParametersId { get; set; }

    public Guid? FeedbackParametersId { get; set; }

    public Guid? LoadParametersId { get; set; }

    [Column("UIDriven")]
    public bool Uidriven { get; set; }

    public int Board { get; set; }

    public bool? IsLoadSafetyRelevant { get; set; }

    public bool? IsPilotSafetyRelevant { get; set; }
}
