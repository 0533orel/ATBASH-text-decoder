using System;
string AtbashDecoder(string text)
{
    string newText ="";
    Dictionary <char,char> Hatbash =new Dictionary<char, char> {{ 'a', 'z' },{ 'b','y' },
        { 'c','x'},{ 'd','w'},{ 'e','v' },{ 'f','u'},{ 'g','t'},{ 'h','s'},{ 'i','r'} ,{ 'j','q'} ,
        { 'k','p'} ,{ 'l','o'} ,{ 'm','n'},{ 'n','m'},{ 'o','l'},{ 'p','k'},{ 'q','j'},{ 'r','i'},
        { 's','h'} ,{ 't','g'},{ 'u','f' },{ 'v','e' },{ 'w','d' },{ 'x','c' },{ 'y','b' },{ 'z','a' }
}
;

    text = text.ToLower();
foreach (var c in text)
    {
        if (Hatbash.ContainsKey(c))
        {
            newText += Hatbash[c];
        }
        else
        {
            newText += c;
        }


    }
    return newText;
}
Console.WriteLine(AtbashDecoder("gabi"));
