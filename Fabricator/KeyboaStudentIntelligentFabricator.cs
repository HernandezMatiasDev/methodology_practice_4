using System;

namespace methodology
{
    public class KeyboaStudentIntelligentFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            Console.WriteLine("    Creacion de Estudiante");

            Console.WriteLine("Ingrese el nombre completo del estudiante");
            string name = DataReader.stringByKeyboard();

            Console.WriteLine("Ingrese el DNI");
            int dni = DataReader.numberByKeyboard();

            Console.WriteLine("Ingrese el legajo");
            int id = DataReader.numberByKeyboard();

            Console.WriteLine("Ingrese el promedio");
            double average = DataReader.doubleByKeyboard();

            Console.WriteLine("Ingrese la ultima nota");
            double examScore = DataReader.doubleByKeyboard();

            return new StudentIntelligent(name, dni, id, average, examScore);
        }
    }
}