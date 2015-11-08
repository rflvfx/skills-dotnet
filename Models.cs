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
