using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusesName { get; set; } = null!;

    public virtual ICollection<TitlesStasuse> TitlesStasuses { get; set; } = new List<TitlesStasuse>();
}
