namespace Entertainment_Tracker
{
    public class Entry
    {
        public int id { get; set; }
        public string name { get; set; }
        public ETypes type { get; set; }
        public int rating { get; set; }
        public string genre { get; set; }
        public string shelf { get; set; }
        public DateOnly dateStarted { get; set; }
        public DateOnly dateFinished { get; set; }
        public string thoughts { get; set; }
        public int episodesFinished { get; set; }
        public List<string> episodeThoughts { get; set; }

        public Entry() { }
        public Entry(int _id, string _name, ETypes _type) 
        { 
            id = _id;
            name = _name;
            type = _type;
        }
    }
}
