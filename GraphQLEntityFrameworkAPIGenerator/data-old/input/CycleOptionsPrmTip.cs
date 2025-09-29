using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsPrmTip
{
    [Key]
    public Guid TipsOptionsId { get; set; }

    public byte NumberOfTips { get; set; }

    public int Key1 { get; set; }

    public int Value1 { get; set; }

    public int? Key2 { get; set; }

    public int? Value2 { get; set; }

    public int? Key3 { get; set; }

    public int? Value3 { get; set; }

    public int? Key4 { get; set; }

    public int? Value4 { get; set; }

    public int? Key5 { get; set; }

    public int? Value5 { get; set; }
}
