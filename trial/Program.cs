namespace trial
{
    
    internal class Program
    {
        //static void FormulaCreator(byte indexQ, in byte[,] dogsOptions, ref byte[] inputs, ref bool[] controls, byte[] findDogControlIndex)
        // ((dogsOptions[x, i] == inputs[x]) || controls[x]) && 
        /*static void Calculations(in byte[,] dogsOptions, in string[] dogBreedName, ref byte[] inputs, ref bool[] controls)//inputs has 23 elem.
        {
            byte[] findDogControlIndex = new byte[dogBreedName.Length];//індекси характеристик для порівняння
            byte[] findDogNum = new byte[dogBreedName.Length];//індекси знайжених порід
            byte j = 0; //кількість індексів характеристик
            byte k = 0;
            for (byte i = 0; i < dogBreedName.Length;i++)
            {
                if (controls[i] == false) findDogControlIndex[j++] = i;
            }
            for (byte i = 0; i < dogBreedName.Length; i++)
            {
                if (true) findDogNum[k++] = i;
            }
            if (j == 0) Console.WriteLine("Нажаль ми не можемо знайти породу собаки за вашими умовами((");
            else if (j == 1) Console.WriteLine($"Ми підібрали для вас таку породу: {dogBreedName[findDogNum[0]]}");
            else
            {
                Console.WriteLine("Пропонуємо вибрати серед таких порід: ");
                for (byte i = 0; i < j; i++)
                {
                    Console.WriteLine(dogBreedName[findDogNum[i]]);
                }
            }
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}