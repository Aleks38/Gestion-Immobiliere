
using WPF_TP.Data.Models;

namespace TestUnitaire
{
    [TestClass]
    public class BiensTest
    {
        [TestMethod]
        public void TestCalculerRentabiliteNetMensuel()
        {

            Box unBien = new Box("Appartement", "1 passage de soubisse", 500000, 200);

            //Sans pret + sans locataire
            int rentaWPretAndLocataire = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaWPretAndLocataire == 0);


            //Sans locataire + avec pret
            unBien.Pret = new Pret(10000, 500, 10, DateTime.Today);

            int rentaWLocataire = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaWLocataire < 0);



            List<Locataire> listLocataire = new List<Locataire>();
            listLocataire.Add(new Locataire("Alexy", "Da Silva", 19, "Developpeur"));

            // Rentabilite sans pret
            DateTime dateDebutWPret = new DateTime(2020, 5, 1);
            DateTime? dateFinWPret = null;

            List<Contrat> listContratWPret = new List<Contrat>();
            listContratWPret.Add(new Contrat(500, dateDebutWPret, dateFinWPret, listLocataire, unBien));
            unBien.ListContrat = listContratWPret;

            int rentaWPret = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaWPret >= 0);


            // Rentabilite négatif
            unBien.Pret = new Pret(10000, 5000, 10, DateTime.Today);

            DateTime dateDebutNega = new DateTime(2020, 5, 1);
            DateTime? dateFinNega = null;

            List<Contrat> listContratNega = new List<Contrat>();
            listContratNega.Add(new Contrat(400, dateDebutNega, dateFinNega, listLocataire, unBien));
            unBien.ListContrat = listContratNega;
            
            int rentaNega = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaNega < 0);


            // Rentabilite 0
            unBien.Pret = new Pret(1000, 500, 24, DateTime.Today);

            DateTime dateDebutNull = new DateTime(2020, 5, 1);
            DateTime? dateFinNull = null;

            List<Contrat> listContratNull = new List<Contrat>();
            listContratNull.Add(new Contrat(500, dateDebutNull, dateFinNull, listLocataire, unBien));
            unBien.ListContrat = listContratNull;

            int rentaNull = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaNull == 0);


            // Rentabilite positif
            unBien.Pret = new Pret(1000, 500, 24, DateTime.Today);
            DateTime dateDebut = new DateTime(2020, 5, 1);
            DateTime? dateFin = null;

            List<Contrat> listContrat = new List<Contrat>();
            listContrat.Add(new Contrat(600, dateDebut, dateFin, listLocataire, unBien));
            unBien.ListContrat = listContrat;
            
            int rentaPosi = unBien.calculerRentabiliteNetMensuel();
            Assert.IsTrue(rentaPosi > 0);

        }
    }
}
