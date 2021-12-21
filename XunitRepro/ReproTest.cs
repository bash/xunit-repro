using LibraryCompiledWithXunit2_4_1;
using Xunit;
using Xunit.Sdk;

namespace XunitRepro;

public class ReproTest
{
    [Fact]
    public void CustomAssertThrowsExpectedException()
    {
        Assert.Throws<AssertActualExpectedException>(() => CustomAssert.Custom());
    }
}