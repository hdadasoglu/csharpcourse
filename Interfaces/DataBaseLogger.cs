namespace Interfaces
{
    public class DataBaseLogger:ILogger
    {
        public void WriteLog(){
            Console.WriteLine("Data base Yaz");
        }
    }
}