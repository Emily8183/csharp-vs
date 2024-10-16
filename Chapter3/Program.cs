// See https://aka.ms/new-console-template for more information
//solution:
//1, set up a dictionary, key is the letter, value is the count
//2, if letter not exist, add new key; else count++
//3, print out the dictionary

Dictionary<char, int> map = new Dictionary<char, int>();
int value = 0;

string sample = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

for (int i = 0; i < sample.Length; i++)
{
    char c = sample[i];

    if (map.ContainsKey(c))
    {
        map[c]++;
    } else
    {
        map.Add(c, 1);
    }
}

foreach(KeyValuePair<char,int> kvp in map)
{
    Console.WriteLine(kvp.Key + " : " +  kvp.Value);
}