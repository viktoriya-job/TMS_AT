using OpenQA.Selenium;
using Task3.Models;
using Task3.Pages;
using Task3.Pages.ProjectPages;

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

    public ProjectMilestonesPage AddMilestone(Milestone milestone)
    {
        ProjectPage projectPage = new ProjectPage(Driver);

        return projectPage
            .ClickAddMilestoneButton()
            .InputName(milestone.Name)
            .InputReference(milestone.References)
            .InputDescription(milestone.Description)
            .ChooseStartDate(milestone.StartDate)
            .ChooseEndDate(milestone.EndDate)
            .CheckIsCompleted(milestone.IsMilestoneCompleted)
            .ClickAddButton();
    }
}