using System;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace OrmLite.InsertIntoSelectIssue
{
    [Alias("LRARICHIESTE")]
    public class LRARichiesta : DBObject, IHasId<int>
    {
        [PrimaryKey]
        [AutoIncrement]
        [Alias("IDARICHIESTA")]
        public int Id { get; set; }

        [Index]
        [Alias("APAZIENTEID")]
        public int PazienteId { get; set; }

        [Required]
        [Alias("NUMERORICHIESTA")]
        public string NumeroRichiesta { get; set; }

        [Alias("NUMERORICOVERO")]
        public string NumeroRicovero { get; set; }

        [Required]
        [Index(Unique = false)]
        [Alias("DATAORAACCETTAZIONE")]
        public DateTime DataOraAccettazione { get; set; }

        [Required]
        [Index(Unique = false)]
        [Alias("DATAORAPRELIEVO")]
        public DateTime DataOraPrelievo { get; set; }

        [Alias("ETAPAZIENTE")]
        public int? EtaPaziente { get; set; }

        [Alias("UNITADIMISURAETAPAZIENTE")]
        public int UnitaDiMisuraEtaPaziente { get; set; }

        [Alias("SETTIMANEGRAVIDANZA")]
        public int? SettimaneGravidanza { get; set; }

        [Index]
        [Alias("DREPARTOID")]
        public int? RepartoId { get; set; }

        [Index]
        [Alias("DDEVICEID")]
        public int? DeviceId { get; set; }

        [Index]
        [Alias("DPRIORITAID")]
        public int PrioritaId { get; set; }

        [Index]
        [Alias("DLABORATORIORICHIEDENTEID")]
        public int? LaboratorioRichiedenteId { get; set; }

        [Alias("STATO")]
        [Default(1)]
        public int Stato { get; set; }

        [Index]
        [Alias("DTIPOCONVALIDAID")]
        public int? TipoConvalidaId { get; set; }

        [Reference]
        [Alias("DATAORAVALIDAZIONE")]
        public DateTime? DataOraValidazione { get; set; }

        [Alias("DATAORAESECUZIONE")]
        public DateTime? DataOraEsecuzione { get; set; }

        [Alias("COMMENTO")]
        [StringLength(StringLengthAttribute.MaxText)]
        public string Commento { get; set; }

        [Required]
        [Alias("ARCHIVIATA")]
        public int Archiviata { get; set; }

        [Alias("VALIDAZIONEAUTOMATICA")]
        public int? ValidazioneAutomatica { get; set; }
    }
}