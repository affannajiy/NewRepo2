using OOP_LectureW11;

Console.WriteLine("Hello, World!");

Job job = new Job() { Name = "WashDish", Description = "Use Soap" };

// Need Speacial types of Jobs
// One Time Job: has a certain fixed start and end date
// Recurring Job: has a certain fixed start date when it was last done and a certain time interval before next execution (Sweep Floor)

List<Job> jobs = new List<Job>() { job };
jobs.Add(new OneTimeJobs() { Name = "WashDish", Description = "Use Soap" });