class Program {
    static void Main(string[] args) {
        Console.Write("Please input price: ");
        float price = float.Parse(Console.ReadLine());

        Console.Write("Please input money: ");
        float money = float.Parse(Console.ReadLine());

        float balance = money - price;

        Console.WriteLines("Balance is: {0:F2}",balance);

        if (balance >0.0){
            int total1000 = (int)balance / 1000;
            balance = balance - (total1000 * 1000);
            Console.WriteLine("1000: {0}", total1000);

            int total500 = (int)balance / 500;
            balance = balance - (total500 * 500);
            Console.WriteLine("500: {0}", total500);

            int total100 = (int)balance / 100;
            balance = balance - (total100 * 100);
            Console.WriteLine("100: {0}", total100);

            int total50 = (int)balance / 50;
            balance = balance - (total50 * 50);
            Console.WriteLine("50: {0}", total50);

            int total20 = (int)balance / 20;
            balance = balance - (total20 * 20);
            Console.WriteLine("20: {0}", total20);

            int total10 = (int)balance / 10;
            balance = balance - (total10 * 10);
            Console.WriteLine("10: {0}", total10);

            int total5 = (int)balance / 5;
            balance = balance - (total5 * 5);
            Console.WriteLine("5: {0}", total5);

            int total2 = (int)balance / 2;
            balance = balance - (total2 * 2);
            Console.WriteLine("2: {0}", total2);

            int total1 = (int)balance / 1;
            balance = balance - (total1 * 1);
            Console.WriteLine("1: {0}", total1);

            int totalDot50 = (int)balance / 0.50f;
            balance = balance - (totalDot50 * 0.50f);
            Console.WriteLine("0.50f: {0}", totalDot50);

            int totalDot25 = (int)balance / 0.25f;
            balance = balance - (totalDot25 * 0.25f);
            Console.WriteLine("0.25f: {0}", totalDot25);
        } else {
            Console.WriteLine("Please input money more than price.");
        }

    }
}

