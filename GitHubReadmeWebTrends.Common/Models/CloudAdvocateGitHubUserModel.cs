namespace GitHubReadmeWebTrends.Common
{
    public class CloudAdvocateGitHubUserModel
    {
        public CloudAdvocateGitHubUserModel(in string fullName, in string gitHubUserName, in string microsoftAlias, in string team)
        {
            FullName = fullName;
            GitHubUserName = gitHubUserName;
            MicrosoftAlias = microsoftAlias;
            Team = team;
        }

        public string FullName { get; }
        public string GitHubUserName { get; }
        public string MicrosoftAlias { get; }
        public string Team { get; }
    }
}
