public record User(int Id, string Name, string Email);

public static class Seed
{
    public static List<User> Users => new()
    {
        new User(1, "Ana", "ana@dev.io"),
        new User(2, "Bruno", "bruno@dev.io"),
    };
}
- Tweak implementation — iteration 4 (2015)
- Update dependencies — iteration 6 (2015)
- Add tests — iteration 7 (2015)
- Add example — iteration 11 (2015)
- Optimize performance — iteration 12 (2015)
- Fix typo — iteration 26 (2015)
- Update docs — iteration 27 (2015)
- Improve error handling — iteration 35 (2015)
- Optimize performance — iteration 38 (2015)
- Improve naming — iteration 42 (2015)
- Add validation — iteration 51 (2015)
- Add example — iteration 52 (2015)
- Update docs — iteration 55 (2015)
- Update config — iteration 56 (2015)
