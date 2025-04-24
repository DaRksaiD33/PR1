using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class TitlesStasuse
{
    public int Id { get; set; }

    public short IdStatus { get; set; }

    public int IdAnime { get; set; }

    public DateOnly? DateStatus { get; set; }

    public virtual AnimeTitle Anime { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
