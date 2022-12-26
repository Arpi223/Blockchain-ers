using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Client
    {
        private string id;
        private string vrednost;
        private string datum;
        private string povratna;

        public string Id
        { get { return id; } set { id = value; } }
        public string Vrednost
        { get { return id; } set { id = value; } }
        public string Datum
        { get { return datum; } set { datum = value; } }
        public string Povratna
        { get { return povratna; } set { povratna = value; } }

         DateTime localDate = DateTime.Now;
        public Client()
        {
           id = "0";
           vrednost = "0";
           datum = localDate.ToString();
/*
           Console.WriteLine(id);
           Console.WriteLine(vrednost);
           Console.WriteLine(datum);
*/
            povratna = id + "-" + vrednost + "-" + datum;
           // Console.WriteLine(povratna);
            

        }

        public Client(string id, string vrednost)
        {
            this.id = id;
            this.vrednost = vrednost;
            this.datum = localDate.ToString();

           povratna = id + "-" + vrednost + "-" + datum;


        //Console.WriteLine(povratna);

        }
    }
    }
