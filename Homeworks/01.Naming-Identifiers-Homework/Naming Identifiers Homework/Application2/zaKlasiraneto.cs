namespace Application2
{
    public class zaKlasiraneto
    {
        private string name;

        private int points;

        public string igra4
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int kolko
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public zaKlasiraneto()
        {
        }

        public zaKlasiraneto(string име, int то4ки)
        {
            this.name = име;
            this.points = то4ки;
        }
    }
}