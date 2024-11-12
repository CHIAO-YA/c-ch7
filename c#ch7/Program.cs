using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
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
            ////寫入
            //File.WriteAllText(output, music, Encoding.UTF8);
            //Console.ReadKey();


            //7-2讀取1.txt 顯示在畫面上
            //string input = @"C:\Users\acer\Desktop\C#\txt\1.txt";
            //string a = File.ReadAllText(input);
            //Console.WriteLine("檔案內容" + a);
            //Console.ReadKey();


            //7-3寫入九九乘法表資料到一個文字檔到自己指定的文字檔
            //string input = @"C:\Users\acer\Desktop\C#\txt\99乘法表.txt";
            //string output = @"C:\Users\acer\Desktop\C#\txt\把99乘法放進來.txt";
            //string content = File.ReadAllText(input);// 讀取
            //File.WriteAllText(output, content);//寫入新檔
            //Console.ReadKey();

            //7-4讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
            //string input = @"C:\Users\acer\Desktop\C#\txt\1.txt";
            //string output = @"C:\Users\acer\Desktop\C#\txt\1_cover.txt";
            //string a = File.ReadAllText(input, Encoding.UTF8);
            //Console.WriteLine(a);
            //Dictionary<int, string> number = new Dictionary<int, string>
            //{
            //    { '0', "零" },
            //    { '1', "壹" },
            //    { '2', "貳" },
            //    { '3', "參" },
            //    { '4', "肆" },
            //    { '5', "伍" },
            //    { '6', "陸" },
            //    { '7', "柒" },
            //    { '8', "捌" },
            //    { '9', "玖" }
            //};
            //string change = ""; //阿拉伯數字換成中文數字
            //foreach (char c in a)
            //{
            //    if (char.IsDigit(c))//若是數字，則換為中文數字
            //    {
            //        change += number[c];
            //    }
            //    else
            //    {
            //        change += c;// 不是數字則保留原字元
            //    }
            //}
            //File.WriteAllText(output, change);//寫入
            //Console.WriteLine(change);
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

            //7-6請隨機由0~99產生一個數字輸出
            //Random A = new Random();
            //Console.WriteLine($"隨機生成數字:{ A.Next(0, 100)}");
            //Console.ReadKey();

            //7-7請隨機由0~99產生10個數字輸出。
            //Random row = new Random();
            //Console.WriteLine("隨機產生數字:");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(row.Next(0, 100)); 
            //}
            //Console.ReadKey();

            //7-8隨機幫每位學員產生成績，並寫入文字檔
            //(欄位之間用，分開，換行寫入下一筆)。
            //string[] student = {"Judy", "Amma", "Nina", "Irene" };
            //string output = @"C:\Users\acer\Desktop\C#\txt\學生成績.txt";
            //Random row = new Random();
            //string a = "";
            //for (int i = 0; i < student.Length; i++)
            //{
            //    a+=(student[i] +",成績是"+row.Next(0, 100)+ Environment.NewLine);       
            //}
            //Console.WriteLine(a);
            //File.WriteAllText(output,a);
            //Console.ReadKey();

            //7-9請設計樂透開獎程式。
            //Random row = new Random();
            //int[] numbers = new int[6];
            //int ages = 0;
            //while (ages < numbers.Length)
            //{
            //    int newnumber = row.Next(1, 50);
            //    bool a = false;
            //    for (int i = 0; i < ages; i++)
            //    {
            //        if (numbers[i] == newnumber)
            //        {
            //            a = true;
            //            break;
            //        }
            //    }
            //    if (!a)
            //    {
            //        numbers[ages] = newnumber;
            //        ages++;
            //    }
            //}
            //Console.WriteLine("本期中獎號碼:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + ",");
            //}
            //Console.ReadKey();



            //7-10請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            //string shop = @"C:\Users\acer\Desktop\C#\txt\午餐選擇.txt";
            //string[] lunch = File.ReadAllLines(shop);
            //Random row = new Random();
            //int a = row.Next(lunch.Length);
            //Console.WriteLine(lunch[a]); //lunch陣列取出a位置
            //Console.ReadKey();

            //7-11請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，
            //抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            //string school = @"C:\Users\acer\Desktop\C#\txt\學生名單.txt";
            //string[] student = File.ReadAllLines(school);
            //Random row = new Random();
            //List<string> a = new List<string>(student);
            //while (true)// 不斷進行抽籤
            //{
            //    if (a.Count == 0) // 如果所有學生都被抽過，重置列表
            //    {
            //        Console.WriteLine("全抽過,重新開始");
            //        a = new List<string>(student);// 重置學生名單
            //    }
            //    int b = row.Next(a.Count);// 隨機抽取一個學生
            //    Console.WriteLine("值日生:" + a[b]);
            //    a.RemoveAt(b);
            //    Console.WriteLine("下一位值日生");
            //    Console.ReadKey();
            //}

            //8-1顯示現在日期與時間
            //DateTime now = DateTime.Now;
            //Console.WriteLine("現在的日期和時間" + now.ToString());
            //Console.ReadKey();

            //8-2顯示再過30天為哪一天
            //DateTime today = DateTime.Now;
            //DateTime futureDate = today.AddDays(30);
            //Console.WriteLine("今天的日期" + today.ToString("yyyy/MM/dd"));
            //Console.WriteLine("30天過後" + futureDate.ToString("yyyy/MM/dd"));
            //Console.ReadKey();

            //8-3顯示24小時前的年月日時分秒
            //DateTime now = DateTime.Now;
            //DateTime past = now.AddHours(-24);
            //Console.WriteLine("現在的日期時間"+now.ToString());
            //Console.WriteLine("24小時前"+past.ToString());
            //Console.ReadKey();

            //8-4取得目前是幾月
            //DateTime now = DateTime.Now;
            //int nowmonth = now.Month;
            //Console.WriteLine("現在是" +nowmonth + "月");
            //Console.ReadKey();

            //8-5取得明年是否為閏年。(可以試試民國)
            //--->年份能被 4 整除且不能被 100 整除，或者能被 400 整除。
            //a || b;是 或 否
            //Console.WriteLine("輸入西元年");
            //int year = DateTime.Now.Year+1;
            //int taiwan = year - 1911;
            //bool leap = DateTime.IsLeapYear(year);
            //Console.WriteLine($"明年是民國{taiwan}年{(leap ? "是":"否")}閏年");
            //Console.ReadKey();

            //8-6取得離2025年1月1日還有幾天
            //DateTime nextyear= new DateTime(2025,1,1);
            //DateTime today = DateTime.Now.Date;
            //int a = (nextyear - today).Days;
            //Console.WriteLine($"距離2025/1/1還有{a}天");
            //Console.ReadKey();

            //8-7星期一，猴子穿新衣，星期二，猴子肚子餓，星期三，猴子去爬山，
            //星期四，猴子看電視，呈期五，猴子去跳舞，星期六，猴子去斗六，星期日，猴子過生日。
            //請顯示今天猴子做甚麼事。--->DayOfWeek從0到6代表一週7天，0是星期天6是星期六
            //switch 判斷每一天猴子要做的事
            //int today = (int)DateTime.Now.DayOfWeek;
            //switch (today)
            //{
            //    case 0:
            //    Console.WriteLine("星期天，猴子穿新衣");
            //    break;
            //    case 1:
            //    Console.WriteLine("星期一，猴子肚子餓");
            //    break;
            //    case 2:
            //    Console.WriteLine("星期二，猴子去爬山");
            //    break;
            //    case 3:
            //    Console.WriteLine("星期三，猴子看電視");
            //    break;
            //    case 4:
            //    Console.WriteLine("星期四，猴子去跳舞");
            //    break;
            //    case 5:
            //    Console.WriteLine("星期五，猴子去斗六");
            //    break;
            //    case 6:
            //    Console.WriteLine("星期六，猴子過生日");
            //    break;
            //   }Console.ReadKey();

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

                //8-10占卜，隨機產生一個今年日期： S = (M * 2 + D) % 3
                // S 值 0 到 2 分別 普通、吉、大吉，輸出運勢
                //Console.Write("輸入月份和日期 (格式: MM/dd): ");
                //string input = Console.ReadLine();
                //if (DateTime.TryParse(input, out DateTime date))
                //{
                //    int month = date.Month;
                //    int day = date.Day;
                //    Console.WriteLine($"輸入的日期為: {month}/{day}");
                //    int s = (month * 2 + day) % 3;
                //    switch (s)
                //    {
                //        case 0:
                //            Console.WriteLine("運勢普通");
                //            break;
                //        case 1:
                //            Console.WriteLine("運勢吉");
                //            break;
                //        case 2:
                //            Console.WriteLine("運勢大吉");
                //            break;
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("輸入無效，請確保格式為 MM/dd，例如 03/15");
                //}
                //Console.ReadKey();

            }
    }
}
        
