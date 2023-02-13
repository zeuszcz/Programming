namespace Programming.Model
{
    public class Flight
    {
        private string _departurepoint { get; set; }
        private string _destination { get; set; }
        private int _timeofflight { get; set; }
        public Flight()
        {
        }

        public Flight(string departurepoint, string destination, int timeofflight)
        {
            _departurepoint = departurepoint;
            _destination = destination;
            _timeofflight = timeofflight;
        }
    }
}