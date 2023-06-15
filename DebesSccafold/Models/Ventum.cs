using System;
using System.Collections.Generic;

namespace DebesSccafold.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public int Idproducto { get; set; }

    public int Idcliente { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cliente IdclienteNavigation { get; set; } = null!;

    public virtual Producto IdproductoNavigation { get; set; } = null!;
}
