


using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        double[] faturamento_anual = [994.09, 0.0 , 806.14, 671.28, 352.25, 29.86, 173.08, 848.97, 631.72,
            289.13, 520.20, 725.62, 510.29, 268.71, 788.36, 747.69, 184.78, 90.64, 208.76, 439.85, 
            85.67, 484.72, 12.78, 78.21, 478.92, 600.73, 916.54, 677.11, 770.72, 670.26, 408.60, 647.49,
            343.68, 858.18, 319.25, 863.11, 194.91, 392.93, 66.64, 742.19, 730.28, 137.52, 899.36, 520.29,
            250.34, 719.35, 764.52, 813.18, 999.57, 750.18, 424.50, 301.76, 31.27, 728.63, 208.22, 799.23,
            140.75, 974.64, 320.56, 724.73, 858.83, 737.44, 728.32, 938.64, 20.20, 873.91, 872.63, 678.11,
            273.47, 283.48, 446.54, 737.15, 41.43, 400.43, 623.67, 669.00, 697.77, 377.18, 529.70, 982.52,
            905.74, 15.17, 798.59, 0.0, 772.55, 552.00, 656.72, 181.75, 545.77, 0.0, 3.75, 168.45, 845.04, 616.94,
            663.65, 828.89, 270.80, 0.0, 870.21, 443.31, 447.87, 560.57, 245.14, 651.38, 675.17, 335.95, 729.04,
            973.03, 880.60, 308.77, 987.82, 812.80, 202.10, 31.05, 107.13, 892.58, 300.50, 105.36, 417.01, 
            846.21, 637.10, 649.57, 526.95, 831.23, 369.54, 558.05, 0.0, 582.49, 97.34, 974.43, 85.23, 539.14,
            950.81, 787.92, 138.99, 950.12, 173.30, 803.13, 647.15, 803.17, 79.64, 906.03, 28.75, 358.47,
            432.64, 62.97, 267.50, 0.0, 881.74, 264.29, 957.13, 952.70, 537.85, 53.13, 503.11, 50.57, 720.23, 
            112.17, 569.69, 791.27, 92.66, 579.84, 372.52, 331.50, 257.93, 789.08, 706.69, 239.93, 557.85,
            44.76, 515.58, 797.01, 904.27, 927.67, 541.02, 442.38, 225.98, 333.24, 647.89, 559.72, 602.25,
            453.15, 854.09, 802.58, 0.0, 183.19, 513.82, 299.41, 174.09, 951.19, 481.29, 341.45, 793.80, 968.61,
            641.03, 363.09, 756.87, 647.32, 387.78, 515.89, 513.01, 170.99, 882.76, 479.01, 336.80, 435.48,
            237.01, 726.95, 377.93, 187.83];
        Console.WriteLine("------------------ Annual Income Report ------------------------------------------");
        TotalBilling(faturamento_anual);
        MinBilling(faturamento_anual);
        MaxBilling(faturamento_anual);

    }
    public static void TotalBilling(double[] vetor)
    {
        double soma = 0;
        int totalDias = 0;
        var r1 = new HashSet <double>();    
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == 0)
            {
                totalDias++;               
            }
            if (vetor[i] != 0)
            {
                r1.Add(vetor[i]);
            }
            soma += vetor[i];
        }   
        var r2 = r1.Average();
        var r3 = r1.Select(x => x).Where(x => x > r2);
        Console.WriteLine($"Total days in which income was above average income '{r2.ToString("C")}': {r3.Count()} days");
        Console.WriteLine($"Total of the annual income: {soma.ToString("C")}");

    }
    public static void MinBilling(double[] vetor)
    {
        var r1 = new HashSet<double>();
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                r1.Add(vetor[i]);
            }        

        }
        r1.Select(i => i).Where(i => i > 0 && i < r1.Min());
        Console.WriteLine($"Minimum income day: R${r1.Min()}");
    }
    public static void MaxBilling(double[] vetor)
    {
        var r1 = new HashSet<double>();
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                r1.Add(vetor[i]);
            }
            r1.Add(vetor[i]);
        }

        Console.WriteLine($"Maximun income day: R${r1.Max()}");
    }
}