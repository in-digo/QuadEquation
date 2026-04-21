namespace QuadEquation;

public class Solver
{
    public double Epsilon => 1e-9;

    public double[] Solve(double a, double b, double c)
    {
        if (Math.Abs(a) < Epsilon)
            throw new ArgumentException("a не может быть равно 0");

        var discriminant = b * b - 4 * a * c;

        if (discriminant < -Epsilon)
            return [];
        if (Math.Abs(discriminant) < Epsilon)
            discriminant = 0;

        var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        return [x1, x2];
    }
}
