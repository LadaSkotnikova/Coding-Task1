using System;
using System.Collections.Generic;
using System.Text;
using cinema_project.Model;

namespace cinema_project.view_model
{
    public class cafekassir

    {
        private int chekCounter;
        List<dop> menu;

        public chekeda Sellessen(dop essenToSell)
        {
            chekeda mychek = new chekeda();
            //List<essen> items
            //double total
            //int id
            mychek.id = chekCounter + 1;
            chekCounter++;
            mychek.essen.Add(essenToSell, 1);
            mychek.itog = essenToSell.preis;
            return mychek;
        }
        public chekeda Sellessen(List<dop> essenToSell)
        {
            chekeda mychek = new chekeda();
            mychek.id = chekCounter + 1;
            chekCounter++;
            //присвоим список прямо в чек

            //начальное итого 0
            mychek.itog = 0;
            //перебираем всю еду в чеке и тащим их ценники
            foreach (dop mydop in essenToSell)
            {
                mychek.itog = mychek.itog + mydop.preis;
                mychek.essen.Add(mydop, 1);
            }
            return mychek;
        }
        public chekeda Sellessen(dop essenToSell, int quantity)
        {
            chekeda mychek = new chekeda();
            mychek.id = chekCounter + 1;
            chekCounter++;
            mychek.essen.Add(essenToSell, quantity);
            mychek.itog = essenToSell.preis * quantity;
            return mychek;
        }
        public chekeda Sellessen(Dictionary<dop, int> essentosell)
        //Добавление нового
        {
            chekeda mychek = new chekeda();
            mychek.id = chekCounter + 1;
            chekCounter++;
            foreach (KeyValuePair<dop, int> mydop in essentosell)
            {
                mychek.itog = mychek.itog + mydop.Key.preis * mydop.Value;
                mychek.essen.Add(mydop.Key, mydop.Value);
            }

            return mychek;
        }

        public void AddNewEssen(dop EssenToAdd)
        {
            menu.Add(EssenToAdd);
        }

        public void AddNewEssen(List<dop> EssenToAdd)
        {
            foreach (dop mydop in EssenToAdd)
            {
                menu.Add(mydop);
            }
        }

        public void RemoveEssen(dop EssenToMovie)
        {
            menu.Remove(EssenToMovie);
        }

        public void RemoveEssen(List<dop> EssenToRemove)
        {
            foreach (dop mydop in EssenToRemove)
            {
                menu.Remove(mydop);
            }
        }

        public cafekassir()
        {

        }
    }
    
}
