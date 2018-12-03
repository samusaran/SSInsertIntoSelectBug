using System;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace OrmLite.InsertIntoSelectIssue
{
    [Alias("LRARISULTATI")]
    [CompositeIndex("AANALISIID", "DRISULTATOID", "STATO", Unique = false, Name = "IDXLRARISULTATI")]
    public class LRARisultato : DBObject, IHasId<int>
    {
        [PrimaryKey]
        [AutoIncrement]
        [Alias("IDARISULTATO")]
        public int Id { get; set; }

        [Index]
        [Alias("AANALISIID")]
        public int AnalisiId { get; set; }

        [Required]
        [Alias("TIPOVALORE")]
        public int TipoValore { get; set; }

        [Alias("OPERATORERELAZIONALE")]
        public string OperatoreRelazionale { get; set; }

        [Alias("VALORENUMERICO")]
        public decimal? ValoreNumerico { get; set; }

        [Index]
        [Alias("DTESTOCODIFICATOID")]
        public int? TestoCodificatoId { get; set; }

        [Alias("TESTOLIBERO")]
        [StringLength(StringLengthAttribute.MaxText)]
        public string TestoLibero { get; set; }

        [Index]
        [Alias("DRISULTATOID")]
        public int RisultatoId { get; set; }

        [Required]
        [Alias("STATO")]
        public int Stato { get; set; }

        [Alias("INVIAREALIS")]
        public int InviareALIS { get; set; }

        [Alias("RISULTATOPRINCIPALE")]
        public int RisultatoPrincipale { get; set; }

        [Alias("TIPOINSERIMENTO")]
        public int TipoInserimento { get; set; }

        [Index]
        [Alias("DOPERATOREINSERIMENTOID")]
        public int? OperatoreInserimentoId { get; set; }

        [Index]
        [Alias("DDEVICEID")]
        public int? DeviceId { get; set; }

        [Index]
        [Alias("DLABORATORIOESECUTOREID")]
        public int? LaboratorioEsecutoreId { get; set; }

        [Alias("CITRATO")]
        public int Citrato { get; set; }

        [Alias("DATAORARIPETIZIONE")]
        public DateTime? DataOraRipetizione { get; set; }

        [Alias("DATAORAESECUZIONE")]
        public DateTime? DataOraEsecuzione { get; set; }

        [Alias("DATAORARICEZIONE")]
        public DateTime DataOraRicezione { get; set; }

        [Alias("IDENTIFICATIVODEVICE")]
        public string IdentificativoDevice { get; set; }

        [Alias("POSIZIONESUDEVICE")]
        public string PosizioneSuDevice { get; set; }

        [Alias("REAGENTE")]
        public string Reagente { get; set; }

        [Alias("LOTTOREAGENTE")]
        public string LottoReagente { get; set; }

        [Alias("DATASCADENZAREAGENTE")]
        public DateTime? DataScadenzaReagente { get; set; }

        [Alias("CURVADICALIBRAZIONE")]
        public string CurvaDiCalibrazione { get; set; }

        [Index]
        [Alias("DDILUIZIONEID")]
        public int? DiluizioneId { get; set; }

        [Index]
        [Alias("DRANGENORMALITAID")]
        public int? RangeNormalitaId { get; set; }

        [Index]
        [Alias("DRANGECONVALIDAID")]
        public int? RangeConvalidaId { get; set; }

        [Index]
        [Alias("DDELTACHECKSTORICOID")]
        public int? DeltaCheckStoricoId { get; set; }

        [Index]
        [Alias("DDELTACHECKROUTINEID")]
        public int? DeltaCheckRoutineId { get; set; }

        [Index]
        [Alias("DREGOLACONVALIDAID")]
        public int? RegolaConvalidaId { get; set; }

        [Alias("COMMENTO")]
        [StringLength(StringLengthAttribute.MaxText)]
        public string Commento { get; set; }

        [StringLength(250)]
        [Alias("RISULTATORAW")]
        public string RisultatoRaw { get; set; }

        [Index]
        [References(typeof(LRARisultato))]
        [Alias("ADELTARISULTATOSTORICODID")]
        public int? DeltaRisultatoStoricoId { get; set; }

        [Index]
        [References(typeof(LRARisultato))]
        [Alias("ADELTARISULTATOPRECEDENTEID")]
        public int? DeltaRisultatoPrecedenteId { get; set; }
    }
}