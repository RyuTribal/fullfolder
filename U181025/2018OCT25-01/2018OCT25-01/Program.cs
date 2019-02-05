using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018OCT25_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD d = new DVD();
            d.id = "CJ";
            d.Play();

            IDisplay anka;
            anka = d;

            d.id = "XXX671";

            anka.Play();

            Washer w = new Washer();
            w.Play();

            anka = w;
            anka.Play();


            anka = new BluRay();
            anka.Play();

            List<IDisplay> machines = new List<IDisplay>();
            machines.Add(new Washer());
            machines.Add(new DVD() { id = "UYUYUYU"});
            machines.Add(new BluRay());

            foreach(var item in machines)
            {
                Console.WriteLine(item.GetType().Name);
                item.Play();

                if(item.GetType().Name == "DVD")
                {
                    Console.WriteLine(((DVD)item).id);
                }
            }
        }

        public class DVD : IDisplay
        {
            public string id { get; set; }
            public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Play()
            {
                Console.WriteLine("DVD {0} is playing...", id);
            }
        }

        public class Washer : IDisplay
        {
            public string model { get; set; }
            public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Play()
            {
                Console.WriteLine("Washer is running...");
            }
        }

        public class BluRay : IDisplay
        {
            public int SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Play()
            {
                Console.WriteLine("BluRay is playing...");
            }
        }

        public interface IDisplay
        {
            void Play();
            int SerialNumber { get; set; }
        }
    }

}
