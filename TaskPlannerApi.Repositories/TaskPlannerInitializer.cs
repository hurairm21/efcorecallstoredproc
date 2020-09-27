using System.Collections.Generic;
using System.Linq;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories
{
    public class TaskPlannerInitializer
    {
        public static void Initialize(TaskPlannerDbContext context)
        {
            var initializer = new TaskPlannerInitializer();
            initializer.Seed(context);
        }

        private void Seed(TaskPlannerDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Status.Any())
            {
                return; // Db already seeded.
            }

            var statuses = new List<Status>
            {
                new Status()
                {
                    Name = "Todo"
                },
                new Status()
                {
                    Name = "In Progress"
                },
                new Status()
                {
                    Name = "Dsone"
                }
            };

            var users = new List<User>
            {
                new User()
                {
                    FirstName = "Sachin",
                    LastName = "Kumar",
                    Email = "sachin.kumar@grapectiy.com",
                    Username = "sachinkumargrapecity",
                },
                new User()
                {
                    FirstName = "Ramveer",
                    LastName = "Singh",
                    Email = "ramveer.singh@grapectiy.com",
                    Username = "ramveersingh",
                },
                new User()
                {
                    FirstName = "Kanika",
                    LastName = "Kumar",
                    Email = "kanika.kumar@grapectiy.com",
                    Username = "kanikakumar",
                },
                new User()
                {
                    FirstName = "Shobhon",
                    LastName = "Chatterhjee",
                    Email = "shobhon.chatterjee@grapectiy.com",
                    Username = "shobhonechatterjee",
                },
                new User()
                {
                    FirstName = "Avdesh",
                    LastName = "Chaudhary",
                    Email = "avdesh.chaudhary@grapectiy.com",
                    Username = "avdeshchaudhary",
                },
                new User()
                {
                    FirstName = "Madhu",
                    LastName = "Bujoo",
                    Email = "madhu.bujoo@grapectiy.com",
                    Username = "madhubujoo",
                }
            };

            var teams = new List<Team>()
            {
                new Team()
                {
                    Name = "Software Development",
                },
                new Team()
                {
                    Name = "Software Testing",
                },
                new Team()
                {
                    Name = "Business Development",
                },
                new Team()
                {
                    //Id = 4,
                    Name = "Software Management",
                },
                new Team()
                {
                    Name = "Human Relations",
                }
            };

            var userTeams = new List<UserTeam>()
            {
                new UserTeam()
                {
                    User = users[0],
                    Team = teams[0]
                },
                new UserTeam()
                {
                    User = users[1],
                    Team = teams[0]
                },
                new UserTeam()
                {
                    User = users[2],
                    Team = teams[1]
                },
                new UserTeam()
                {
                    User = users[3],
                    Team = teams[0]
                },
                new UserTeam()
                {
                    User = users[3],
                    Team = teams[2]
                },
                new UserTeam()
                {
                    User = users[4],
                    Team = teams[3]
                },
                new UserTeam()
                {
                    User = users[5],
                    Team = teams[4]
                },
            };

            context.Status.AddRange(statuses);
            context.Users.AddRange(users);
            context.Teams.AddRange(teams);
            context.UserTeams.AddRange(userTeams);

            context.SaveChanges();
        }
    }
}
