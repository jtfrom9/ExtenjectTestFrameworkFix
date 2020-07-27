using Zenject;
using NUnit.Framework;

[TestFixture]
public class ExtenjectUnitTest : ZenjectUnitTestFixture
{
    [Inject]
    IFoo foo;

    [SetUp]
    public void CommonInstall()
    {
        Container.Bind<IFoo>().To<Foo>().AsSingle();
        Container.Inject(this);
    }

    [Test]
    public void RunTest1()
    {
        Assert.That(foo.Foo(), Is.EqualTo(10));
    }
}