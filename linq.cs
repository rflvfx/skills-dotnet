var nums = Enumerable.Range(1, 10);

var evens = nums.Where(n => n % 2 == 0).ToList();
var total = nums.Sum();
var grouped = nums.GroupBy(n => n % 3);

Console.WriteLine($"{total} | {string.Join(",", evens)}");
- Add example — iteration 2 (2015)
- Fix typo — iteration 9 (2015)
- Update config — iteration 13 (2015)
- Add tests — iteration 15 (2015)
- Minor cleanup — iteration 16 (2015)
