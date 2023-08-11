using System;

class Program
{
static string Encrypt(string text, int shift)
{
string encryptedText = "";
foreach (char c in text)
{
if (char.IsLetter(c))
{
char shiftedChar = (char)(c + shift);
if ((char.IsLower(c) && shiftedChar > 'z') || (char.IsUpper(c) && shiftedChar > 'Z'))
{
shiftedChar = (char)(c - (26 - shift));
}
encryptedText += shiftedChar;
}
else
{
encryptedText += c;
}
}
return encryptedText;
}

static void Main(string[] args)
{
Console.Write("Digite a palavra a ser criptografada: ");
string palavra = Console.ReadLine();

Console.Write("Digite o valor de deslocamento (chave): ");
int deslocamento = int.Parse(Console.ReadLine());

string palavraCriptografada = Encrypt(palavra, deslocamento);
Console.WriteLine("Palavra criptografada: " + palavraCriptografada);
}
}
