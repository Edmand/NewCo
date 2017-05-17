using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NewCo.Persistence;

namespace NewCo.Migrations
{
    [DbContext(typeof(NewCoDbContext))]
    [Migration("20170516211827_ChangeAccountID")]
    partial class ChangeAccountID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewCo.Core.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<int>("CountryId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<int>("NotificationTypeId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("PaymentOptionId");

                    b.Property<string>("Postal");

                    b.Property<string>("State");

                    b.Property<int>("SubscriberTypeId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });
        }
    }
}
