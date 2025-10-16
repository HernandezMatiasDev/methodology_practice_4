namespace methodology
{
    public class CompareByExamScore: IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Student)a).getExamScore() == ((Student)b).getExamScore();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Student)a).getExamScore() < ((Student)b).getExamScore();

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Student)a).getExamScore() > ((Student)b).getExamScore();

        public string getValue(IComparable a) => ((Student)a).getExamScore().ToString();
    }
}