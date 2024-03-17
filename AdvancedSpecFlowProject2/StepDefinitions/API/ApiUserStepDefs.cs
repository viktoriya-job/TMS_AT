using AdvancedSpecFlowProject.Steps.API;
using AdvancedSpecFlowProject2.StepDefinitions.GUI;

namespace AdvancedSpecFlowProject2.StepDefinitions.API;

[Binding]
public class ApiUserStepDefs : BaseApiSteps
{
    [Given(@"send request with correct data")]
    public void GivenSendRequestWithCorrectData()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"response status code is (.*)")]
    public void ThenResponseStatusCodeIs(int p0)
    {
        ScenarioContext.StepIsPending();
    }
}