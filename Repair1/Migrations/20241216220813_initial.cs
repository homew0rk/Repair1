using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repair1.Migrations
{
    /// <summary>
    /// Начальная миграция для приложения Repair1.
    /// Эта миграция создает начальную схему базы данных.
    /// </summary>
    public partial class initial : Migration
    {
        /// <summary>
        /// Метод для применения миграции.
        /// Этот метод вызывается при применении миграции к базе данных.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Создание таблицы 'Client' с указанными столбцами и ограничениями
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false) // Первичный ключ
                        .Annotation("SqlServer:Identity", "1, 1"), // Идентификационный столбец
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false), // Имя клиента
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false), // Телефон клиента
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false) // Электронная почта клиента
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId); // Установка ограничения первичного ключа
                });

            // Создание таблицы 'Request' с указанными столбцами и ограничениями
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false) // Первичный ключ
                        .Annotation("SqlServer:Identity", "1, 1"), // Идентификационный столбец
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: false), // Название задачи
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false), // Описание задачи
                    ServiceID = table.Column<int>(type: "int", nullable: false), // Внешний ключ к таблице Service
                    StaffId = table.Column<int>(type: "int", nullable: false), // Внешний ключ к таблице Staff
                    ClientId = table.Column<int>(type: "int", nullable: false) // Внешний ключ к таблице Client
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestId); // Установка ограничения первичного ключа
                });

            // Создание таблицы 'Service' с указанными столбцами и ограничениями
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false) // Первичный ключ
                        .Annotation("SqlServer:Identity", "1, 1"), // Идентификационный столбец
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false), // Название услуги
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false), // Описание услуги
                    Cost = table.Column<string>(type: "nvarchar(max)", nullable: false) // Стоимость услуги
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId); // Установка ограничения первичного ключа
                });

            // Создание таблицы 'Staff' с указанными столбцами и ограничениями
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false) // Первичный ключ
                        .Annotation("SqlServer:Identity", "1, 1"), // Идентификационный столбец
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false), // Имя сотрудника
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false), // Электронная почта сотрудника
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false) // Пароль для входа сотрудника
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId); // Установка ограничения первичного ключа
                });
        }

        /// <summary>
        /// Метод для отмены миграции.
        /// Этот метод вызывается при откате миграции из базы данных.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Удаление таблицы 'Client', если она существует при откате миграции
            migrationBuilder.DropTable(
                name: "Client");

            // Удаление таблицы 'Request', если она существует при откате миграции
            migrationBuilder.DropTable(
                name: "Request");

            // Удаление таблицы 'Service', если она существует при откате миграции
            migrationBuilder.DropTable(
                name: "Service");

            // Удаление таблицы 'Staff', если она существует при откате миграции
            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}

