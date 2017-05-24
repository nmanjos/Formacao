using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5118
{
   public abstract class Computador
    { 
	
	private string serial;
    private string marca;
    private string modelo;
    private string motherboard;
    private string processador;

    public Computador(string Serial, string Marca, string Modelo, string Motherboard, string Processador)
    {
        serial = Serial;
        marca = Marca;
        modelo = Modelo;
        motherboard = Motherboard;
        processador = Processador;
    }
    public Computador(string Serial, string Marca, string Modelo, string Motherboard)
    {
        serial = Serial;
        marca = Marca;
        modelo = Modelo;
        motherboard = Motherboard;
        processador = "ONBOARD";
    }
    public string Serial
    {
        get
        {
            return serial;
        }
        set
        {
            serial = value;
        }
    }
    public string Marca
    {
        get
        {
            return marca;
        }
        set
        {
            marca = value;
        }
    }
    public string Modelo
    {
        get
        {
            return modelo;
        }
        set
        {
            modelo = value;
        }
    }
    public string Motherboard
    {
        get
        {
            return motherboard;
        }
        set
        {
            motherboard = value;
        }
    }
    public string Processador
    {
        get
        {
            return processador;
        }
        set
        {
            processador = value;
        }
    }

    public abstract double CustoReparacao(double horas, double valorPecas);

}
}
