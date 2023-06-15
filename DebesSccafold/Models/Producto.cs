using System;
using System.Collections.Generic;

namespace DebesSccafold.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
