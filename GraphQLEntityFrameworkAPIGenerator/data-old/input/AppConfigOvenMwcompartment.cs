using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("AppConfigOvenMWCompartment")]
public partial class AppConfigOvenMwcompartment
{
    [Key]
    public Guid Id { get; set; }

    public byte RelayEnable { get; set; }

    public byte Dlb { get; set; }

    public byte Bake { get; set; }

    public byte Broil1 { get; set; }

    public byte Broil2 { get; set; }

    public byte ConvElement1 { get; set; }

    public byte ConvElement2 { get; set; }

    public byte ConvFan1 { get; set; }

    public byte ConvFan2 { get; set; }

    public byte LatchMotor { get; set; }

    public byte Temperature1 { get; set; }

    public byte Temperature2 { get; set; }

    public byte MeatProbe { get; set; }

    public byte DoorSwitch { get; set; }

    public byte LatchSwitch { get; set; }

    public byte Light { get; set; }

    public byte Magnetron { get; set; }

    public byte ForcedConvValve { get; set; }

    public byte TurnTable { get; set; }

    public byte HumiditySensor { get; set; }

    [Column("DLBFeedbackIndex")]
    public byte DlbfeedbackIndex { get; set; }

    public byte BackupRestore { get; set; }

    public byte LoadsFeedbackIndex { get; set; }

    public byte BakeFeedbackIndex { get; set; }

    public byte BakeRelayEnable { get; set; }

    public byte Broil1FeedbackIndex { get; set; }

    public byte Broil1RelayEnable { get; set; }

    public byte Broil2FeedbackIndex { get; set; }

    public byte Broil2RelayEnable { get; set; }

    public byte ConvElement1FeedbackIndex { get; set; }

    public byte ConvElement1RelayEnable { get; set; }

    public byte ConvElement2FeedbackIndex { get; set; }

    public byte ConvElement2RelayEnable { get; set; }

    public byte LatchFeedbackIndex { get; set; }

    public byte LatchRelayEnable { get; set; }

    public byte MagnetronFeedbackIndex { get; set; }

    public byte MagnetronRelayEnable { get; set; }

    public byte TurnTableFeedbackIndex { get; set; }

    public byte TurnTableRelayEnable { get; set; }

    public byte Light2 { get; set; }

    public byte SecondaryDoorSwitch { get; set; }

    public byte ToastSensor { get; set; }

    public byte SecondaryDlb { get; set; }

    public byte SecondaryDlbFeedbackIndex { get; set; }

    public byte SecondaryRelayEnable { get; set; }

    [InverseProperty("OvenMwcompartment")]
    public virtual ICollection<AppConfigCompartmentDetail> AppConfigCompartmentDetails { get; set; } = new List<AppConfigCompartmentDetail>();
}
