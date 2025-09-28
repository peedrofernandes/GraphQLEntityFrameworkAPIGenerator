using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAudioBuzzerDetails")]
public partial class UiaudioBuzzerDetail
{
    [Key]
    [Column("PrmUIAudioBuzzerDetailsId")]
    public Guid PrmUiaudioBuzzerDetailsId { get; set; }

    public short Frequency { get; set; }

    public short TimeOn { get; set; }

    public short TimeOff { get; set; }

    [InverseProperty("PrmUiaudioBuzzerDetails")]
    public virtual ICollection<UiaudioBuzzerUiaudioBuzzerDetail> UiaudioBuzzerUiaudioBuzzerDetails { get; set; } = new List<UiaudioBuzzerUiaudioBuzzerDetail>();
}
