public class Query
{
    public IEnumerable<SubRequest> GetRequests() =>
        new [] {
            new SubRequest {
                TeeTime = DateTime.Now.AddDays(1),
                ForTeam = 5,
                Contact = new Player {
                    Email = "pjirsa@gmail.com",
                    FirstName = "Phil",
                    LastName = "Jirsa",
                    Team = 5,
                    MemberType = MemberType.Regular
                }
            }
        };
}

public class SubRequest
{
    public bool IsMatched { get; set; } = false;
    public DateTime TeeTime { get; set; } = default!;
    public int ForTeam { get; set; } = default!;
    public Player Contact { get; set; } = default!;
}

public class Player
{
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public int Team { get; set; } = default!;
    public MemberType MemberType { get; set; } = default!;


}

public enum MemberType
{
    Regular,
    SubstituteOnly
}
