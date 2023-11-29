namespace conditions_task_no_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C. Task no 8");
            //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. kryteriow:
            //wynik z matury z matematyki powyżej: 70
            //wynik z fizyki powyżej: 55
            //wynik z chemii: powyżej 45
            //łączny wynik z 3 przedmiotów powyżej 180 albo wynik z matematyki i jednego przedmiotu powyżej: 150
            //Dane testowe: matma: 80, fizyka: 71, chemia 0
            //Rezultat: kandydat dopuszczony do rekrutacji

            //poprawny kod:

            int resultMath = 80;
            int resultPhysics = 71;
            int resultChemistry = 0;

            if (((resultMath > 70) && (resultPhysics > 55) && (resultChemistry > 45)) & (resultMath + resultPhysics + resultChemistry > 180) || (resultMath + resultPhysics > 150) || (resultMath + resultChemistry > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }


            // &wszystkie  warunki do sprawdzenia

            int resultNewMath = 80;
            int resultNewPhysics = 71;
            int resultNewChemistry = 0;
            if (((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewPhysics + resultNewChemistry > 180)) || ((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewPhysics > 150)) || ((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewChemistry > 150)))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");

            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

        }
    }
}
