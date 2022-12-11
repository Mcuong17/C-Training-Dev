using System;

namespace QLSV1
{
    class StudentMark
    {
        private string rollno { get; set; }
        private string fullName { get; set; }
        private string className { get; set; }
        private string subject { get; set; }
        private float mark { get; set; }

        public StudentMark()
        {

        }
        public StudentMark(string rollno, string fullName, string classname, string subject, float mark)
        {
            this.rollno = rollno;
            this.fullName = fullName;
            this.className = className;
            this.subject = subject;
            this.mark = mark;
        }
        public void Input()
        {
            Console.WriteLine("Nhập mã sinh viên ");
            rollno = Console.ReadLine();

            Console.WriteLine("Nhập tên sinh viên ");
            fullName = Console.ReadLine();

            Console.WriteLine("Nhập lớp sinh viên ");
            className = Console.ReadLine();

            Console.WriteLine("Nhập môn học ");
            subject = Console.ReadLine();

            Console.WriteLine("Nhập điểm sinh viên ");
            mark = float.Parse(Console.ReadLine()); 
        }
        public void Show()
        {
            Console.WriteLine("Mã sinh viên: {0}, họ và tên: {1}. lớp: {2}, môn học: {3}, điểm {4}", rollno, fullName, className, subject, mark);
        }
        static void Main(string[] args)
        {
            StudentMark sinhvien1 = new StudentMark();
            StudentMark sinhvien2 = new StudentMark();

            sinhvien1.Input();
            sinhvien2.Input();

            sinhvien1.Show();
            sinhvien2.Show();

            if(sinhvien1.mark > sinhvien2.mark)
            {
                sinhvien1.Show();
            }
            else if(sinhvien1.mark.Equals(sinhvien2.mark))
            {
                Console.WriteLine("Sinh viên có điểm bằng nhau");
            }
            else
            {
                sinhvien2.Show();
            }
        }
    }
}
