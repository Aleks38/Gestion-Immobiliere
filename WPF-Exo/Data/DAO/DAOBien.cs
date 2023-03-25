using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_TP.Data.DAO
{
    public class DAOBien
    {
        public List<Pret> findPret()
        {
            List<Pret> listPret = new List<Pret>();
            ImoContext ctx = ImoContext.getInstance();
            foreach (Pret pret in ctx.Pret)
            {
                ImoContext ctx2 = new ImoContext();

                Biens theBien = ctx2.Biens.Where(b => b.Pret.PretId == pret.PretId).FirstOrDefault();
                if (theBien != null)
                {
                    listPret.Add(pret);
                }
            }
            return listPret;
        }

        public List<Biens> findBiens()
        {
            ImoContext ctx = ImoContext.getInstance();
            List<Biens> listBiens = new List<Biens>();
            foreach(Biens bien in ctx.Biens)
            {
                listBiens.Add(bien);
            }

            return listBiens;
        }

        public int detteMensuel()
        {
            int detteMensuel = 0;
            ImoContext ctx = ImoContext.getInstance();
            foreach (Pret pret in ctx.Pret)
            {
                ImoContext ctx2 = new ImoContext();

                Biens theBien = ctx2.Biens.Where(b => b.Pret.PretId == pret.PretId).FirstOrDefault();
                if (theBien != null)
                {
                    detteMensuel += pret.Mensualite;
                }
            }

            return detteMensuel;
        }
    }
}
