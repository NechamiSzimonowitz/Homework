namespace ShirtStyle {
    internal class ShirtStyle {
        public ShirtStyle(string Color, string Design)
        {
            Color = color;
            Design = design;
        }
        string color;
        string design;
         
        static void Main(string[] args)
        {
            string[] color = new string[3] { "Red", "Blue", "Green" };
            string[] design = new string[3] { "spotted", "Polka dotted", "striped" };

            for (int i=0; i<3; i++)
                for (int j = 0; j <3; j++)
                {
                    new ShirtStyle(color[i], design[j]);
                    Console.WriteLine($"Color:{ color[i]}; Design:{design[j]}");
                }
            
        }
    }
}
