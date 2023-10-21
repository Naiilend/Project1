
class Program
{
    static void Main(string[] args)
    {

        int[] array = { 44, 55, 42, 55 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("1: " + array[i]);
        }


        int[,] array2 =                      //new int[,]
        {
            { 22, 3, 232, 3, 34 },     //0
            { 323, 3, 23, 23, 43 },    //1
            { 4343, 2, 34, 5, 43 }     //2  
        };
        foreach (var item in array2)
        {
            Console.Write(item + " ");
        }


        int[,] array3 =                      //new int[,]
       {
            { 22, 3, 232, 3, 34 },     //0
            { 323, 3, 23, 23, 43 },    //1
            { 4343, 2, 34, 5, 43 }     //2  
        };

        int height = array3.GetLength(0); // высота
        int width = array3.GetLength(1); // ширина

        for (int i = 0; i < width; i++) // высота
        {
            for (int j = 0; j < height; j++) // ширина
            {
                Console.Write(array3[j, i] + "\t");

            }
            Console.WriteLine();
        }



    }
}









}

    

