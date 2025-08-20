//İndex i görüyorsan bu bir dizidir.

namespace IndexInitializer
{
    public class BaseballTeam
    {
        private string[] players = new string[9];
        private readonly List<string> positionAbbreviations = new List<string>
    {
        "p","c","1B","2B","3B","SS","LF","CF","RF"
    };

        //sayıyla indexleme
        public string this[int position]
        {
            get { return players[position - 1]; }
            set { players[position - 1] = value; }
        }

        //string ile indexleme
        public string this[string position]
        {
            get { return players[positionAbbreviations.IndexOf(position)]; }
            set { players[positionAbbreviations.IndexOf(position)] = value; }
        }
    }
}