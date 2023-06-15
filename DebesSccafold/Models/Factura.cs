using System;
using System.Collections.Generic;

namespace DebesSccafold.Models;

public partial class Factura
{
    public int Nrofactura { get; set; }

    public int Idventa { get; set; }

    public decimal Total { get; set; }

    public virtual Ventum IdventaNavigation { get; set; } = null!;
}
