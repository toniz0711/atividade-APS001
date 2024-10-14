

using System.Security.Cryptography.X509Certificates;

Computador pc = new Computador();
Placa_mae mobo = new Placa_mae(12,15,"ASUS");
pc.Adicionar_Componete (mobo);
Processador i5 = new Processador (12, 15, "intel 15", 2.6 , 1 );
pc.Adicionar_Componete(i5);
Fonte nfonte650 = new Fonte (12, 15, "normal", 650);
pc.Adicionar_Componete(nfonte650);
Placa_Video RTX = new Placa_Video(12, 15, "nvidia RTX 4060", 8);
pc.Adicionar_Componete(RTX);
Ssd samdisk = new Ssd(12, 15, "SamDisk", 600);
pc.Adicionar_Componete(samdisk);
Ram PICHAU = new Ram (12, 15, "pichau", 32);
pc.Adicionar_Componete(PICHAU);


class Computador 
{

  public void Adicionar_Componete(Componente_base placa) 
    {
        Console.WriteLine("adicionando componente:  " + placa.ToString());
    }
}

class Componente_base
{
    public Componente_base(int voltagem_volts, int potencia_watts, string modelo)
    {
        Voltagem_volts = voltagem_volts;
        Potencia_watts = potencia_watts;
        Modelo = modelo;
    }
    public override string ToString()
    {
        return Modelo + " " + Voltagem_volts + "v " + Potencia_watts + "w"; 
    }
    public int Voltagem_volts { get; set; }
    public int Potencia_watts { get; set; }
    public string Modelo { get; set; }
}

class Processador : Componente_base
{
    public Processador(int voltagem_volts, int potencia_watts, string modelo, double Frequencia, int Cache) : base(voltagem_volts, potencia_watts, modelo)
    {
        this.Frequencia = Frequencia;
        this.Cache = Cache;
    }
    
    public override string ToString() 
    {
        return base.ToString()  +  " " + Frequencia + "" + "Ghz " + Cache + "MB" ; 

    }

    public double Frequencia { get; set; }
    public int Cache { get; set; }
}
class Placa_mae : Componente_base 
{
    public Placa_mae(int voltagem_volts, int potencia_watts, string modelo): base ( voltagem_volts,  potencia_watts,  modelo)
    {
        
    }
}

class Fonte  : Componente_base
{
    public Fonte(int voltagem_volts, int potencia_watts, string modelo, int Volts) : base(voltagem_volts, potencia_watts, modelo)
    {
        this.Volts = Volts;
    }
    public override string ToString()
    {
        return base.ToString() + " " + Volts + "v";

    }
    public int Volts { get; set; }
}

class Ssd : Componente_base
{
    public Ssd(int voltagem_volts, int potencia_watts, string modelo, int Gb) : base(voltagem_volts, potencia_watts, modelo)
    {
        this.Gb = Gb;
    }
    public override string ToString()
    {
        return base.ToString() + " " + Gb + " GigaBytes";

    }
    public int Gb { get; set; }
}
class Ram : Componente_base

{
    public Ram(int voltagem_volts, int potencia_watts, string modelo, int GB) : base(voltagem_volts, potencia_watts, modelo)
    {
        this.GB = GB;
    }
    public override string ToString()
    {
        return base.ToString() + " " + GB + " de Ram";
    }
    public int GB { get; set; }
}

class Placa_Video : Componente_base
{
    public Placa_Video(int voltagem_volts, int potencia_watts, string modelo, int Vram) : base(voltagem_volts, potencia_watts, modelo)
    {
        this.Vram = Vram;
    }
    public override string ToString()
    {
        return base.ToString() + " " + Vram + " Vram";
    }
    public int Vram { get; set; }
}


