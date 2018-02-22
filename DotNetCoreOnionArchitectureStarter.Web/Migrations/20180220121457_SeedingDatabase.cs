using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DotNetCoreOnionArchitectureStarter.Web.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TodoItems (Title, Description, IsDone, Created, LastModified) " +
                                 "VALUES ('Title 1', 'Description 1', 0, '2018-02-20 19:05:00', '2018-02-20 19:05:00')");
            migrationBuilder.Sql("INSERT INTO TodoItems (Title, Description, IsDone, Created, LastModified) " +
                                 "VALUES ('Title 2', 'Description 2', 0, '2018-02-20 19:05:00', '2018-02-20 19:05:00')");
            migrationBuilder.Sql("INSERT INTO TodoItems (Title, Description, IsDone, Created, LastModified) " +
                                 "VALUES ('Title 3', 'Description 3', 0, '2018-02-20 19:05:00', '2018-02-20 19:05:00')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TodoItems WHERE Title in ('Title 1', 'Title 2','Title 3')");
        }
    }
}
