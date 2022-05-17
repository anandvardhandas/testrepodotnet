public class Program{
    public static void Main(){
        Console.WriteLine("Hello world!");
        PrintNNumbers(4);
    }

    public static void PrintNNumbers(int num){
        for(int i = 0; i <= num; i++){
            System.Console.WriteLine(i);
        }
    }
}
