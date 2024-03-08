using OpenQA.Selenium;
using Task2.Pages;
using Test2.Models;

namespace Task2.Steps;

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