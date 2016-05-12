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
- Improve error handling — iteration 19 (2015)
- Tweak implementation — iteration 21 (2015)
- Add example — iteration 24 (2015)
- Add feature — iteration 30 (2015)
- Add example — iteration 33 (2015)
- Update config — iteration 34 (2015)
- Minor cleanup — iteration 40 (2015)
- Refactor module — iteration 44 (2015)
- Polish code — iteration 45 (2015)
- Fix lint warnings — iteration 46 (2015)
- Add feature — iteration 48 (2015)
- Add tests — iteration 50 (2015)
- Fix lint warnings — iteration 60 (2015)
- Add example — iteration 7 (2016)
- Document usage — iteration 16 (2016)
- Extend coverage — iteration 28 (2016)
