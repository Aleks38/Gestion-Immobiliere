using WPF_TP.Data.Models;

namespace TestUnitaire
{
    [TestClass]
    public class PretTest
    {
        [TestMethod]
        public void TestcalculerCapitalRestant()
        {

            // Nouveau pret - Today
            int mensualiteToday = 5000;
            int dureeToday = 10;
            Pret pretToday = new Pret(10000, mensualiteToday, dureeToday, DateTime.Today);
            int capitalRestantToday = pretToday.capitalRestant();
            Assert.AreEqual(mensualiteToday * dureeToday, capitalRestantToday);

            // Pret terminé - Ended
            DateTime dateEnd = new DateTime(2010, 01, 22);
            Pret pretEnd = new Pret(10000, mensualiteToday, dureeToday, dateEnd);
            int capitalRestantEnd = pretEnd.capitalRestant();
            Assert.AreEqual(0, capitalRestantEnd);
        }
    }
}