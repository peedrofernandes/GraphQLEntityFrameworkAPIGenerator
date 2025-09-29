using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionIPCDetails")]
public partial class InductionIpcdetail
{
    [Key]
    [Column("InductionIPCId")]
    public Guid InductionIpcid { get; set; }

    public bool SyncSerial { get; set; }

    public bool MasterSlave { get; set; }

    public bool HalfBridgeQuasiResonant { get; set; }

    public Guid? ZeroCrossChannel0Id { get; set; }

    public Guid? ZeroCrossChannel1Id { get; set; }

    public Guid? ZeroCrossChannel2Id { get; set; }

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

    public bool InfinitePotLoss { get; set; }

    public byte HeatsinkFanLoadIndex { get; set; }

    public byte NumberOfCoins { get; set; }

    public byte MainRelayLoadIndex { get; set; }

    public Guid? InductionIpcSpecificDataId { get; set; }

    public byte InverterTechnology { get; set; }

    public Guid? IpcSpecificSafetyParamsId { get; set; }

    [InverseProperty("InductionIpc")]
    public virtual ICollection<InductionCooktopOrgConfigurationsInductionIpcdetail> InductionCooktopOrgConfigurationsInductionIpcdetails { get; set; } = new List<InductionCooktopOrgConfigurationsInductionIpcdetail>();

    [ForeignKey("InductionIpcSpecificDataId")]
    [InverseProperty("InductionIpcdetails")]
    public virtual InductionIpcSpecificDatum? InductionIpcSpecificData { get; set; }

    [InverseProperty("InductionIpc")]
    public virtual ICollection<InductionIpcdetailsInductionCoilConfig> InductionIpcdetailsInductionCoilConfigs { get; set; } = new List<InductionIpcdetailsInductionCoilConfig>();

    [ForeignKey("IpcSpecificSafetyParamsId")]
    [InverseProperty("InductionIpcdetails")]
    public virtual IpcSpecificSafetyParam? IpcSpecificSafetyParams { get; set; }

    [ForeignKey("ZeroCrossChannel0Id")]
    [InverseProperty("InductionIpcdetailZeroCrossChannel0s")]
    public virtual InductionZeroCrossConfiguration? ZeroCrossChannel0 { get; set; }

    [ForeignKey("ZeroCrossChannel1Id")]
    [InverseProperty("InductionIpcdetailZeroCrossChannel1s")]
    public virtual InductionZeroCrossConfiguration? ZeroCrossChannel1 { get; set; }

    [ForeignKey("ZeroCrossChannel2Id")]
    [InverseProperty("InductionIpcdetailZeroCrossChannel2s")]
    public virtual InductionZeroCrossConfiguration? ZeroCrossChannel2 { get; set; }
}
