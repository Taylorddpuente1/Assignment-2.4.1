

int i, numLength, sum = 0;

Console.Write("Input the number of elements to be stored in the array: ");
    numLength= Convert.ToInt32(Console.ReadLine());

// make array to store the numbers
int[] arr = new int[numLength];

// Ask user to enter numbers one by one 
Console.WriteLine($"Input {numLength} in the array:");
for ( i = 0; i < numLength; i++);

{
    Console.Write($"element - {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
}

// Add all the numbers
for ( i = 0; i < numLength; i++)
{
    sum += arr[i];
}

//Show results
Console.WriteLine("sum of all the elements stored in the array is : " + sum);