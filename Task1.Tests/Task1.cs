using Task1;
namespace Task1.Tests;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var resolver = new CertificatesRouteResolver();
        List<int> expectedResult = [4,3,2,1];
        var cert4 = new Certificate(4);
        var cert3 = new Certificate(3);
        var cert2 = new Certificate(2,[new Certificate(3),new Certificate(4)]);
        var cert1 = new Certificate(1,[cert2]);

        var result = resolver.GetCertificatesRoute([cert1,cert2])
            .Select(c => c.Id);

        Assert.Equal([4,3,2,1], result);
    }

    [Fact]
    public void Test2()
    {
        var resolver = new CertificatesRouteResolver();
        var cert2 = new Certificate(2);
        var cert4 = new Certificate(4);
        var cert3 = new Certificate(3,[cert4]);
        var cert1 = new Certificate(1,[cert2]);

        var result = resolver.GetCertificatesRoute([cert1,cert3])
            .Select(c => c.Id);

        Assert.Equal([2,1,4,3], result);
    }

    [Fact]
    public void Test3() {
        var resolver = new CertificatesRouteResolver();
        var cert5 = new Certificate(5);
        var cert7 = new Certificate(7);
        var cert4 = new Certificate(4);
        var cert3 = new Certificate(3,[cert5,cert7]);
        var cert2 = new Certificate(2,[cert3,cert4]);
        var cert1 = new Certificate(1,[cert2]);

        var result = resolver.GetCertificatesRoute([cert1])
            .Select(c => c.Id);

        Assert.Equal([4,7,5,3,2,1], result);
    }

    [Fact]
    public void Test4() {
        var resolver = new CertificatesRouteResolver();
        var cert2 = new Certificate(2);
        var cert4 = new Certificate(4);
        var cert3 = new Certificate(3,[cert2,cert4]);
        var cert5 = new Certificate(5,[cert3]);

        var result = resolver.GetCertificatesRoute([cert5,cert3])
            .Select(c => c.Id);

        Assert.Equal([4,2,3,5], result);
    }

    [Fact]
    public void Test5() {
        var resolver = new CertificatesRouteResolver();
        var cert2 = new Certificate(2);
        var cert4 = new Certificate(4);
        var cert3 = new Certificate(3,[cert2,cert4]);
        var cert5 = new Certificate(5,[cert3]);

        var result = resolver.GetCertificatesRoute([cert3,cert5])
            .Select(c => c.Id);

        Assert.Equal([4,2,3,5], result);
    }

}