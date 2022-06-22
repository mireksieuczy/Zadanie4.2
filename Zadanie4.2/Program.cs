int[] tab1 = new int[10]  { 19, 34, 23, 54, 31, -1, 2, 76, -54, 10 };
int[] tab2 = new int[tab1.Length];


for (int i = tab1.Length - 1; i >= 0; i--)
    if (tab1[i] > 0)
        tab2[tab1.Length - i - 1] = tab1[i];

for (int i = 0; i < tab2.Length; i++)
    Console.WriteLine(tab2[i]);



Console.ReadKey();
