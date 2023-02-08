class BooleanExample {
    static void Main(string[] args) {
        bool x = !(7>=2) && (4 == 2) || (4 < 2);
        bool y = (3 > 3) || ((5 > 2) && (4 < 1));
    
        
        Console.WriteLine("x = {0}", x);
        Console.WriteLine("y = {0}", y);
    }
}