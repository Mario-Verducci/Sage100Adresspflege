namespace Sage100Adresspflege;

public class Fitler
{
    public int FilterId { get; set; }
    public string FilterName { get; set; }
    public string FilterDescription { get; set; }
    public FilterTyp FilterTyp { get; set; }
    public string Query { get; set; } // Liefert immer eine List<int> zurück
    public bool IstAktiv { get; set; }
}

public enum FilterTyp
{
    Adresse,
    Ansprechpartner
}

// Id   Name1         Name2   Straße          Plz     Ort
// ------------------------------------------------------------------
// 1    Mustermann    Max     Musterstraße 1  12345   Musterstadt
// 2    Müller        Max     Musterstraße 2  1