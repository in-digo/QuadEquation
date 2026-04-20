using QuadEquation;

namespace QuadEquation.Tests;

public class QuadEquationTests
{
    [Fact]
    public void Solve_NoRoots_WhenDiscriminantIsNegative()
    {
        //Arrange
        var solver = new Solver();

        //Act
        var roots = solver.Solve(1, 0, 1);  //x^2 + 1 = 0

        //Assert
        Assert.Empty(roots);
    }
}