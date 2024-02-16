namespace SaucedemoPOSteps.Tests
{
    public class TestData
    {
        private static string password = "secret_sauce";

        public static object[] SuccessLoginUsers =
        {
            new object[] { "standard_user", password },
            //new object[] { "problem_user", password },
            //new object[] { "performance_glitch_user", password },
            //new object[] { "error_user", password },
            //new object[] { "visual_user", password }
        };
    }
}
