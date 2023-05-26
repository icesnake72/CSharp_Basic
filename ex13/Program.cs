namespace ex13;


// class : 객체(Object)를 생성하기 위한(구현하는) 설계 코드...( Design Code for Creating Object )
class Student
{
    // Student Class는 학생들의 성적을 저장하고 표현하기 위한 객체를 구현한다

    public string name;     // 학생 이름
    public int kor;         // 학생의 국어 성적 
    public int math;        // 수학성적 
    public int eng;         // 영어성적 
    public int tot;         // 총점  
    public float avg;       // 평균 

    // 생성자(Constructor) : 객체를 생성할때 초기화등을 위해 무조건 호출되는 메소드, 클래스명과 이름이 같아야 한다 
    public Student()
    {
        // 학생들의 이름 및 성적 데이터들을 초기화한다 
        name = "";
        kor = math = eng = tot = 0;
        avg = 0.0F;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Student클래스로 생성된 객체들을 저장하기 위한 배열 5칸짜리 만들기 
        Student[] students = new Student[5];
        string[] names = {"KIM", "LEE", "CHOI", "PARK", "JUNG" };

        for(int i=0; i<5; i++)
        {
            students[i] = new Student();
            students[i].name = names[i];
        }


        // students 배열을 처음부터 순차적으로 모두 순회하며 점수를 입력하고 총점과 평균을 구함 
        foreach(Student student in students)
        {
            SetScore(student);
        }

        foreach(Student student in students)
        {
            ShowScoreLine(student);            
        }
    }

    static void SetScore(Student student)
    {
        Random rnd = new Random();      // 학생들의 시험 성적을 난수로 생성하기 위함

        student.kor = rnd.Next(40, 101);    // 국어 점수를 40~100점 사이로 랜덤하게 생성 
        student.math = rnd.Next(40, 101);   // 수학 점수를 40~100점 사이로 랜덤하게 생성 
        student.eng = rnd.Next(40, 101);    // 영어 점수를 40~100점 사이로 랜덤하게 생성

        student.tot = student.kor + student.math + student.eng; // 국어+영어+수학 = 총점
        student.avg = student.tot / 3.0F;   // 총점을 3으로 나누어 평균을 구함, 정수와 실수의 연산의 결과는 실수가 된다 
    }

    static void ShowScoreLine(Student student)
    {
        Console.Write($"{student.name}\t");
        Console.Write($"{student.kor}\t");
        Console.Write($"{student.math}\t");
        Console.Write($"{student.eng}\t");
        Console.Write($"{student.tot}\t");
        Console.Write($"{student.avg}");

        Console.WriteLine();    // 줄바꿈 
    }
}

