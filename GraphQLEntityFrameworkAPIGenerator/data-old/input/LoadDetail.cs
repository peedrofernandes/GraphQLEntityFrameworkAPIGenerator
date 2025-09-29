using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadDetail
{
    [Key]
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

    [ForeignKey("FeedbackParametersId")]
    [InverseProperty("LoadDetails")]
    public virtual FeedbackParameter? FeedbackParameters { get; set; }

    [ForeignKey("LoadId")]
    [InverseProperty("LoadDetails")]
    public virtual Load Load { get; set; } = null!;

    [InverseProperty("LoadDetail")]
    public virtual ICollection<LoadConfigurationsLoadDetail> LoadConfigurationsLoadDetails { get; set; } = new List<LoadConfigurationsLoadDetail>();

    [ForeignKey("PilotTypeId")]
    [InverseProperty("LoadDetails")]
    public virtual PilotType PilotType { get; set; } = null!;
}
