using System;
using System.Collections.Generic;

namespace ProyectoPaginasWeb.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int Permisos { get; set; }
}
