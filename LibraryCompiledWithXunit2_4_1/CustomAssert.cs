using Xunit.Sdk;

namespace LibraryCompiledWithXunit2_4_1;

public static class CustomAssert
{
    public static void Custom()
        => throw new AssertActualExpectedException(
            expected: "expected",
            actual: "actual",
            userMessage: "userMessage");
}