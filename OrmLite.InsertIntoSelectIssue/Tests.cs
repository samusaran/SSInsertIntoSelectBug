using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using NUnit.Framework;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Converters;
using ServiceStack.OrmLite.SqlServer.Converters;

namespace OrmLite.InsertIntoSelectIssue
{
    [TestFixture]
    public class Tests
    {
        public OrmLiteConnectionFactory DbFactory { get; set; }

        [OneTimeSetUp]
        public void Setup()
        {
            var dialectProvider = SqlServerDialect.Provider;
            dialectProvider.RegisterConverter<DateTime>(new SqlServerDateTime2Converter()); // this seems to break everything

            string connectionString = new SqlConnectionStringBuilder
            {
                DataSource = "(local)",
                InitialCatalog = "SSTest",
                IntegratedSecurity = true
            }.ToString();

            DbFactory = new OrmLiteConnectionFactory(connectionString, dialectProvider);
        }


        [Test]
        public void Check_InsertIntoSelect()
        {
            using (var db = DbFactory.OpenDbConnection())
            {
                db.DropAndCreateTable<LRARichiesta>();
                db.DropAndCreateTable<LRARisultato>();

                long numeroRichieste = db.Count<LRARichiesta>();

                var q = db.From<LRARichiesta>()
                    .Select(ric => new //LRARisultato
                    {
                        AnalisiId = 1,
                        Commento = ric.Commento,
                        TipoValore = 1,
                        Stato = 1,
                        RisultatoId = 1,
                        DataOraRicezione = DateTime.UtcNow,
                        DataModifica = DateTime.UtcNow,
                        VersioneRecord = 1
                    });

                long result = db.InsertIntoSelect<LRARisultato>(q);

                Assert.That(result, Is.EqualTo(numeroRichieste));
            }
        }
    }
}