using System;
using mp = MetodologíasDeProgramaciónI;

namespace methodology
{
    class Program
    {
        //constantes para el StudentDecorator
        private const int decoratorBox = 1;
        private const int decoratorStatusNote = 2;
        private const int decoratorId = 4;
        private const int decoratorWrittenNote = 8;

        //constantes para el fabricator
        const int numberType = 1;
        const int studentType = 2;
        private const int nameType = 3;
        private const int teacherType = 4;

        private const int StudentIntelligentType = 5;
        static void Main(string[] args)
        {
            // Collectable stack = new Stack();
            // Collectable queue = new Queue();
            // Collectable unique = new UniqueCollection();

            // MultipleCollection multiple = new MultipleCollection(stack, queue);

            // Funcions.RandomLoadComparable(stack, numberType);
            // Funcions.RandomLoadComparable(queue, numberType);


            // Funcions.inform(stack);
            // Funcions.inform(queue);
            // Funcions.inform(multiple);

            // Funcions.RandomLoadComparable(stack, studentType);
            // Funcions.RandomLoadComparable(queue, studentType);
            // Funcions.RandomLoadComparable(unique, studentType);


            // Funcions.printCollectable(stack);
            // Funcions.printCollectable(queue);
            // Funcions.printCollectable(unique);

            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByAverage());
            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByDni());
            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByName());
            // Funcions.inform(stack);


            // observer
            // // creamos al profesor
            // IComparable teacher1 = ComparableFactory.createRandom(teacherType);
            // Console.WriteLine(teacher1.ToString());

            // // creo colas para los alumnos
            // Collectable studentStack = new Stack();

            // Funcions.RandomLoadComparable(studentStack, studentType, 3);

            // Funcions.AttachObservers((IObserved)teacher1, studentStack);
            // Funcions.dictationClasses((Teacher)teacher1);

            // como funciono la actividad, voy a experimentar con takeList

            // // creamos al profesor
            // IComparable teacher1 = ComparableFactory.createRandom(teacherType);
            // Console.WriteLine($"profesor: {teacher1.ToString()}");

            // // creo una collecion de eliminacion random para los alumnos
            // RandomElimination student = new RandomElimination();

            // // creamos la lista de estudiantes
            // Funcions.RandomLoadComparable(student, studentType, 30);
            // Queue studentList_1 = Funcions.studentList(student);


            // // quitamos estudiantes para que algunos esten ausentes
            // // pensaba hacer una funcion pero creo que no es necesario
            // for (int i = 0; i < 10; i++)
            // {
            //     student.randomRemove();
            // }

            // // conectamos a los estudiantes para que oberven al profesor
            // Funcions.AttachObservers((IObserved)teacher1, student);

            // // conectamos al profesor para que oberve a los estudiantes
            // Funcions.SubscribeToSubjects((IObserver)teacher1, student);


            // // el profesor pasa lista:
            // Iiterator studentListIterator = studentList_1.createIterator();
            // ((Teacher)teacher1).takeList(studentListIterator);

            // pracitca 4:


            // creo 10 estudiantes y 10 estudiantes inteligentes
            Collectable queue = new Queue();
            Funcions.RandomLoadComparable(queue, studentType, 10);
            Funcions.RandomLoadComparable(queue, StudentIntelligentType, 10);

            // cambiamos el metodo de comparacion, para que compre por ultima nota
            Funcions.changeStrategy(queue, new CompareByExamScore());

            // le agregamos los decoradores a los estudiantes
            Funcions.setStudentDecorator(queue, decoratorBox + decoratorId + decoratorStatusNote + decoratorWrittenNote);

            // los transformo a studientAdapter
            mp.Collection students = Funcions.combertToStudentAdapter(queue);
            // creo al profesor
            mp.Teacher teacher = new mp.Teacher();

            // queria ver que este bien la coleccion 
            // mp.IteratorOfStudent it = students.getIterator();
            // it.beginning();
            // while (!it.end())
            // {
            //     mp.Student s = it.current();
            //     Console.WriteLine($"{s.getName()}  ->  {s.showResult()}");
            //     it.next();
            // }

            teacher.setStudents(students);
            teacher.teachingAClass();



        }
    }
}
