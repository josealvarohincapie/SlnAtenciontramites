namespace AtencionTramites.Model.ModelAtencionTramites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogo.SubTipoDocumento")]
    public partial class SubTipoDocumento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubTipoDocumento()
        {
            Radicado = new HashSet<Radicado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigo { get; set; }

        public int? CodigoTipoDocumento { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public int? DiasVencimiento { get; set; }

        public int? HorasVencimiento { get; set; }

        [StringLength(250)]
        public string GrupoValidadores { get; set; }

        public bool Habilitado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radicado> Radicado { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
