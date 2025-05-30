﻿// <auto-generated />
using EmployeeMangement.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeMangement.DAL.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20250504205042_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeMangement.DAL.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "donald.baird1@yahoo.com",
                            FirstName = "Donald",
                            LastName = "Baird",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 2,
                            Email = "omar.peters2@gmail.com",
                            FirstName = "Omar",
                            LastName = "Peters",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mark.clark3@yahoo.com",
                            FirstName = "Mark",
                            LastName = "Clark",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 4,
                            Email = "jessica.arnold4@yahoo.com",
                            FirstName = "Jessica",
                            LastName = "Arnold",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 5,
                            Email = "cheryl.brown5@gmail.com",
                            FirstName = "Cheryl",
                            LastName = "Brown",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 6,
                            Email = "adam.torres6@hotmail.com",
                            FirstName = "Adam",
                            LastName = "Torres",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 7,
                            Email = "mary.stevens7@hotmail.com",
                            FirstName = "Mary",
                            LastName = "Stevens",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 8,
                            Email = "nicholas.meyer8@hotmail.com",
                            FirstName = "Nicholas",
                            LastName = "Meyer",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 9,
                            Email = "connie.carroll9@gmail.com",
                            FirstName = "Connie",
                            LastName = "Carroll",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 10,
                            Email = "ronnie.taylor10@hotmail.com",
                            FirstName = "Ronnie",
                            LastName = "Taylor",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 11,
                            Email = "stacy.carter11@yahoo.com",
                            FirstName = "Stacy",
                            LastName = "Carter",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 12,
                            Email = "adrienne.williams12@yahoo.com",
                            FirstName = "Adrienne",
                            LastName = "Williams",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 13,
                            Email = "taylor.cox13@hotmail.com",
                            FirstName = "Taylor",
                            LastName = "Cox",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 14,
                            Email = "ryan.wilkins14@gmail.com",
                            FirstName = "Ryan",
                            LastName = "Wilkins",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 15,
                            Email = "scott.garcia15@gmail.com",
                            FirstName = "Scott",
                            LastName = "Garcia",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 16,
                            Email = "sandra.clark16@hotmail.com",
                            FirstName = "Sandra",
                            LastName = "Clark",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 17,
                            Email = "ross.hull17@yahoo.com",
                            FirstName = "Ross",
                            LastName = "Hull",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 18,
                            Email = "abigail.turner18@gmail.com",
                            FirstName = "Abigail",
                            LastName = "Turner",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 19,
                            Email = "kevin.allen19@yahoo.com",
                            FirstName = "Kevin",
                            LastName = "Allen",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 20,
                            Email = "jonathan.jones20@hotmail.com",
                            FirstName = "Jonathan",
                            LastName = "Jones",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 21,
                            Email = "gary.hoover21@yahoo.com",
                            FirstName = "Gary",
                            LastName = "Hoover",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 22,
                            Email = "justin.smith22@hotmail.com",
                            FirstName = "Justin",
                            LastName = "Smith",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 23,
                            Email = "sally.lang23@gmail.com",
                            FirstName = "Sally",
                            LastName = "Lang",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 24,
                            Email = "diana.houston24@gmail.com",
                            FirstName = "Diana",
                            LastName = "Houston",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 25,
                            Email = "caitlin.moore25@gmail.com",
                            FirstName = "Caitlin",
                            LastName = "Moore",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 26,
                            Email = "taylor.delacruz26@gmail.com",
                            FirstName = "Taylor",
                            LastName = "Delacruz",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 27,
                            Email = "erica.robinson27@yahoo.com",
                            FirstName = "Erica",
                            LastName = "Robinson",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 28,
                            Email = "kevin.lane28@gmail.com",
                            FirstName = "Kevin",
                            LastName = "Lane",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 29,
                            Email = "jimmy.murphy29@hotmail.com",
                            FirstName = "Jimmy",
                            LastName = "Murphy",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 30,
                            Email = "larry.thompson30@gmail.com",
                            FirstName = "Larry",
                            LastName = "Thompson",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 31,
                            Email = "ryan.ford31@yahoo.com",
                            FirstName = "Ryan",
                            LastName = "Ford",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 32,
                            Email = "raymond.morales32@gmail.com",
                            FirstName = "Raymond",
                            LastName = "Morales",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 33,
                            Email = "steven.bauer33@gmail.com",
                            FirstName = "Steven",
                            LastName = "Bauer",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 34,
                            Email = "larry.vargas34@gmail.com",
                            FirstName = "Larry",
                            LastName = "Vargas",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 35,
                            Email = "joshua.perkins35@yahoo.com",
                            FirstName = "Joshua",
                            LastName = "Perkins",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 36,
                            Email = "gerald.howe36@gmail.com",
                            FirstName = "Gerald",
                            LastName = "Howe",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 37,
                            Email = "gabriel.sloan37@gmail.com",
                            FirstName = "Gabriel",
                            LastName = "Sloan",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 38,
                            Email = "danielle.gutierrez38@gmail.com",
                            FirstName = "Danielle",
                            LastName = "Gutierrez",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 39,
                            Email = "anna.freeman39@gmail.com",
                            FirstName = "Anna",
                            LastName = "Freeman",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 40,
                            Email = "sean.richards40@gmail.com",
                            FirstName = "Sean",
                            LastName = "Richards",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 41,
                            Email = "amy.clarke41@gmail.com",
                            FirstName = "Amy",
                            LastName = "Clarke",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 42,
                            Email = "emma.warner42@gmail.com",
                            FirstName = "Emma",
                            LastName = "Warner",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 43,
                            Email = "abigail.mercado43@gmail.com",
                            FirstName = "Abigail",
                            LastName = "Mercado",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 44,
                            Email = "lauren.castro44@hotmail.com",
                            FirstName = "Lauren",
                            LastName = "Castro",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 45,
                            Email = "anthony.martinez45@yahoo.com",
                            FirstName = "Anthony",
                            LastName = "Martinez",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 46,
                            Email = "mark.hernandez46@yahoo.com",
                            FirstName = "Mark",
                            LastName = "Hernandez",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 47,
                            Email = "ashley.beck47@yahoo.com",
                            FirstName = "Ashley",
                            LastName = "Beck",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 48,
                            Email = "ryan.wise48@yahoo.com",
                            FirstName = "Ryan",
                            LastName = "Wise",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 49,
                            Email = "alice.lynch49@yahoo.com",
                            FirstName = "Alice",
                            LastName = "Lynch",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 50,
                            Email = "amanda.gonzalez50@gmail.com",
                            FirstName = "Amanda",
                            LastName = "Gonzalez",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 51,
                            Email = "gregory.sosa51@gmail.com",
                            FirstName = "Gregory",
                            LastName = "Sosa",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 52,
                            Email = "matthew.barrett52@yahoo.com",
                            FirstName = "Matthew",
                            LastName = "Barrett",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 53,
                            Email = "stacy.stewart53@hotmail.com",
                            FirstName = "Stacy",
                            LastName = "Stewart",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 54,
                            Email = "glen.donaldson54@yahoo.com",
                            FirstName = "Glen",
                            LastName = "Donaldson",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 55,
                            Email = "justin.marquez55@gmail.com",
                            FirstName = "Justin",
                            LastName = "Marquez",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 56,
                            Email = "cathy.smith56@gmail.com",
                            FirstName = "Cathy",
                            LastName = "Smith",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 57,
                            Email = "jonathan.baker57@yahoo.com",
                            FirstName = "Jonathan",
                            LastName = "Baker",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 58,
                            Email = "christopher.benjamin58@hotmail.com",
                            FirstName = "Christopher",
                            LastName = "Benjamin",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 59,
                            Email = "russell.ellis59@gmail.com",
                            FirstName = "Russell",
                            LastName = "Ellis",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 60,
                            Email = "elizabeth.jenkins60@gmail.com",
                            FirstName = "Elizabeth",
                            LastName = "Jenkins",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 61,
                            Email = "katherine.robertson61@gmail.com",
                            FirstName = "Katherine",
                            LastName = "Robertson",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 62,
                            Email = "karen.smith62@hotmail.com",
                            FirstName = "Karen",
                            LastName = "Smith",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 63,
                            Email = "michael.morales63@yahoo.com",
                            FirstName = "Michael",
                            LastName = "Morales",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 64,
                            Email = "rebecca.cooper64@gmail.com",
                            FirstName = "Rebecca",
                            LastName = "Cooper",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 65,
                            Email = "barbara.robles65@yahoo.com",
                            FirstName = "Barbara",
                            LastName = "Robles",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 66,
                            Email = "luis.hill66@hotmail.com",
                            FirstName = "Luis",
                            LastName = "Hill",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 67,
                            Email = "michael.turner67@yahoo.com",
                            FirstName = "Michael",
                            LastName = "Turner",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 68,
                            Email = "elizabeth.hicks68@hotmail.com",
                            FirstName = "Elizabeth",
                            LastName = "Hicks",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 69,
                            Email = "joshua.clay69@yahoo.com",
                            FirstName = "Joshua",
                            LastName = "Clay",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 70,
                            Email = "tara.williams70@hotmail.com",
                            FirstName = "Tara",
                            LastName = "Williams",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 71,
                            Email = "sheila.davidson71@yahoo.com",
                            FirstName = "Sheila",
                            LastName = "Davidson",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 72,
                            Email = "bryan.jackson72@yahoo.com",
                            FirstName = "Bryan",
                            LastName = "Jackson",
                            Position = "Software Engineer"
                        },
                        new
                        {
                            Id = 73,
                            Email = "katie.lopez73@gmail.com",
                            FirstName = "Katie",
                            LastName = "Lopez",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 74,
                            Email = "debbie.velazquez74@yahoo.com",
                            FirstName = "Debbie",
                            LastName = "Velazquez",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 75,
                            Email = "kelly.caldwell75@hotmail.com",
                            FirstName = "Kelly",
                            LastName = "Caldwell",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 76,
                            Email = "tanya.york76@hotmail.com",
                            FirstName = "Tanya",
                            LastName = "York",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 77,
                            Email = "joseph.cook77@hotmail.com",
                            FirstName = "Joseph",
                            LastName = "Cook",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 78,
                            Email = "wendy.barry78@yahoo.com",
                            FirstName = "Wendy",
                            LastName = "Barry",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 79,
                            Email = "juan.robinson79@hotmail.com",
                            FirstName = "Juan",
                            LastName = "Robinson",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 80,
                            Email = "logan.lewis80@yahoo.com",
                            FirstName = "Logan",
                            LastName = "Lewis",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 81,
                            Email = "derrick.wright81@hotmail.com",
                            FirstName = "Derrick",
                            LastName = "Wright",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 82,
                            Email = "anthony.ortega82@gmail.com",
                            FirstName = "Anthony",
                            LastName = "Ortega",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 83,
                            Email = "janice.monroe83@gmail.com",
                            FirstName = "Janice",
                            LastName = "Monroe",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 84,
                            Email = "mark.houston84@gmail.com",
                            FirstName = "Mark",
                            LastName = "Houston",
                            Position = "Technical Writer"
                        },
                        new
                        {
                            Id = 85,
                            Email = "daniel.harding85@hotmail.com",
                            FirstName = "Daniel",
                            LastName = "Harding",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 86,
                            Email = "julie.miller86@gmail.com",
                            FirstName = "Julie",
                            LastName = "Miller",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 87,
                            Email = "nicholas.king87@gmail.com",
                            FirstName = "Nicholas",
                            LastName = "King",
                            Position = "System Administrator"
                        },
                        new
                        {
                            Id = 88,
                            Email = "jessica.williamson88@gmail.com",
                            FirstName = "Jessica",
                            LastName = "Williamson",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 89,
                            Email = "mary.acevedo89@gmail.com",
                            FirstName = "Mary",
                            LastName = "Acevedo",
                            Position = "Data Analyst"
                        },
                        new
                        {
                            Id = 90,
                            Email = "samantha.ortiz90@yahoo.com",
                            FirstName = "Samantha",
                            LastName = "Ortiz",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 91,
                            Email = "melissa.davis91@hotmail.com",
                            FirstName = "Melissa",
                            LastName = "Davis",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 92,
                            Email = "samantha.reese92@hotmail.com",
                            FirstName = "Samantha",
                            LastName = "Reese",
                            Position = "DevOps Engineer"
                        },
                        new
                        {
                            Id = 93,
                            Email = "sara.davis93@gmail.com",
                            FirstName = "Sara",
                            LastName = "Davis",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 94,
                            Email = "nicholas.holloway94@gmail.com",
                            FirstName = "Nicholas",
                            LastName = "Holloway",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 95,
                            Email = "christopher.rios95@gmail.com",
                            FirstName = "Christopher",
                            LastName = "Rios",
                            Position = "QA Engineer"
                        },
                        new
                        {
                            Id = 96,
                            Email = "melissa.jenkins96@yahoo.com",
                            FirstName = "Melissa",
                            LastName = "Jenkins",
                            Position = "Product Owner"
                        },
                        new
                        {
                            Id = 97,
                            Email = "amanda.rivera97@yahoo.com",
                            FirstName = "Amanda",
                            LastName = "Rivera",
                            Position = "Project Manager"
                        },
                        new
                        {
                            Id = 98,
                            Email = "christopher.carter98@gmail.com",
                            FirstName = "Christopher",
                            LastName = "Carter",
                            Position = "UX Designer"
                        },
                        new
                        {
                            Id = 99,
                            Email = "alan.martinez99@yahoo.com",
                            FirstName = "Alan",
                            LastName = "Martinez",
                            Position = "Business Analyst"
                        },
                        new
                        {
                            Id = 100,
                            Email = "katelyn.moore100@gmail.com",
                            FirstName = "Katelyn",
                            LastName = "Moore",
                            Position = "DevOps Engineer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
