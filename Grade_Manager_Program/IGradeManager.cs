namespace RefactoringHomework
{
    public interface IGradeManager
    {
        double calculateFinalGrade(double average, double bonus);
        void processGrades(string studentName, double[] grades);
    }
}