using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_NET_INMN3_hybryda__PA1_2.Models;

public class Miasto
{
    public int Id { get; set; }
    public string? Nazwa { get; set; }
    public ulong Populacja { get; set; }
    public decimal Powierzchnia { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Data założenia")]
    public DateTime DataZałożenia { get; set; }
    public string? Województwo { get; set; }
}
