// See https://aka.ms/new-console-template for more information
//solution:
//1, set up a dictionary, key is the letter, value is the count
//2, if letter not exist, add new key; else count++
//3, print out the dictionary

Dictionary<char, int> map = new Dictionary<char, int>();

//Console.WriteLine("give me a string");
//string sample = Console.ReadLine();

string sample = File.ReadAllText("./article.txt"); //read the string from a file

for (int i = 0; i < sample.Length; i++)
{
    char c = char.ToLower(sample[i]);//lower case

    if (char.IsLetter(c))
    {
        if (map.ContainsKey(c))
        {
            map[c]++;
        }
        else
        {
            map.Add(c, 1);
        }
    }
}

foreach (KeyValuePair<char, int> kvp in map)
{
    Console.WriteLine(kvp.Key + " : " + kvp.Value);
}

