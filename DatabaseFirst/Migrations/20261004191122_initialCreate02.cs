using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Library");

            migrationBuilder.EnsureSchema(
                name: "Management");

            migrationBuilder.CreateTable(
                name: "Authors",
                schema: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Authors__3214EC0785D88615", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "Library",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Edition = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BookCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Books__447D36EB11731A7D", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Librarians",
                schema: "Management",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Libraria__3214EC0737786BE0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MembershipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MembershipDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Members__92A786791E71E3FE", x => x.MembershipId);
                });

            migrationBuilder.CreateTable(
                name: "Books_Authors",
                schema: "Library",
                columns: table => new
                {
                    BookISBN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Books_Au__69D776C8A41B1C2A", x => new { x.BookISBN, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BA_Author",
                        column: x => x.AuthorId,
                        principalSchema: "Library",
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BA_Book",
                        column: x => x.BookISBN,
                        principalSchema: "Library",
                        principalTable: "Books",
                        principalColumn: "ISBN");
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                schema: "Management",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    OpeningHours = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Branches__3214EC0736C7D3BF", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Branches__Manage__3A81B327",
                        column: x => x.ManagerId,
                        principalSchema: "Management",
                        principalTable: "Librarians",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookCopies",
                schema: "Library",
                columns: table => new
                {
                    CopyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CurrentStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Available")
                        .Annotation("Relational:DefaultConstraintName", "DF_CurrentStatus"),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    BookISBN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookCopi__C26CCCC544609DF6", x => x.CopyId);
                    table.ForeignKey(
                        name: "FK_Copy_Book",
                        column: x => x.BookISBN,
                        principalSchema: "Library",
                        principalTable: "Books",
                        principalColumn: "ISBN");
                    table.ForeignKey(
                        name: "FK_Copy_Branch",
                        column: x => x.BranchId,
                        principalSchema: "Management",
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BorrowTransactions",
                schema: "Library",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BookCopyId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ReturnDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BorrowTr__55433A6B67301419", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_BT_Copy",
                        column: x => x.BookCopyId,
                        principalSchema: "Library",
                        principalTable: "BookCopies",
                        principalColumn: "CopyId");
                    table.ForeignKey(
                        name: "FK_BT_Member",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MembershipId");
                });

            migrationBuilder.CreateTable(
                name: "Fines",
                schema: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    IssueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PaymentStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BorrowTranId = table.Column<int>(type: "int", nullable: true),
                    Test = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fines__3214EC07AC04D47B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FineTran",
                        column: x => x.BorrowTranId,
                        principalSchema: "Library",
                        principalTable: "BorrowTransactions",
                        principalColumn: "TransactionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BookISBN",
                schema: "Library",
                table: "BookCopies",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BranchId",
                schema: "Library",
                table: "BookCopies",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Authors_AuthorId",
                schema: "Library",
                table: "Books_Authors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowTransactions_BookCopyId",
                schema: "Library",
                table: "BorrowTransactions",
                column: "BookCopyId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowTransactions_MemberId",
                schema: "Library",
                table: "BorrowTransactions",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "UQ__Branches__3BA2AAE0E9F02DE1",
                schema: "Management",
                table: "Branches",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Fines__960D8335058FFAD4",
                schema: "Library",
                table: "Fines",
                column: "BorrowTranId",
                unique: true,
                filter: "[BorrowTranId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ_BorrowTranId",
                schema: "Library",
                table: "Fines",
                column: "BorrowTranId",
                unique: true,
                filter: "[BorrowTranId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books_Authors",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Fines",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Authors",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "BorrowTransactions",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "BookCopies",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Branches",
                schema: "Management");

            migrationBuilder.DropTable(
                name: "Librarians",
                schema: "Management");
        }
    }
}
