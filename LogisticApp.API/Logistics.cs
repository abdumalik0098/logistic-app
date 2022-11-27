namespace LogisticApp.API
{
    public class Logistics
    {
        public int Id { get; set; }
        public string? Auto { get; set; }
        public double Speed { get; set; }
        public int Distance { get; set; }
        public int RasxodTopliva { get; set; }
        public double Time { get; set; }
        public double PriceTopliva { get; set; }
        public double AllRasxod { get; set; }

        public Logistics(int id, string? auto, double speed, int distance, int rasxodTopliva, double time)
        {
            Id = id;
            Auto = auto;
            Speed = speed;
            Distance = distance;
            RasxodTopliva = rasxodTopliva;
            Time = time;
        }
    }
}
