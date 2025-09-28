using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIInputEventMappingDetails")]
public partial class UiinputEventMappingDetail
{
    [Key]
    [Column("UIInputEventMappingDetailsId")]
    public Guid UiinputEventMappingDetailsId { get; set; }

    [Column("LLIReadTypeId")]
    public byte LlireadTypeId { get; set; }

    [Column("LLIReadTypePosition")]
    public byte LlireadTypePosition { get; set; }

    public byte Compartment { get; set; }

    public byte NumberOfInputEvents { get; set; }

    public byte Value1 { get; set; }

    public int InputEvent1 { get; set; }

    public byte Value2 { get; set; }

    public int InputEvent2 { get; set; }

    public byte Value3 { get; set; }

    public int InputEvent3 { get; set; }

    public byte Value4 { get; set; }

    public int InputEvent4 { get; set; }

    public byte Value5 { get; set; }

    public int InputEvent5 { get; set; }

    public byte Value6 { get; set; }

    public int InputEvent6 { get; set; }

    public byte Value7 { get; set; }

    public int InputEvent7 { get; set; }

    public byte Value8 { get; set; }

    public int InputEvent8 { get; set; }

    public byte Value9 { get; set; }

    public int InputEvent9 { get; set; }

    public byte Value10 { get; set; }

    public int InputEvent10 { get; set; }

    [Column("UIGIReadTypeId")]
    public byte UigireadTypeId { get; set; }

    [Column("UIGIReadTypePosition")]
    public byte UigireadTypePosition { get; set; }

    public byte Value11 { get; set; }

    public int InputEvent11 { get; set; }

    public byte Value12 { get; set; }

    public int InputEvent12 { get; set; }

    public byte Value13 { get; set; }

    public int InputEvent13 { get; set; }

    public byte Value14 { get; set; }

    public int InputEvent14 { get; set; }

    public byte Value15 { get; set; }

    public int InputEvent15 { get; set; }

    public byte Value16 { get; set; }

    public int InputEvent16 { get; set; }

    public byte Value17 { get; set; }

    public int InputEvent17 { get; set; }

    public byte Value18 { get; set; }

    public int InputEvent18 { get; set; }

    public byte Value19 { get; set; }

    public int InputEvent19 { get; set; }

    public byte Value20 { get; set; }

    public int InputEvent20 { get; set; }

    public byte Value21 { get; set; }

    public int InputEvent21 { get; set; }

    public byte Value22 { get; set; }

    public int InputEvent22 { get; set; }

    public byte Value23 { get; set; }

    public int InputEvent23 { get; set; }

    public byte Value24 { get; set; }

    public int InputEvent24 { get; set; }

    public byte Value25 { get; set; }

    public int InputEvent25 { get; set; }

    public byte Value26 { get; set; }

    public int InputEvent26 { get; set; }

    public byte Value27 { get; set; }

    public int InputEvent27 { get; set; }

    public byte Value28 { get; set; }

    public int InputEvent28 { get; set; }

    public byte Value29 { get; set; }

    public int InputEvent29 { get; set; }

    public byte Value30 { get; set; }

    public int InputEvent30 { get; set; }

    public byte Value31 { get; set; }

    public int InputEvent31 { get; set; }

    public byte Value32 { get; set; }

    public int InputEvent32 { get; set; }

    [InverseProperty("UiinputEventMappingDetails")]
    public virtual ICollection<UiinputEventMappingConfigurationsUiinputEventMappingDetail> UiinputEventMappingConfigurationsUiinputEventMappingDetails { get; set; } = new List<UiinputEventMappingConfigurationsUiinputEventMappingDetail>();
}
