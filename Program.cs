class Program {
    static void Main(string[] args) {
        int capital = 20000;
        int year = 3;
        float rate = 6.25f;

        float result = capital * year * rate / 100.0f;

        Console.WriteLine("result is {0}",result);

    }
}

