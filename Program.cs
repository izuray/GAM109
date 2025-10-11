using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using GAM109;

public class Student
{
    public string Name {get; set; }
    public int Id {get; set; }
    public int Score {get; set; }
    public string MSSV { get; set; }
    
    public int classId { get; set; }

    public Student(int id, string name,  int score, string mssv, int ClassId)
    {
        Id = id;
        this.Name = name;
        Score = score;
        MSSV = mssv;
        classId = ClassId;
    }

    
}

public class Class
{
    
    public int Id {get; set; }
    public string Name {get; set; }

    public Class(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
}

class Program
{
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>()
        {
            new Student(1,"dinhbv", 9, "PH21321",302),
            new Student(2,"anhnh136", 8, "PH21321",301),
            new Student(3,"trungd24", 6, "PH21321",305),
            new Student(4,"chinhdp5", 5, "PH21321",302),
            new Student(5,"longhh7", 7, "PH21321",301),
            new Student(6,"linhtd73", 10, "PH21321",302),

        };   
        var result = students.OrderByDescending(temp => temp.Score);
        Console.WriteLine("Danh sach sinh vien: ");
        foreach( var i in result)
        {
            Console.WriteLine($" Name: {i.Name} \n Score: {i.Score} \n MSSV: {i.MSSV} \n Class: {i.classId}");
            Console.WriteLine("================");
        }
        

    }

























   /* public static int demo(int x, int y)
    {
        //Console.WriteLine($"Tutor C# 2");
        var sum = x + y;
        return sum;
        
    }

    public static int test(int x, string y)
    {
        Console.WriteLine($"Gia tri in ra tham so string la {y} va ");
        //Console.WriteLine(" Tutor C# 2 Block 1 Ky Su2025");
        return x;
    }
    //Action va Func
    static void DoSomething()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
    static void DoSomething2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine( "Dosomething2 "+i);
           // Thread.Sleep(1000);
        }
    }*/
    /* static  readonly object lockObject = new object();

     public static List<Student> stdList;

     static void FindStudent(int skill_id)
     {
         lock (lockObject)
         {

             foreach (var s in stdList)
             {
                 if (s.Id == skill_id)
                 {
                     Console.WriteLine($"Player ID: {s.Id}, Name: {s.Name}, Weapon ID: {s.Score}");
                     //Thread.Sleep(1000);
                 }

             }
         }


     }*/


    /*static void Main(string[] args)
    {*/
    /*stdList = new List<Student>()
    {
        new Student("dinhbv", 1, 90, 1),
        new Student("anhnh136", 2, 80, 1),
        new Student("longhh7", 3, 95, 2),
        new Student("linhdt73", 4, 85, 1),
        new Student("loantt", 5, 100, 2),
    };*/

    /*Thread th1 = new Thread(DoSomething);
    Thread th2 = new Thread(DoSomething);
    Thread th3 = new Thread(DoSomething);
    th1.Start();
    th2.Start();
    th3.Start();*/

    /*Thread td1 = new Thread(() =>FindStudent(1));

    Thread td2 = new Thread(() => FindStudent(2));

    td1.Start();
    td2.Start();

    td1.Join();

    td2.Join();*/


    /*for (int i = 0; i < 50; i++)
    {
        Console.WriteLine("In gia tri lan thu nhat: " + i);
        Thread.Sleep(1000); // 1s
    }*/



    //Dùng Join để đảm bảo luồng thread thứ nhất hoạt động xong, mới chuyển sang thread thu 2. th.Join()
    //Dung lock de dam bao an toan du lieu khi nhieu doi tuong cung truy xuat vao 1 thuoc tinh hay gia tri cua doi tuong khac
    // static object lockObject = new object();
    /*
        lock(lockObject){
            //Khoi lenh trong lock chay het thi bien lockObject moi duoc mo khoa de chay luong tiep theo

        }


    */

    /*Thread thread1 = new Thread(() => FindStudent(1));
    Thread thread2 = new Thread(() => FindStudent(2));

    thread1.Start();
    thread2.Start();

    thread1.Join();
    thread2.Join();

    Console.WriteLine("All threads completed.");*/

    /*List<Student> stdList = new List<Student>()
    {
        new Student("dinhbv", 1, 90, 1),
        new Student("anhnh136", 2, 80, 1),
        new Student("longhh7", 3, 95, 2),
        new Student("linhdt73", 4, 85, 1),
        new Student("loantt", 5, 100, 2),


    };
    List<Class> clsList = new List<Class>();
    clsList.Add(new Class(1, "GA20301"));
    clsList.Add(new Class(2, "GA20302"));

    var result = clsList.GroupJoin(stdList, c => c.Id, s => s.classId, (c, s) =>
    {
        return new
        {
            ClassName = c,
            Student = s
        };
    });
    foreach (var r in result)
    {
        Console.WriteLine($"* Lop: {r.ClassName}");
        foreach (var s in r.Student)
        {
            Console.WriteLine("     - "+s.Name + "      " + s.Score);
        }
    }*/

    /*List<Account> listAct = new List<Account>();

    string path = "Account.txt";

    // Kiểm tra trùng lặp

    try
    {
        if (File.Exists(path))
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8)) //StreamWriter
                {
                    reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        //string line chứa một chuỗi: ACC001    UserOne    user1@example.com    hash1_abc	2023-01-15	2025-05-20
                        // arr[] = {ACC001,UserOne,user1@example.com,hash1_abc,2023-01-15,2025-05-20}
                        // 0, 1,2,3,4,5
                        var arr = line.Split('\t' );

                        Account account = new Account
                        {
                            AccountID = arr[0],
                            Username = arr[1],
                            Email = arr[2],
                            PasswordHash = arr[3],
                            RegistrationDate = arr[4],
                            LastLogin = arr[5]
                        };

                        listAct.Add(account); // {ac1, act2,... act_n}
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Lỗi khi kiểm tra file: {ex.Message}");
        return;
    }

    foreach (var acc in listAct)
    {
        Console.WriteLine($"ID: {acc.AccountID}, Name: {acc.Username}, Email: {acc.Email}, PasswordHash: {acc.PasswordHash}");
    }
*/

    //}
}