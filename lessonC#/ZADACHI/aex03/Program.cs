// Посчитать количество гласных букв во фразе исползуя рекурсию
// без труда не выловишь и рыбку из пруда

string phrase = "без труда не выловишь и рыбку из пруда";
char[] alphabet = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', };

// int count = 0;
// foreach (char letter in phrase)
// {
//     bool contain = alphabet.Contains(letter);
//     if (contain) count++;
//     Console.WriteLine($"буква {letter} гласная: {contain}");
// }
// Console.WriteLine($"В поговорке {count} гласных");

int CountOfVoweLetters(string phrase, char[] alphabet,
                        int count = 0, int index = 0)
{
    if (index == phrase.Length) return count;
    bool contain = alphabet.Contains(phrase[index]);
    if (contain) count++;
    index++;
    return CountOfVoweLetters(phrase, alphabet, count, index);

}
Console.WriteLine($"В поговорке {CountOfVoweLetters(phrase, alphabet)} гласных");