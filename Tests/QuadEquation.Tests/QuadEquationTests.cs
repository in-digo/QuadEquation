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

    [Fact]
    public void Solve_TwoRoots_WhenDiscriminantIsPositive()
    {
        //Arrange
        var solver = new Solver();

        //Act
        var roots = solver.Solve(1, 0, -1); //x^2  - 1 = 0

        //Assert
        Assert.Equal(2, roots.Length);
        Assert.True(Math.Abs(roots[0] - roots[1]) > solver.Epsilon);
    }

    [Fact]
    public void Solve_OneRoot_WhenDiscriminantIsZero()
    {
        //Arrange
        var solver = new Solver();

        //Act
        var roots = solver.Solve(1, 2, 1 - solver.Epsilon / 8); //x^2 + 2x + почти 1 = 0

        //Assert
        Assert.Equal(2, roots.Length);
        Assert.True(Math.Abs(roots[0] - roots[1]) < solver.Epsilon);
    }

    [Fact]
    public void Solve_ThrowsArgumentException_WhenAIsZero()
    {
        //Arrange
        var solver = new Solver();

        //Act + Assert
        Assert.Throws<ArgumentException>(() => solver.Solve(0, 1, 1));              //а ровно 0
        Assert.Throws<ArgumentException>(() => solver.Solve(solver.Epsilon / 2, 1, 1));   //а меньше epsilon
    }
}