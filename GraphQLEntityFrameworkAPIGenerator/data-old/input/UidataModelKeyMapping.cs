using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIDataModelKeyMapping")]
public partial class UidataModelKeyMapping
{
    [Key]
    [Column("UIDataModelKeyMappingId")]
    public Guid UidataModelKeyMappingId { get; set; }

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

    [Column("N_Items")]
    public byte NItems { get; set; }

    public byte? FunctionLabelId0 { get; set; }

    public Guid? KeyModifierId0 { get; set; }

    public byte? FunctionLabelId1 { get; set; }

    public Guid? KeyModifierId1 { get; set; }

    public byte? FunctionLabelId2 { get; set; }

    public Guid? KeyModifierId2 { get; set; }

    public byte? FunctionLabelId3 { get; set; }

    public Guid? KeyModifierId3 { get; set; }

    public byte? FunctionLabelId4 { get; set; }

    public Guid? KeyModifierId4 { get; set; }

    public byte? FunctionLabelId5 { get; set; }

    public Guid? KeyModifierId5 { get; set; }

    public byte? FunctionLabelId6 { get; set; }

    public Guid? KeyModifierId6 { get; set; }

    public byte? FunctionLabelId7 { get; set; }

    public Guid? KeyModifierId7 { get; set; }

    public byte? FunctionLabelId8 { get; set; }

    public Guid? KeyModifierId8 { get; set; }

    public byte? FunctionLabelId9 { get; set; }

    public Guid? KeyModifierId9 { get; set; }

    [ForeignKey("KeyModifierId0")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId0Navigations")]
    public virtual Modifier? KeyModifierId0Navigation { get; set; }

    [ForeignKey("KeyModifierId1")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId1Navigations")]
    public virtual Modifier? KeyModifierId1Navigation { get; set; }

    [ForeignKey("KeyModifierId2")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId2Navigations")]
    public virtual Modifier? KeyModifierId2Navigation { get; set; }

    [ForeignKey("KeyModifierId3")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId3Navigations")]
    public virtual Modifier? KeyModifierId3Navigation { get; set; }

    [ForeignKey("KeyModifierId4")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId4Navigations")]
    public virtual Modifier? KeyModifierId4Navigation { get; set; }

    [ForeignKey("KeyModifierId5")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId5Navigations")]
    public virtual Modifier? KeyModifierId5Navigation { get; set; }

    [ForeignKey("KeyModifierId6")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId6Navigations")]
    public virtual Modifier? KeyModifierId6Navigation { get; set; }

    [ForeignKey("KeyModifierId7")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId7Navigations")]
    public virtual Modifier? KeyModifierId7Navigation { get; set; }

    [ForeignKey("KeyModifierId8")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId8Navigations")]
    public virtual Modifier? KeyModifierId8Navigation { get; set; }

    [ForeignKey("KeyModifierId9")]
    [InverseProperty("UidataModelKeyMappingKeyModifierId9Navigations")]
    public virtual Modifier? KeyModifierId9Navigation { get; set; }

    [InverseProperty("UidataModelKeyMapping")]
    public virtual ICollection<UidataModelTranslationDetail> UidataModelTranslationDetails { get; set; } = new List<UidataModelTranslationDetail>();
}
