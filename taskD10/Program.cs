namespace taskD10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PLayer p1 = new PLayer();
            Location l1 = new Location();
            Referee r1 = new Referee();
            Football football = new Football() { Id = 1, Name= "Adidas", Location= l1 };


            football.BallLocationChanged += p1.run;
            football.BallLocationChanged += r1.observe;

            football.BallLocationChanged -= p1.run;

            football.Location=new Location { X=4,Y=5 ,Z=6};

        }
    }
}
