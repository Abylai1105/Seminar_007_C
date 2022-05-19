string output = "3, 56, 78, 4, 5";

int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
    countNumbers++;
}

int[] numbers = new int[countNumbers];

int numbersIndex = 0;
for (int i = 0; i < output.Length; i++)
{
    string subString = String.Empty;

    while (output[i] != ',')
    {
        if (i >= output.Length - 1)
        break;
        subString += output[i].ToString();
        i++;
    }

    if (subString == "" ||subString == " ")
        continue;

    numbers[numbersIndex] = Convert.ToInt32(subString);
    numbersIndex++;

}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}


