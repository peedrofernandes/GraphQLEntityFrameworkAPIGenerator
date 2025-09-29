using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmBrowningDoneness")]
public partial class CycleOptionsPrmBrowningDoneness
{
    [Key]
    public Guid BrowningDonenessOptionsId { get; set; }

    public byte DefaultSelection { get; set; }

    public byte GroupingDesignation { get; set; }

    public bool ConfigureTime { get; set; }

    public bool ConfigureTemp { get; set; }

    public bool Option1 { get; set; }

    public short Time1 { get; set; }

    public float Temp1 { get; set; }

    public bool Option2 { get; set; }

    public short Time2 { get; set; }

    public float Temp2 { get; set; }

    public bool Option3 { get; set; }

    public short Time3 { get; set; }

    public float Temp3 { get; set; }

    public bool Option4 { get; set; }

    public short Time4 { get; set; }

    public float Temp4 { get; set; }

    public bool Option5 { get; set; }

    public short Time5 { get; set; }

    public float Temp5 { get; set; }

    public byte TemperatureType { get; set; }

    public byte TimeType { get; set; }
}
