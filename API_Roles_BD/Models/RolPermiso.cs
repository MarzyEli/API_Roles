namespace Entities
{
    public class RolPermiso
    {
        public long IdRolPermiso { get; set; }
        public long IdRol { get; set; }
        public long IdPermiso { get; set; }
        public bool Activo { get; set; }
    }

    public class RolPermisoCustom
    {
        public long IdRolPermiso { get; set; }
        public long IdRol { get; set; }
        public string Rol { get; set; }
        public long IdPermiso { get; set; }
        public string Permiso { get; set; }
        public bool Activo { get; set; }
    }
}