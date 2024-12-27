namespace AlphabetWords
{
    public class Alphabets
    {
       public static void PrintAlphabetWords()
        {
            Dictionary<char,string> alphabets =[];
            alphabets.Add('A', "Apple");
            alphabets.Add('B',"Ball");
            alphabets.Add('C',"Cat");
            alphabets.Add('D',"Deer");
            alphabets.Add('E',"Elephant");
            alphabets.Add('F',"Frog");
            alphabets.Add('G',"Guitar");
            alphabets.Add('H',"Horse");
            alphabets.Add('I',"Ink");
            alphabets.Add('J',"Juggle");
            alphabets.Add('K',"Kettle");
            alphabets.Add('L',"Lion");
            alphabets.Add('M',"Mouse");
            alphabets.Add('N',"Nose");
            alphabets.Add('O',"Orange");
            alphabets.Add('P',"Panda");
            alphabets.Add('Q',"Queen");
            alphabets.Add('R',"Razor");
            alphabets.Add('S',"Silicon");
            alphabets.Add('T',"Truck");
            alphabets.Add('U',"Umbrella");
            alphabets.Add('V',"Valley");
            alphabets.Add('W',"Window");
            alphabets.Add('X',"Xylophone");
            alphabets.Add('Y',"Yam");
            alphabets.Add('Z',"Zebra");

            var key = alphabets.Keys.ToList();
            var value = alphabets.Values.ToList();
            
            for(int i = 0;i<26;)
            {
                Console.WriteLine($"{i+1}. {key[i]} for {value[i]}");
                i++;
            }
        } 
    }
}