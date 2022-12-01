using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTestFinal
{
    public class ClasePrueba
    {
        PokerService pokerService;

        [Test]
        public void PruebaEscaleraColor()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "CORAZON"},
            new Carta { Numero = 7, Palo = "CORAZON"},
            new Carta { Numero = 8, Palo = "CORAZON"},
            new Carta { Numero = 9, Palo = "CORAZON"},
            new Carta { Numero = 10, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", ob);
        }
        [Test]
        public void PruebaEscaleraColor2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 3, Palo = "CORAZON"},
            new Carta { Numero = 4, Palo = "CORAZON"},
            new Carta { Numero = 5, Palo = "CORAZON"},
            new Carta { Numero = 6, Palo = "CORAZON"},
            new Carta { Numero = 7, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", ob);
        }
        [Test]
        public void PruebaEscaleraColor3()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 7, Palo = "CORAZON"},
            new Carta { Numero = 8, Palo = "CORAZON"},
            new Carta { Numero = 9, Palo = "CORAZON"},
            new Carta { Numero = 10, Palo = "CORAZON"},
            new Carta { Numero = 11, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", ob);
        }
        [Test]
        public void PruebaEscaleraColor4()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 9, Palo = "CORAZON"},
            new Carta { Numero = 10, Palo = "CORAZON"},
            new Carta { Numero = 11, Palo = "CORAZON"},
            new Carta { Numero = 12, Palo = "CORAZON"},
            new Carta { Numero = 13, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", ob);
        }
        [Test]
        public void PruebaPoker() 
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "COCO"},
            new Carta { Numero = 12, Palo = "TREBOL"},
            new Carta { Numero = 12, Palo = "COCO"},
            new Carta { Numero = 12, Palo = "ESPADA"},
            new Carta { Numero = 12, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", ob);
        }
        [Test]
        public void PruebaPoker2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 1, Palo = "COCO"},
            new Carta { Numero = 8, Palo = "TREBOL"},
            new Carta { Numero = 8, Palo = "COCO"},
            new Carta { Numero = 8, Palo = "ESPADA"},
            new Carta { Numero = 8, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", ob);
        }
        [Test]
        public void PruebaFull()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 7, Palo = "COCO"},
            new Carta { Numero = 7, Palo = "TREBOL"},
            new Carta { Numero = 1, Palo = "CORAZON"},
            new Carta { Numero = 1, Palo = "ESPADA"},
            new Carta { Numero = 1, Palo = "COCO"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", ob);
        }
        [Test]
        public void PruebaFull2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 1, Palo = "COCO"},
            new Carta { Numero = 1, Palo = "TREBOL"},
            new Carta { Numero = 7, Palo = "CORAZON"},
            new Carta { Numero = 7, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "COCO"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", ob);
        }
        [Test]
        public void PruebaEscalera()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "TREBOL"},
            new Carta { Numero = 8, Palo = "COCO"},
            new Carta { Numero = 9, Palo = "ESPADA"},
            new Carta { Numero = 10, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", ob);
        }
        [Test]
        public void PruebaEscalera2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 2, Palo = "ESPADA"},
            new Carta { Numero = 3, Palo = "TREBOL"},
            new Carta { Numero = 4, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", ob);
        }
        [Test]
        public void PruebaEscalera3()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "TREBOL"},
            new Carta { Numero = 7, Palo = "COCO"},
            new Carta { Numero = 8, Palo = "ESPADA"},
            new Carta { Numero = 9, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", ob);
        }
        [Test]
        public void PruebaEscalera4()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 9, Palo = "ESPADA"},
            new Carta { Numero = 10, Palo = "TREBOL"},
            new Carta { Numero = 11, Palo = "COCO"},
            new Carta { Numero = 12, Palo = "ESPADA"},
            new Carta { Numero = 13, Palo = "CORAZON"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", ob);
        }
        [Test]
        public void PruebaTrio()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "TREBOL"},
            new Carta { Numero = 12, Palo = "COCO"},
            new Carta { Numero = 12, Palo = "ESPADA"},
            new Carta { Numero = 12, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", ob);
        }
        [Test]
        public void PruebaTrio2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "TREBOL"},
            new Carta { Numero = 6, Palo = "COCO"},
            new Carta { Numero = 10, Palo = "ESPADA"},
            new Carta { Numero = 19, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", ob);
        }
        [Test]
        public void PruebaDoblePareja()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 2, Palo = "COCO"},
            new Carta { Numero = 9, Palo = "TREBOL"},
            new Carta { Numero = 9, Palo = "COCO"},
            new Carta { Numero = 11, Palo = "TREBOL"},
            new Carta { Numero = 11, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLEPAREJA", ob);
        }
        [Test]
        public void PruebaDoblePareja2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "TREBOL"},
            new Carta { Numero = 3, Palo = "COCO"},
            new Carta { Numero = 3, Palo = "TREBOL"},
            new Carta { Numero = 1, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLEPAREJA", ob);
        }
        [Test]
        public void PruebaPareja()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 2, Palo = "COCO"},
            new Carta { Numero = 9, Palo = "TREBOL"},
            new Carta { Numero = 6, Palo = "CORAZON"},
            new Carta { Numero = 12, Palo = "CORAZON"},
            new Carta { Numero = 12, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE", ob);
        }
        [Test]
        public void PruebaPareja2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 1, Palo = "COCO"},
            new Carta { Numero = 2, Palo = "TREBOL"},
            new Carta { Numero = 3, Palo = "CORAZON"},
            new Carta { Numero = 4, Palo = "CORAZON"},
            new Carta { Numero = 5, Palo = "ESPADA"}
            };
            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
        }
        [Test]
        public void PruebaCartaAlta()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 10, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "TREBOL"},
            new Carta { Numero = 6, Palo = "CORAZON"},
            new Carta { Numero = 12, Palo = "CORAZON"},
            new Carta { Numero = 1, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR", ob);
        }
        [Test]
        public void PruebaCartaAlta2()
        {
            List<Carta> lista = new List<Carta>()
            {
            new Carta { Numero = 13, Palo = "COCO"},
            new Carta { Numero = 9, Palo = "TREBOL"},
            new Carta { Numero = 4, Palo = "CORAZON"},
            new Carta { Numero = 7, Palo = "CORAZON"},
            new Carta { Numero = 10, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var ob = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR", ob);
        }
    }
}
