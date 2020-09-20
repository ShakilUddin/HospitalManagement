using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalManagement.Migrations
{
    public partial class Final_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inpatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid = table.Column<string>(nullable: true),
                    Room_no = table.Column<string>(nullable: true),
                    Date_of_adm = table.Column<DateTime>(nullable: false),
                    Date_of_dis = table.Column<DateTime>(nullable: false),
                    Advance = table.Column<int>(nullable: false),
                    Labno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inpatients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outpatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outpatients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Labs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Labno = table.Column<string>(nullable: true),
                    PatientId1 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Doctorid = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Patient_type = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    InpatientId = table.Column<int>(nullable: true),
                    OutpatientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labs_Inpatients_InpatientId",
                        column: x => x.InpatientId,
                        principalTable: "Inpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Labs_Outpatients_OutpatientId",
                        column: x => x.OutpatientId,
                        principalTable: "Outpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patientid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phoneno = table.Column<int>(nullable: false),
                    Disease = table.Column<string>(nullable: true),
                    DoctorID1 = table.Column<string>(nullable: true),
                    InpatientId = table.Column<int>(nullable: true),
                    OutpatientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patientid);
                    table.ForeignKey(
                        name: "FK_Patients_Inpatients_InpatientId",
                        column: x => x.InpatientId,
                        principalTable: "Inpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Outpatients_OutpatientId",
                        column: x => x.OutpatientId,
                        principalTable: "Outpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_no = table.Column<string>(nullable: true),
                    Pid = table.Column<string>(nullable: true),
                    Patient_type = table.Column<string>(nullable: true),
                    Doctor_charge = table.Column<int>(nullable: false),
                    Medicine_charge = table.Column<int>(nullable: false),
                    Room_charge = table.Column<int>(nullable: false),
                    Oprtn_charge = table.Column<int>(nullable: false),
                    No_of_days = table.Column<int>(nullable: false),
                    Nursing_charge = table.Column<int>(nullable: false),
                    Advance = table.Column<int>(nullable: false),
                    Health_card = table.Column<string>(nullable: true),
                    Lab_charge = table.Column<int>(nullable: false),
                    Totalbill = table.Column<int>(nullable: false),
                    Patientid = table.Column<int>(nullable: true),
                    InpatientId = table.Column<int>(nullable: true),
                    OutpatientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Inpatients_InpatientId",
                        column: x => x.InpatientId,
                        principalTable: "Inpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Outpatients_OutpatientId",
                        column: x => x.OutpatientId,
                        principalTable: "Outpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Patients_Patientid",
                        column: x => x.Patientid,
                        principalTable: "Patients",
                        principalColumn: "Patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID1 = table.Column<string>(nullable: true),
                    Doctorname = table.Column<string>(nullable: true),
                    Dept = table.Column<string>(nullable: true),
                    Patientid = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Patients_Patientid",
                        column: x => x.Patientid,
                        principalTable: "Patients",
                        principalColumn: "Patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_InpatientId",
                table: "Bills",
                column: "InpatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OutpatientId",
                table: "Bills",
                column: "OutpatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Patientid",
                table: "Bills",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_LabId",
                table: "Doctors",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Patientid",
                table: "Doctors",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_InpatientId",
                table: "Labs",
                column: "InpatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_OutpatientId",
                table: "Labs",
                column: "OutpatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InpatientId",
                table: "Patients",
                column: "InpatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_OutpatientId",
                table: "Patients",
                column: "OutpatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Labs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Inpatients");

            migrationBuilder.DropTable(
                name: "Outpatients");
        }
    }
}
