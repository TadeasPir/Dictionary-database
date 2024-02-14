using DatabazeMineraly;
using Dictionary_database.databaseFiles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_database
{
    public class DictionaryConsole
    {

        public void Start()
        {
            try
            {
                MainMenu();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Problem with access to DB.");
            }
            Console.WriteLine("End");
        }
        public void MainMenu()
        {
            Menu menu = new Menu("Select one option: ");
            menu.Add(new MenuItem("Search for trantations of czech word in eglish",
                new Action(() =>
                {
                    var m = MenuCZdictionary();
                    var item = m.Execute();
                    item.Execute();
                })));
            menu.Add(new MenuItem("Search for trantations of english word in czech",
                new Action(() =>
                {
                    var m = MenuMinerals();
                    var item = m.Execute();
                    item.Execute();
                })));
            menu.Add(new MenuItem("Exit program", new Action(() => { exit = true; })));

            while (!exit)
            {
                var item = menu.Execute();
                item.Execute();
            }
        }

        private bool exit = false;
        private Menu MenuCZdictionary()
        {
            Menu m = new Menu("Select stone: ");
            CZdictionaryDAO czDAO = new CZdictionaryDAO();

            ENdictionaryDAO enDAO = new ENdictionaryDAO();
            foreach (var cz in CZdictionaryDAO.GetAll())
            {
                m.Add(new MenuItem(cz.ToString(), new Action(() =>
                {
                    string effectsFound = string.Join(", ",
                        enDAO.GetByMineral(cz).Select(m => m.Purpose));
                    Console.WriteLine(effectsFound);
                })));
            }
            return m;
        }

        private Menu MenuEffects()
        {
            Menu m = new Menu("Select effect: ");
            EffectDAO effectsDAO = new EffectDAO();

            MineralEfektsDAO med = new MineralEfektsDAO();
            foreach (var eff in effectsDAO.GetAll())
            {
                m.Add(new MenuItem(eff.ToString(), new Action(() =>
                {
                    string mineralsFound = string.Join(',',
                        med.GetByEffect(eff).Select(e => e.Name));
                    Console.WriteLine(mineralsFound);
                })));
            }
            return m;
        }

    }
}
