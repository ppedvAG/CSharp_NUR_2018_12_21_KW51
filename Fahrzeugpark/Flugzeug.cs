﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl. auch PKW
    public class Flugzeug : Fahrzeug
    {
        public int MaxFlughöhe { get; set; }

        public Flugzeug(string name, int maxG, double preis, int höhe) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = höhe;
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $" Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void BaueUnfall()
        {
            Console.WriteLine("Mayday");
        }
    }
}
