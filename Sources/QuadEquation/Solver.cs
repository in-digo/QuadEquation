namespace QuadEquation;

public class Solver
{
    public double Epsilon => 1e-9;

    public double[] Solve(double a, double b, double c)
    {
        if (!double.IsFinite(a))
            throw new ArgumentException("а должно быть корректным числом");
        if (Math.Abs(a) < Epsilon)
            throw new ArgumentException("a не может быть равно 0");
        if (!double.IsFinite(b))
            throw new ArgumentException("b должно быть корректным числом");
        if (!double.IsFinite(c))
            throw new ArgumentException("c должно быть корректным числом");

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
