using Calidad20222.web.Models;

namespace Calidad20222.web.Services;

public class PokerService
{   
    public const String CARTA_MAYOR = "CARTA MAYOR";
    public const String DOBLE = "DOBLE";
    public const String DOBLE_PAREJA = "DOBLEPAREJA";
    public const String TRIO = "TRIO";
    public const String ESCALERA = "ESCALERA";
    public const String COLOR = "COLOR";
    public const String FULL = "FULL";
    public const String POKER = "POKER";
    public const String ESCALERA_COLOR = "ESCALERA DE COLOR";
    public const String ESCALERA_REAL = "ESCALERA REAL";

    public String GetJugada(List<Carta> cartas)
    {
        if (EsEscaleraReal(cartas))
            return ESCALERA_REAL;
        if (EsEscaleraColor(cartas))
            return ESCALERA_COLOR;
        if (EsPoker(cartas))
            return POKER;
        if (EsFull(cartas))
            return FULL;
        if (EsColor(cartas))
            return COLOR;
        if (EsEscalera(cartas))
            return ESCALERA;
        if (EsTrio(cartas))
            return TRIO;
        if (EsDoblePareja(cartas))
            return DOBLE_PAREJA;
        if (EsDoble(cartas))
            return DOBLE;

            return CARTA_MAYOR;
    }

    private bool EsColor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        return grouping.Count() == 1;
    }

    private bool EsEscaleraReal(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(i).Numero + 1 == cartas.ElementAt(i + 1).Numero)
                if (cartas.ElementAt(i).Numero + 1 == 10 && cartas.ElementAt(i).Numero + 1 == 11 && cartas.ElementAt(i).Numero + 1 == 12 && cartas.ElementAt(i).Numero + 1 == 13 && cartas.ElementAt(i).Numero + 1 == 1)
                    return true;
        }

        return false;
    }

    private bool EsEscaleraColor(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        var grouping = cartas.GroupBy(o => o.Palo);
        if (grouping.Count() == 1)
        {
            for (var i = 0; i < cartas.Count - 1; i++)
            {
                if (cartas.ElementAt(i).Numero + 1 == cartas.ElementAt(i + 1).Numero)
                    return true;
            }
        }

        return false;
    }

    private bool EsEscalera(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                return false;
        }

        return true;
    }

    private bool EsFull(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 2;
    }
    private bool EsDoblePareja(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 3;
    }

    private bool EsPoker(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 3);
    }
    
    private bool EsTrio(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 2);
    }

    private bool EsDoble(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 1);
    }

    private bool EsCartaMayor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 1);

        cartas = cartas.OrderBy(o => o.Numero).ToList();
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                if (cartas.ElementAt(i).Numero + 1 == 1)
                    return true;
        }

        return false;
    }
}