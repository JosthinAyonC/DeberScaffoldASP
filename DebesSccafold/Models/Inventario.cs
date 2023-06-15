using System;
using System.Collections.Generic;

namespace DebesSccafold.Models;

public partial class Inventario
{
    public int Idproducto { get; set; }

    public int Cantidad { get; set; }

    public virtual Producto IdproductoNavigation { get; set; } = null!;
}
