using Task3.Elements;

namespace Task3.Models
{
    public class Milestone
    {
        public string Name { get; }
        public string References { get; }
        public int? Parent { get; }
        public string Description { get; }
        public int StartDate { get; }
        public int EndDate { get; }
        public bool IsMilestoneCompleted { get; }

        private Milestone(string name, string references, int? parent, string description, int startDate, int endDate, bool isMilestoneCompleted)
        {
            Name = name;
            References = references;
            Parent = parent;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            IsMilestoneCompleted = isMilestoneCompleted;
        }

        public class Builder
        {
            public string Name { get; set; }
            public string References { get; set; }
            public int Parent { get; set; }
            public string Description { get; set; }
            public int StartDate { get; set; }
            public int EndDate { get; set; }
            public bool IsMilestoneCompleted { get; set; }

            public Builder SetName(string name)
            {
                Name = name;
                return this;
            }

            public Builder SetReferences(string references)
            {
                References = references;
                return this;
            }

            public Builder SetParent(int parent)
            {
                Parent = parent;
                return this;
            }

            public Builder SetDescription(string description)
            {
                Description = description;
                return this;
            }

            public Builder SetStartDate(int startDate)
            {
                StartDate = startDate;
                return this;
            }

            public Builder SetEndDate(int endDate)
            {
                EndDate = endDate;
                return this;
            }

            public Builder SetIsMilestoneCompleted(bool isMilestoneCompleted)
            {
                IsMilestoneCompleted = isMilestoneCompleted;
                return this;
            }

            public Milestone Build()
            {
                if (string.IsNullOrWhiteSpace(Name))
                    throw new InvalidOperationException("Name can not be null");

                return new Milestone(
                    Name,
                    References,
                    Parent,
                    Description,
                    StartDate,
                    EndDate,
                    IsMilestoneCompleted
                    );
            }
        }
    }
}