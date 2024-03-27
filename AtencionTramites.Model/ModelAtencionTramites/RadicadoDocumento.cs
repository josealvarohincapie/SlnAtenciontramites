namespace AtencionTramites.Model.ModelAtencionTramites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RadicadoDocumento")]
    public partial class RadicadoDocumento
    {
        [Key]
        public Guid CodigoRadicadoDocumento { get; set; }

        public long CodigoSolicitud { get; set; }

        [Required]
        [StringLength(2000)]
        public string RutaFisicaArchivo { get; set; }

        [Required]
        [StringLength(2000)]
        public string RutaVirtualArchivo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TamanoArchivo { get; set; }

        [Required]
        [StringLength(250)]
        public string TituloArchivo { get; set; }

        public DateTime FechaCreacion { get; set; }
        
        [StringLength(50)]
        public string Etapa { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreUsuarioCreacion { get; set; }

        [Required]
        [StringLength(250)]
        public string IDUsuarioCreacion { get; set; }
    }
}
