
int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

double b1 = Zapros("Введите b1");
double k1 = Zapros("Введите k1");
double b2 = Zapros("Введите b2");
double k2 = Zapros("Введите k2");

void FindDot(double B1, double K1, double B2, double K2) {
    double x = (B1 - B2) / (K2 - K1);
    double y = K1 * x + B1;
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
}

FindDot(b1,k1,b2,k2);

