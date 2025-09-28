using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadSRMultiplex")]
public partial class PrmReadSrmultiplex
{
    [Key]
    public Guid Id { get; set; }

    public byte? NumberOfInputPins { get; set; }

    public byte? InputPin1 { get; set; }

    public byte? InputPin2 { get; set; }

    public byte? InputPin3 { get; set; }

    public byte? InputPin4 { get; set; }

    public byte? InputPin5 { get; set; }

    public byte? InputPin6 { get; set; }

    public byte? InputPin7 { get; set; }

    public byte? InputPin8 { get; set; }

    public byte? InputPin9 { get; set; }

    public byte? InputPin10 { get; set; }

    public byte? InputPin11 { get; set; }

    public byte? InputPin12 { get; set; }

    public byte? InputPin13 { get; set; }

    public byte? InputPin14 { get; set; }

    public byte? InputPin15 { get; set; }

    public byte? InputPin16 { get; set; }

    public byte? SelectPin { get; set; }

    public byte? FeedbackPin { get; set; }
}
