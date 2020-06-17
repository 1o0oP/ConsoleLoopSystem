namespace ConsoleLoopSystem.Model
{
  class Place : Thing
  {
    public string Temperature { get; set; } // Freezing, Cold, Normal, Warm, Burning
    public string Luminosity { get; set; } // Darkness, Dim Light, Normal, Strong Light, Sparkling
    public string Tactility { get; set; } // Smooth, Diverse, Rough, Irregular, Spinous
    public string Environment { get; set; } // Urban, Wilderness, Cloudly, Desert, Montainous, Underground, Polar
    public string Aspect { get; set; } // Roomy, Trapped, Open, Mazed, High, Submerged, etc ...
    public string Population { get; set; } // Empty, Sparse, Dense, Crowded
    public string History { get; set; } // Todo lugar tem uma história ... (Contar)

    public Place(string name, string definition, string temperature, string luminosity,
      string tactility, string environment, string aspect, string population, string history) :
      base(name, definition)
    {
      Type = "Place";
      Temperature = temperature;
      Luminosity = luminosity;
      Tactility = tactility;
      Environment = environment;
      Aspect = aspect;
      Population = population;
      History = history;
    }
  }
}
