using System;

namespace methodology
{
    public class RandomStudentIntelligentFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            string name = RandomDataGenerator.RandomName();
            int dni = RandomDataGenerator.IntegerRandomNumber(50000000, 10000000); //random.Next(10000000, 50000000);
            int studentID = RandomDataGenerator.IntegerRandomNumber(9999, 1000); //random.Next(1000, 9999);
            double average = RandomDataGenerator.DecimalRandomNumber(10); //Math.Round(random.NextDouble() * 10, 2);
            double examScore = RandomDataGenerator.DecimalRandomNumber(10); //Math.Round(random.NextDouble() * 10, 2);

            return new StudentIntelligent(name, dni, studentID, average, examScore);
        }
    }
}