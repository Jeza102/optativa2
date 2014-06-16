using System.Data.Entity;

namespace aplicacionOptativa2.Models
{
    public class aplicacionOptativa2Context : DbContext
    {
        // Puede agregar código personalizado a este archivo. Los cambios no se sobrescribirán.
        // 
        // Si desea que Entity Framework lo omita y regenere la base de datos
        // automáticamente siempre que cambie el esquema de modelo, agregue
        // el siguiente código al método Application_Start en el archivo Global.asax.
        // Nota: esta operación destruirá y volverá a crear la base de datos con cada cambio de modelo.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<aplicacionOptativa2.Models.aplicacionOptativa2Context>());

        public aplicacionOptativa2Context() : base("name=aplicacionOptativa2Context")
        {
        }

        public DbSet<mascota> mascotas { get; set; }
    }
}
