using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class VisualBoardType
{
    [Key]
    public byte VisualBoardTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VisualBoardTypeDsc { get; set; } = null!;

    [Column("UIMicro")]
    public bool Uimicro { get; set; }

    [Column("UISelectorCompressionAllowed")]
    public bool UiselectorCompressionAllowed { get; set; }

    public bool DynamicTimeToEnd { get; set; }

    public bool EcoPowerSave { get; set; }

    public bool WeightSensor { get; set; }

    public bool LongFill { get; set; }

    [Column("CompressionMethod_1")]
    public bool CompressionMethod1 { get; set; }

    [Column("CompressionMethod_2")]
    public bool CompressionMethod2 { get; set; }

    [Column("CompressionMethod_3")]
    public bool CompressionMethod3 { get; set; }

    [Column("UIEepromSize")]
    public bool UieepromSize { get; set; }

    public bool HasVisualBoardTypeDisplacement { get; set; }

    [Column("128CyclesEnabled")]
    public bool _128cyclesEnabled { get; set; }

    public bool AutoStart { get; set; }

    public bool TimeToEndTo512 { get; set; }

    public bool SupportsBeforeFaultCycle { get; set; }

    public bool OffStandByEnabled { get; set; }

    public bool Supports7Fabrics { get; set; }

    public byte OscillatingGroup { get; set; }

    public bool SupportsWordCapacitiveTouchParamsFingerThresholds { get; set; }

    public bool HasConnectivityPointers { get; set; }

    public bool PerformCheckOnWaterLevels { get; set; }

    public bool HasExtendedCycleSubHeading { get; set; }

    [InverseProperty("VisualBoardType")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("VisualBoardTypeId")]
    [InverseProperty("VisualBoardTypes")]
    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();
}
