using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_ch7
{
    internal class Program
    {
        static void Main(string[] args)
        {   //7-1寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)
            //string output = @"C:\Users\acer\Desktop\C#\txt\中文歌詞.txt";//檔案路徑
            //string music = @"
            //夜空中最亮的星  
            //你是否知道  
            //那顆星正照耀在我心頭  
            //那些年輕的夢想  
            //和淚水的味道  
            //依然是我心中最深的記號

            //那些年 我們一起追的女孩  
            //在時間的河流裡飄蕩  
            //你是否還記得 那一年的夏天  
            //是我們最美的時光
            //    ";
            //    //寫入
            //    File.WriteAllText(output, music,Encoding.UTF8);
            //    Console.WriteLine(output);
            //    Console.ReadKey();


            //7-2讀取1.txt 顯示在畫面上
            //string input = @"C:\Users\acer\Desktop\C#\txt\1.txt";
            //string content =File.ReadAllText(input, Encoding.UTF8);
            //    //File.ReadAllText讀取檔案內容
            //Console.WriteLine("檔案內容");
            //Console.WriteLine(content); 
            //Console.ReadKey();

            //寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
            //    Console.WriteLine("輸入e-mail");
            //    string email = Console.ReadLine();
            //    bool a = isemail(email);
            //    if (a)
            //    {
            //        Console.WriteLine("有效");
            //    }
            //    else
            //    {
            //        Console.WriteLine("無效");
            //    }
            //    Console.ReadKey();
            //}

            //static bool isemail(string email)
            //{
            //    if (string.IsNullOrEmpty(email))//string.IsNullOrEmpty(input)：檢查字串是否為空或為 null
            //    {
            //        return false;//表示不是有效的 Email
            //    }
            //    int at = email.IndexOf("@");//IndexOf位置
            //    int dot = email.LastIndexOf(".");
            //    //不在開頭   //@ 之後不在最後   //.不是最後一個字
            //    if (at > 0 && dot > at + 1 && dot < email.Length - 1)
            //    { return true; }
            //    return false;



            //7-3寫入九九乘法表資料到一個文字檔到自己指定的文字檔
            //string input = @"C:\Users\acer\Desktop\C#\txt\99乘法表.txt";
            //string output = @"C:\Users\acer\Desktop\C#\txt\把99乘法放進來.txt";
            //string content = File.ReadAllText(input);// 讀取
            //File.WriteAllText(output, content);//寫入新檔
            //Console.WriteLine(content);
            //Console.ReadKey();

            //7-4讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
            //string input = @"C:\Users\acer\Desktop\C#\txt\1.txt";
            //                                               //換後儲存檔案的路徑
            //string output = @"C:\Users\acer\Desktop\C#\txt\1_cover.txt";
            //string content = File.ReadAllText(input);
            //Dictionary<char, string> number = new Dictionary<char, string>
            //{
            //    { '0', "零" },
            //    { '1', "壹" },
            //    { '2', "貳" },
            //    { '3', "叁" },
            //    { '4', "肆" },
            //    { '5', "伍" },
            //    { '6', "陸" },
            //    { '7', "柒" },
            //    { '8', "捌" },
            //    { '9', "玖" }
            //};
            //string contentchange = ""; //阿拉伯數字換成中文數字
            //foreach (char c in content)
            //{
            //    if (number.ContainsKey(c))//若是數字，則換為中文數字
            //    {
            //        contentchange += number[c];
            //    }
            //    else
            //    {
            //        contentchange += c;// 不是數字則保留原字元
            //    }
            //}
            //File.WriteAllText(output, contentchange);//寫入
            //Console.WriteLine(output);
            //Console.ReadKey();

            //7-5讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            //string input = @"C:\Users\acer\Desktop\C#\txt\fc4bb.csv";
            //string output = @"C:\Users\acer\Desktop\C#\txt\fc4bb.html";
            //string[] a = File.ReadAllLines(input);
            //StringBuilder html = new StringBuilder();
            //html.AppendLine("<html>");
            //html.AppendLine("<body>");
            //html.AppendLine("<table border='1'>");
            //foreach (string line in a)
            //{
            //    html.AppendLine("<tr>");
            //    string[] cells = line.Split(',');
            //    foreach (string cell in cells)
            //    {
            //        html.AppendLine($"<td>{cell}</td>");
            //    }
            //    html.AppendLine("</tr>");
            //}
            //html.AppendLine("</table>");
            //html.AppendLine("</body>");
            //html.AppendLine("</html>");
            //File.WriteAllText(output, html.ToString());
            //Console.ReadKey();

            //7-6請隨機由0~99產生一個數字輸出。
            //Random rom = new Random();//亂數種子
            //int I = rom.Next(0, 100);//回傳0-99的亂數
            //Random A = new Random();
            //int number = A.Next(0, 100);
            //Console.WriteLine($"隨機生成數字:{number}");
            //Console.ReadKey();

            //7-7請隨機由0~99產生10個數字輸出。
            //Random row = new Random();
            //int[] a = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    a[i] = row.Next(0, 100);
            //}
            //Console.WriteLine("隨機產生數字:");
            //foreach (int number in a)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadKey();

            //7-8隨機幫每位學員產生成績，並寫入文字檔
            //(欄位之間用，分開，換行寫入下一筆)。
            //string[] students = { "小明", "小華", "小李", "小張", "小王" };
            //string b = @"C:\Users\acer\Desktop\C#\txt\學生成績.txt";
            ////StreamWriter寫入檔案物件
            //StreamWriter a= new StreamWriter(b);
            //Random ages = new Random();//隨機
            //foreach (string student in students)
            //{// 為每位學生產生隨機成績，並寫入檔案
            //    int score = ages.Next(0, 101);
            //    a.WriteLine(student + ",成績" + score+"分");// 將學生名稱和分數寫入檔案
            //}
            //    a.Close();
            //Console.WriteLine("學生成績已寫入文字檔！");
            //Console.ReadKey();


            //7-9請設計樂透開獎程式。
            //Random row = new Random();
            //int[] numbers = new int[6];
            //int ages = 0;
            //while (ages < numbers.Length)
            //{
            //    int newnumber = row.Next(1, 50);
            //    bool repeat = false;
            //    for (int i = 0; i < ages; i++)
            //    {
            //        if (numbers[i] == newnumber)
            //        {
            //            repeat = true;
            //            break;
            //        }
            //    }
            //    if (!repeat)
            //    {
            //        numbers[ages] = newnumber;
            //        ages++;
            //    }
            //}
            //Console.WriteLine("本期中獎號碼:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + ",");
            //}Console.ReadKey();

            //7-10請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            //string shop = @"C:\Users\acer\Desktop\C#\txt\午餐選擇.txt";
            //string[]lunch =File.ReadAllLines(shop);
            //Random row = new Random();  
            //int a =row.Next(lunch.Length);
            //Console.WriteLine(lunch[a]); //lunch陣列取出a位置
            //Console.ReadKey();

            //7-11請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，
            //抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            //string school = @"C:\Users\acer\Desktop\C#\txt\學生名單.txt";
            //string[]student=File.ReadAllLines(school);
            //Random row = new Random();
            //List<string> studentList = new List<string>(student);

            //while (true)// 不斷進行抽籤
            //{
            //    if (studentList.Count == 0) // 如果所有學生都被抽過，重置列表
            //    {
            //        Console.WriteLine("全抽過,重新開始");
            //        studentList = new List<string>(student);// 重置學生名單
            //    }
            //    int a = row.Next(studentList.Count);// 隨機抽取一個學生
            //    Console.WriteLine("值日生:" + studentList[a]);
            //    studentList.RemoveAt(a);
            //    Console.WriteLine("下一位值日生");
            //    Console.ReadKey();
            //}

            //8-1顯示現在日期與時間
            //DateTime now = DateTime.Now;
            //Console.WriteLine("現在的日期和時間" + now.ToString());
            //Console.ReadKey();

            //8-2顯示再過30天為哪一天
            //DateTime today = DateTime.Now;
            //DateTime futureDate =today.AddDays(30);
            //Console.WriteLine("今天的日期" + today.ToString("yyyy/MM/dd"));
            //Console.WriteLine("30天過後"+futureDate.ToString("yyyy/MM/dd"));
            //Console.ReadKey();

            //8-3顯示24小時前的年月日時分秒
            //DateTime now = DateTime.Now;
            //DateTime past = now.AddHours(-24);
            //Console.WriteLine("現在的日期時間"+now.ToString());
            //Console.WriteLine("24小時前"+past.ToString());
            //Console.ReadKey();

            //8-4取得目前是幾月
            //DateTime now = DateTime.Now;
            //int currentmonth = now.Month;
            //Console.WriteLine("現在是" + currentmonth + "月");
            //Console.ReadKey();

            //8-5取得明年是否為閏年。(可以試試民國)
            //--->年份能被 4 整除且不能被 100 整除，或者能被 400 整除。
            //a || b;是 或 否
            //int nextyear = DateTime.Now.Year + 1;
            //bool isleapyear = (nextyear % 4 == 0 && nextyear % 100 != 0) || (nextyear % 400 == 0);
            //int taiwanyear = nextyear - 1911;
            //Console.WriteLine($"明年是西元{nextyear}年,民國{taiwanyear}年");
            //Console.WriteLine("明年是否是閏年?" + (isleapyear?"是":"否"));
            //Console.ReadKey();

            //8-6取得離2025年1月1日還有幾天
            //DateTime nextyear= new DateTime(2025,1,1);
            //DateTime today = DateTime.Now.Date;
            //int a = (nextyear - today).Days;
            //Console.WriteLine($"距離2025/1/1還有{a}天");
            //Console.ReadKey();

            //8-7星期一，猴子穿新衣，星期二，猴子肚子餓，星期三，猴子去爬山，
            //星期四，猴子看電視，呈期五，猴子去跳舞，星期六，猴子去斗六，星期日，猴子過生日。
            //請顯示今天猴子做甚麼事。--->DateTime.Now.DayOfWeek取得今天是星期幾
            //switch 判斷每一天猴子要做的事
            //DayOfWeek today = DateTime.Now.DayOfWeek;
            //switch (today)
            //{
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("星期一，猴子穿新衣");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("星期二，猴子肚子餓");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("星期三，猴子去爬山");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("星期四，猴子看電視");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("星期五，猴子去跳舞");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("星期六，猴子去斗六");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("星期日，猴子過生日");
            //        break;
            //}Console.ReadKey();

            //8-9輸入‘兩個日期，輸出兩個日期相差幾天
            //Console.WriteLine("請輸入日期1 ex.yyyy/mm/dd");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("請輸入日期2 ex.yyyy/mm/dd");
            //string input2 = Console.ReadLine();
            //if (DateTime.TryParse(input1, out DateTime date1) && DateTime.TryParse(input2, out DateTime date2))
            //{   //時間差
            //    TimeSpan differance = date1 - date2;
            //    int daysdifference = Math.Abs(differance.Days);
            //    Console.WriteLine($"兩個日期相差{daysdifference}天");
            //}
            //else
            //{
            //    Console.WriteLine("不正確請重新輸入");
            //}
            //Console.ReadKey();

            //8-10兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，
            //時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            //他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            //M = 月     D = 日      S = (M * 2 + D) % 3
            //得到 S 的值，再依照 S 的值從 0 到 2 分別給與
            //普通、吉、大吉 等三種不同的運勢，輸出運勢。
            //Console.Write("輸入月份");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("輸入日期");
            //int day = Convert.ToInt32(Console.ReadLine());
            //if (month < 1  ||  month>12  || day<1 || day>31)
            //{
            //    Console.WriteLine("輸入無效");
            //    return;//終止
            //}
            //int s = (month * 2 + day) % 3;
            //Console.WriteLine($"輸入日期{month}/{day}");
            //switch (s)
            //{
            //    case 0:
            //        Console.WriteLine("運勢普通");
            //        break;
            //    case 1:
            //        Console.WriteLine("運勢吉");
            //        break;
            //    case 2:
            //        Console.WriteLine("運勢大吉");
            //        break;
            //    default:
            //        Console.WriteLine("運勢無法計算");
            //        break;
            //}Console.ReadKey();

        }
    }
}
        
