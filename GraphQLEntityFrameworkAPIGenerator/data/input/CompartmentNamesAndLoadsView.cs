using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class CompartmentNamesAndLoadsView
{
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public byte CompartmentType { get; set; }

    public Guid ProjectId { get; set; }

    public byte Index { get; set; }

    public int RelayEnable { get; set; }

    public int Dlb { get; set; }

    public int Bake { get; set; }

    public int Broil1 { get; set; }

    public int Broil2 { get; set; }

    public int ConvElement1 { get; set; }

    public int ConvElement2 { get; set; }

    public int ConvFan1 { get; set; }

    public int ConvFan2 { get; set; }

    public int LatchMotor { get; set; }

    public int Light { get; set; }

    public int ForcedConvValve { get; set; }

    public int Magnetron { get; set; }

    public int TurnTable { get; set; }

    public byte Version { get; set; }

    public byte MinimumOnTime { get; set; }

    public byte MinimumOffTime { get; set; }

    public int Temperature1 { get; set; }

    public int Temperature2 { get; set; }

    public int MeatProbe { get; set; }

    public int DoorSwitch { get; set; }

    public int LatchSwitch { get; set; }

    [Column("DLBFeedbackIndex")]
    public int DlbfeedbackIndex { get; set; }

    public int HumiditySensor { get; set; }

    public int LoadsFeedbackIndex { get; set; }

    public bool HallEffectSensorPresent { get; set; }

    public int NumberOfCoolingFans { get; set; }

    public int Fan1LoadId { get; set; }

    [Column("Fan1SpeedGI")]
    public int Fan1SpeedGi { get; set; }

    public int Fan2LoadId { get; set; }

    [Column("Fan2SpeedGI")]
    public int Fan2SpeedGi { get; set; }

    public int BackupRestore { get; set; }

    public int Light2 { get; set; }

    public int SecondaryDoorSwitch { get; set; }

    public int ToastSensor { get; set; }

    public int SecondaryDlb { get; set; }

    public int SecondaryDlbFeedbackIndex { get; set; }

    public int SecondaryRelayEnable { get; set; }
}
