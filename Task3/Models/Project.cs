using Task3.Elements;

namespace Task3.Models
{
    public class Project
    {
        public string Id { get; }
        public string ProjectName { get; }
        public string Announcement { get; }
        public bool IsShowAnnouncement { get; }
        public int ProjectType { get; }
        public bool IsTestCaseApprovals { get; }

        private Project(string id, string projectName, string announcement, bool isShowAnnouncement, int projectType, bool isTestCaseApprovals)
        {
            Id = id;
            ProjectName = projectName;
            Announcement = announcement;
            IsShowAnnouncement = isShowAnnouncement;
            ProjectType = projectType;
            IsTestCaseApprovals = isTestCaseApprovals;
        }

        public class Builder
        {
            public string Id { get; set; }
            public string ProjectName { get; set; }
            public string Announcement { get; set; }
            public bool IsShowAnnouncement { get; set; }
            public int ProjectType { get; set; }
            public bool IsTestCaseApprovals { get; set; }

            public Builder SetID(string id)
            {
                Id = id;
                return this;
            }

            public Builder SetProjectName(string projectName)
            {
                ProjectName = projectName;
                return this;
            }

            public Builder SetAnnouncement(string announcement)
            {
                Announcement = announcement;
                return this;
            }

            public Builder SetIsShowAnnouncement(bool isShowAnnouncement)
            {
                IsShowAnnouncement = isShowAnnouncement;
                return this;
            }

            public Builder SetProjectType(int projectType)
            {
                ProjectType = projectType;
                return this;
            }

            public Builder SetIsTestCaseApprovals(bool isTestCaseApprovals)
            {
                IsTestCaseApprovals = isTestCaseApprovals;
                return this;
            }

            public Project Build()
            {
                if (string.IsNullOrWhiteSpace(ProjectName))
                    throw new InvalidOperationException("Name can not be null");

                return new Project(
                    Id,
                    ProjectName,
                    Announcement,
                    IsShowAnnouncement,
                    ProjectType,
                    IsTestCaseApprovals);
            }
        }
    }
}