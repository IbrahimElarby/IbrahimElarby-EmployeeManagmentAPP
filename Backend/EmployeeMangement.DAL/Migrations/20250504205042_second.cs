using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeMangement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, "donald.baird1@yahoo.com", "Donald", "Baird", "Software Engineer" },
                    { 2, "omar.peters2@gmail.com", "Omar", "Peters", "UX Designer" },
                    { 3, "mark.clark3@yahoo.com", "Mark", "Clark", "Project Manager" },
                    { 4, "jessica.arnold4@yahoo.com", "Jessica", "Arnold", "QA Engineer" },
                    { 5, "cheryl.brown5@gmail.com", "Cheryl", "Brown", "Project Manager" },
                    { 6, "adam.torres6@hotmail.com", "Adam", "Torres", "Business Analyst" },
                    { 7, "mary.stevens7@hotmail.com", "Mary", "Stevens", "Product Owner" },
                    { 8, "nicholas.meyer8@hotmail.com", "Nicholas", "Meyer", "Software Engineer" },
                    { 9, "connie.carroll9@gmail.com", "Connie", "Carroll", "Product Owner" },
                    { 10, "ronnie.taylor10@hotmail.com", "Ronnie", "Taylor", "Product Owner" },
                    { 11, "stacy.carter11@yahoo.com", "Stacy", "Carter", "System Administrator" },
                    { 12, "adrienne.williams12@yahoo.com", "Adrienne", "Williams", "Software Engineer" },
                    { 13, "taylor.cox13@hotmail.com", "Taylor", "Cox", "Technical Writer" },
                    { 14, "ryan.wilkins14@gmail.com", "Ryan", "Wilkins", "UX Designer" },
                    { 15, "scott.garcia15@gmail.com", "Scott", "Garcia", "Project Manager" },
                    { 16, "sandra.clark16@hotmail.com", "Sandra", "Clark", "UX Designer" },
                    { 17, "ross.hull17@yahoo.com", "Ross", "Hull", "Project Manager" },
                    { 18, "abigail.turner18@gmail.com", "Abigail", "Turner", "Project Manager" },
                    { 19, "kevin.allen19@yahoo.com", "Kevin", "Allen", "Software Engineer" },
                    { 20, "jonathan.jones20@hotmail.com", "Jonathan", "Jones", "DevOps Engineer" },
                    { 21, "gary.hoover21@yahoo.com", "Gary", "Hoover", "DevOps Engineer" },
                    { 22, "justin.smith22@hotmail.com", "Justin", "Smith", "Product Owner" },
                    { 23, "sally.lang23@gmail.com", "Sally", "Lang", "Data Analyst" },
                    { 24, "diana.houston24@gmail.com", "Diana", "Houston", "Product Owner" },
                    { 25, "caitlin.moore25@gmail.com", "Caitlin", "Moore", "UX Designer" },
                    { 26, "taylor.delacruz26@gmail.com", "Taylor", "Delacruz", "Data Analyst" },
                    { 27, "erica.robinson27@yahoo.com", "Erica", "Robinson", "DevOps Engineer" },
                    { 28, "kevin.lane28@gmail.com", "Kevin", "Lane", "QA Engineer" },
                    { 29, "jimmy.murphy29@hotmail.com", "Jimmy", "Murphy", "Project Manager" },
                    { 30, "larry.thompson30@gmail.com", "Larry", "Thompson", "Data Analyst" },
                    { 31, "ryan.ford31@yahoo.com", "Ryan", "Ford", "UX Designer" },
                    { 32, "raymond.morales32@gmail.com", "Raymond", "Morales", "QA Engineer" },
                    { 33, "steven.bauer33@gmail.com", "Steven", "Bauer", "Software Engineer" },
                    { 34, "larry.vargas34@gmail.com", "Larry", "Vargas", "System Administrator" },
                    { 35, "joshua.perkins35@yahoo.com", "Joshua", "Perkins", "System Administrator" },
                    { 36, "gerald.howe36@gmail.com", "Gerald", "Howe", "Technical Writer" },
                    { 37, "gabriel.sloan37@gmail.com", "Gabriel", "Sloan", "Software Engineer" },
                    { 38, "danielle.gutierrez38@gmail.com", "Danielle", "Gutierrez", "UX Designer" },
                    { 39, "anna.freeman39@gmail.com", "Anna", "Freeman", "DevOps Engineer" },
                    { 40, "sean.richards40@gmail.com", "Sean", "Richards", "Data Analyst" },
                    { 41, "amy.clarke41@gmail.com", "Amy", "Clarke", "Technical Writer" },
                    { 42, "emma.warner42@gmail.com", "Emma", "Warner", "System Administrator" },
                    { 43, "abigail.mercado43@gmail.com", "Abigail", "Mercado", "Technical Writer" },
                    { 44, "lauren.castro44@hotmail.com", "Lauren", "Castro", "DevOps Engineer" },
                    { 45, "anthony.martinez45@yahoo.com", "Anthony", "Martinez", "UX Designer" },
                    { 46, "mark.hernandez46@yahoo.com", "Mark", "Hernandez", "Project Manager" },
                    { 47, "ashley.beck47@yahoo.com", "Ashley", "Beck", "DevOps Engineer" },
                    { 48, "ryan.wise48@yahoo.com", "Ryan", "Wise", "Technical Writer" },
                    { 49, "alice.lynch49@yahoo.com", "Alice", "Lynch", "Technical Writer" },
                    { 50, "amanda.gonzalez50@gmail.com", "Amanda", "Gonzalez", "Product Owner" },
                    { 51, "gregory.sosa51@gmail.com", "Gregory", "Sosa", "DevOps Engineer" },
                    { 52, "matthew.barrett52@yahoo.com", "Matthew", "Barrett", "System Administrator" },
                    { 53, "stacy.stewart53@hotmail.com", "Stacy", "Stewart", "DevOps Engineer" },
                    { 54, "glen.donaldson54@yahoo.com", "Glen", "Donaldson", "Technical Writer" },
                    { 55, "justin.marquez55@gmail.com", "Justin", "Marquez", "Data Analyst" },
                    { 56, "cathy.smith56@gmail.com", "Cathy", "Smith", "UX Designer" },
                    { 57, "jonathan.baker57@yahoo.com", "Jonathan", "Baker", "Software Engineer" },
                    { 58, "christopher.benjamin58@hotmail.com", "Christopher", "Benjamin", "DevOps Engineer" },
                    { 59, "russell.ellis59@gmail.com", "Russell", "Ellis", "DevOps Engineer" },
                    { 60, "elizabeth.jenkins60@gmail.com", "Elizabeth", "Jenkins", "Software Engineer" },
                    { 61, "katherine.robertson61@gmail.com", "Katherine", "Robertson", "System Administrator" },
                    { 62, "karen.smith62@hotmail.com", "Karen", "Smith", "DevOps Engineer" },
                    { 63, "michael.morales63@yahoo.com", "Michael", "Morales", "System Administrator" },
                    { 64, "rebecca.cooper64@gmail.com", "Rebecca", "Cooper", "Technical Writer" },
                    { 65, "barbara.robles65@yahoo.com", "Barbara", "Robles", "Software Engineer" },
                    { 66, "luis.hill66@hotmail.com", "Luis", "Hill", "System Administrator" },
                    { 67, "michael.turner67@yahoo.com", "Michael", "Turner", "QA Engineer" },
                    { 68, "elizabeth.hicks68@hotmail.com", "Elizabeth", "Hicks", "Project Manager" },
                    { 69, "joshua.clay69@yahoo.com", "Joshua", "Clay", "Project Manager" },
                    { 70, "tara.williams70@hotmail.com", "Tara", "Williams", "Business Analyst" },
                    { 71, "sheila.davidson71@yahoo.com", "Sheila", "Davidson", "Business Analyst" },
                    { 72, "bryan.jackson72@yahoo.com", "Bryan", "Jackson", "Software Engineer" },
                    { 73, "katie.lopez73@gmail.com", "Katie", "Lopez", "Product Owner" },
                    { 74, "debbie.velazquez74@yahoo.com", "Debbie", "Velazquez", "System Administrator" },
                    { 75, "kelly.caldwell75@hotmail.com", "Kelly", "Caldwell", "Project Manager" },
                    { 76, "tanya.york76@hotmail.com", "Tanya", "York", "System Administrator" },
                    { 77, "joseph.cook77@hotmail.com", "Joseph", "Cook", "DevOps Engineer" },
                    { 78, "wendy.barry78@yahoo.com", "Wendy", "Barry", "Technical Writer" },
                    { 79, "juan.robinson79@hotmail.com", "Juan", "Robinson", "Business Analyst" },
                    { 80, "logan.lewis80@yahoo.com", "Logan", "Lewis", "Project Manager" },
                    { 81, "derrick.wright81@hotmail.com", "Derrick", "Wright", "Business Analyst" },
                    { 82, "anthony.ortega82@gmail.com", "Anthony", "Ortega", "Product Owner" },
                    { 83, "janice.monroe83@gmail.com", "Janice", "Monroe", "UX Designer" },
                    { 84, "mark.houston84@gmail.com", "Mark", "Houston", "Technical Writer" },
                    { 85, "daniel.harding85@hotmail.com", "Daniel", "Harding", "QA Engineer" },
                    { 86, "julie.miller86@gmail.com", "Julie", "Miller", "QA Engineer" },
                    { 87, "nicholas.king87@gmail.com", "Nicholas", "King", "System Administrator" },
                    { 88, "jessica.williamson88@gmail.com", "Jessica", "Williamson", "UX Designer" },
                    { 89, "mary.acevedo89@gmail.com", "Mary", "Acevedo", "Data Analyst" },
                    { 90, "samantha.ortiz90@yahoo.com", "Samantha", "Ortiz", "UX Designer" },
                    { 91, "melissa.davis91@hotmail.com", "Melissa", "Davis", "Business Analyst" },
                    { 92, "samantha.reese92@hotmail.com", "Samantha", "Reese", "DevOps Engineer" },
                    { 93, "sara.davis93@gmail.com", "Sara", "Davis", "Business Analyst" },
                    { 94, "nicholas.holloway94@gmail.com", "Nicholas", "Holloway", "QA Engineer" },
                    { 95, "christopher.rios95@gmail.com", "Christopher", "Rios", "QA Engineer" },
                    { 96, "melissa.jenkins96@yahoo.com", "Melissa", "Jenkins", "Product Owner" },
                    { 97, "amanda.rivera97@yahoo.com", "Amanda", "Rivera", "Project Manager" },
                    { 98, "christopher.carter98@gmail.com", "Christopher", "Carter", "UX Designer" },
                    { 99, "alan.martinez99@yahoo.com", "Alan", "Martinez", "Business Analyst" },
                    { 100, "katelyn.moore100@gmail.com", "Katelyn", "Moore", "DevOps Engineer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
