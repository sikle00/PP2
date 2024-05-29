


    
var example = "";
int klærindex = 0;
int vær = 0;

Main();
void Main()
        {
            Console.WriteLine($"været i dag: {MittVær()}" + vær);
    Console.WriteLine("hva ønsker du å ha på deg? ");
    Console.WriteLine("1. Anorak");
    Console.WriteLine("2. Shorts og vann");
    Console.WriteLine("3. Oljehyr");
    klærindex = int.Parse(Console.ReadLine());

    Console.WriteLine($"{Klær()}");

   
}
       string MittVær()
        {

           
                
        Random rand = new Random();
            var rnd = rand.Next(1, 4);
            if (rnd == 1)
            {
                example = "Snøstorm";
                vær = rnd;
            }

            else if (rnd == 2)
            {
                example = "Hetebølge";
                vær = rnd;
            }

            else 
            {
                example = "Regnstorm";
                vær = rnd;
             }
         return example;
           
        }




    string Klær()
    {
        string[] klær = {"anorak", "shorts og vann", "oljehyr", "error" };


        var input = "";
        if (klærindex == 1 && vær == 1)
        {
        Console.WriteLine("Du setter på deg en anorak og holder deg god og varm, til tross de kalde vindene og snøen");
        return klær[0];

    }
        else if (klærindex == 2 && vær == 2)
    {
        Console.WriteLine("Får håpe du takler varmen!");
        return klær[1];
    }
        else if (klærindex == 3 && vær == 3)
    {
        Console.WriteLine("Smekker på deg oljehyr og står imot stormen!");
        return klær[2];
    }

        else {
        return klær[3];
    }
    

}


