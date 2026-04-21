namespace QuadEquation;

public class Solver
{
    public double[] Solve(double a, double b, double c)
    {
        var discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
            return [];

        var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        return [x1, x2];
    }
}
