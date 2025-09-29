using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("Id", "PrmUiaudioBuzzerDetailsId", "Index")]
[Table("UIAudioBuzzer_UIAudioBuzzerDetails")]
public partial class UiaudioBuzzerUiaudioBuzzerDetail
{
    [Key]
    public Guid Id { get; set; }

    [Key]
    [Column("PrmUIAudioBuzzerDetailsId")]
    public Guid PrmUiaudioBuzzerDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("UiaudioBuzzerUiaudioBuzzerDetails")]
    public virtual PrmUiaudioBuzzer IdNavigation { get; set; } = null!;

    [ForeignKey("PrmUiaudioBuzzerDetailsId")]
    [InverseProperty("UiaudioBuzzerUiaudioBuzzerDetails")]
    public virtual UiaudioBuzzerDetail PrmUiaudioBuzzerDetails { get; set; } = null!;
}
