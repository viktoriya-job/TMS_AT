using OpenQA.Selenium;
using Task3.Models;
using Task3.Pages;

namespace Task3.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver);

        return dashboardPage
                .ClickSidebarProjectsAddButton()
                .InputNameValue(project.ProjectName)
                .InputAnnouncementValue(project.Announcement)
                .CheckShowAnnouncementCheckbox(project.IsShowAnnouncement)
                .ChooseProjectType(project.ProjectType)
                .CheckCaseApprovalsCheckbox(project.IsTestCaseApprovals)
                .ClickAddButton();
    }
}