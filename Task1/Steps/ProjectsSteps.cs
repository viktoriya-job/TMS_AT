using OpenQA.Selenium;
using Task1.Pages;

namespace Task1.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProject(string projectName, string announcement, bool checkAnnouncement, int suiteMode, bool checkCaseStatuses)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver);

        return dashboardPage
                .ClickSidebarProjectsAddButton()
                .InputNameValue(projectName)
                .InputAnnouncementValue(announcement)
                .CheckShowAnnouncementCheckbox(checkAnnouncement)
                .ChooseProjectType(suiteMode)
                .CheckCaseApprovalsCheckbox(checkCaseStatuses)
                .ClickAddButton();
    }
}