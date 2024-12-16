﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Repair1.Data;

#nullable disable

namespace Repair1.Migrations
{
    /// <summary>
    /// Начальная миграция для приложения Repair1.
    /// Эта миграция создает начальную схему базы данных.
    /// </summary>
    [DbContext(typeof(Repair1Context))]
    [Migration("20241216220813_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            // Установка аннотаций для модели
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11") // Версия продукта
                .HasAnnotation("Relational:MaxIdentifierLength", 128); // Максимальная длина идентификатора

            // Использование идентификационных столбцов для SQL Server
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            // Определение сущности 'Client'
            modelBuilder.Entity("Repair1.models.Client", b =>
            {
                b.Property<int>("ClientId") // Идентификатор клиента
                    .ValueGeneratedOnAdd() // Значение генерируется при добавлении
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId")); // Идентификационный столбец

                b.Property<string>("ClientName") // Имя клиента
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email") // Электронная почта клиента
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Phone") // Телефон клиента
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ClientId"); // Установка первичного ключа

                b.ToTable("Client"); // Название таблицы в базе данных
            });

            // Определение сущности 'Request'
            modelBuilder.Entity("Repair1.models.Request", b =>
            {
                b.Property<int>("RequestId") // Идентификатор запроса
                    .ValueGeneratedOnAdd() // Значение генерируется при добавлении
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId")); // Идентификационный столбец

                b.Property<int>("ClientId") // Идентификатор клиента (внешний ключ)
                    .HasColumnType("int");

                b.Property<string>("Description") // Описание запроса
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RequestName") // Название запроса
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("ServiceID") // Идентификатор услуги (внешний ключ)
                    .HasColumnType("int");

                b.Property<int>("StaffId") // Идентификатор сотрудника (внешний ключ)
                    .HasColumnType("int");

                b.HasKey("RequestId"); // Установка первичного ключа

                b.ToTable("Request"); // Название таблицы в базе данных
            });

            // Определение сущности 'Service'
            modelBuilder.Entity("Repair1.models.Service", b =>
            {
                b.Property<int>("ServiceId") // Идентификатор услуги
                    .ValueGeneratedOnAdd() // Значение генерируется при добавлении
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId")); // Идентификационный столбец

                b.Property<string>("Cost") // Стоимость услуги
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description") // Описание услуги
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ServiceName") // Название услуги
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ServiceId"); // Установка первичного ключа

                b.ToTable("Service"); // Название таблицы в базе данных
            });

            // Определение сущности 'Staff'
            modelBuilder.Entity("Repair1.models.Staff", b =>
            {
                b.Property<int>("StaffId") // Идентификатор сотрудника
                    .ValueGeneratedOnAdd() // Значение генерируется при добавлении
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId")); // Идентификационный столбец

                b.Property<string>("Email") // Электронная почта сотрудника
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Password") // Пароль сотрудника
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("StaffName") // Имя сотрудника
                    .IsRequired() // Обязательное поле
                    .HasColumnType("nvarchar(max)");

                b.HasKey("StaffId"); // Установка первичного ключа

                b.ToTable("Staff"); // Название таблицы в базе данных
            });
#pragma warning restore 612, 618
        }
    }
}
