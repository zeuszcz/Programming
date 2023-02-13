namespace Programming.Model
{
    public class Discipline
    {
        private string _name { get; set; }
        private string _dayofweek { get; set; }
        private bool _automat { get; set; }

        private Discipline()
        {
            
        }

        private Discipline(string name,string dayofweek, bool automat)
        {
            _name = name;
            _dayofweek = dayofweek;
            _automat = automat;
        }
    }
} 