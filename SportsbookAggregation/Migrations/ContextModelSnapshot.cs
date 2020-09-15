﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsbookAggregation.Data;

namespace SportsbookAggregation.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SportsbookAggregation.Data.Models.GamblingSite", b =>
                {
                    b.Property<Guid>("GamblingSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GamblingSiteId");

                    b.ToTable("GamblingSite");

                    b.HasData(
                        new
                        {
                            GamblingSiteId = new Guid("1fcec6f7-84b3-4033-af0f-e1f2bcb8528c"),
                            Name = "Fanduel"
                        },
                        new
                        {
                            GamblingSiteId = new Guid("585e8b23-82e7-468e-b0f3-601cd6eb7a21"),
                            Name = "FoxBet"
                        },
                        new
                        {
                            GamblingSiteId = new Guid("ef4a3b1e-dd09-4e32-a648-097ebae237d1"),
                            Name = "DraftKings"
                        },
                        new
                        {
                            GamblingSiteId = new Guid("a13abd89-8246-4ce9-a3e1-34eee3084748"),
                            Name = "BetRivers"
                        },
                        new
                        {
                            GamblingSiteId = new Guid("3208224c-cbee-408f-b7d8-3ad76f70eaa9"),
                            Name = "Unibet"
                        },
                        new
                        {
                            GamblingSiteId = new Guid("ae98bc03-bf79-491a-8d5a-23acc23908a9"),
                            Name = "Parx"
                        });
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<Guid?>("AwayTeamId")
                        .HasColumnType("binary(16)");

                    b.Property<Guid?>("HomeTeamId")
                        .HasColumnType("binary(16)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GameId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.GameLine", b =>
                {
                    b.Property<Guid>("GameLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<int?>("AwayMoneyLinePayout")
                        .HasColumnType("int");

                    b.Property<int?>("AwaySpreadPayout")
                        .HasColumnType("int");

                    b.Property<double?>("CurrentOverUnder")
                        .HasColumnType("double");

                    b.Property<double?>("CurrentSpread")
                        .HasColumnType("double");

                    b.Property<Guid>("GamblingSiteId")
                        .HasColumnType("binary(16)");

                    b.Property<Guid>("GameId")
                        .HasColumnType("binary(16)");

                    b.Property<int?>("HomeMoneyLinePayout")
                        .HasColumnType("int");

                    b.Property<int?>("HomeSpreadPayout")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastRefresh")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("OpeningOverUnder")
                        .HasColumnType("double");

                    b.Property<double?>("OpeningSpread")
                        .HasColumnType("double");

                    b.Property<int?>("OverPayOut")
                        .HasColumnType("int");

                    b.Property<int?>("UnderPayout")
                        .HasColumnType("int");

                    b.HasKey("GameLineId");

                    b.HasIndex("GamblingSiteId");

                    b.HasIndex("GameId");

                    b.ToTable("GameLine");
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.GameResult", b =>
                {
                    b.Property<Guid>("GameResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<int>("AwayTeamScore")
                        .HasColumnType("int");

                    b.Property<Guid>("GameId")
                        .HasColumnType("binary(16)");

                    b.Property<int>("HomeTeamScore")
                        .HasColumnType("int");

                    b.HasKey("GameResultId");

                    b.HasIndex("GameId");

                    b.ToTable("GameResult");
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.Sport", b =>
                {
                    b.Property<Guid>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SportId");

                    b.ToTable("Sport");

                    b.HasData(
                        new
                        {
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024"),
                            Name = "NBA"
                        },
                        new
                        {
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be"),
                            Name = "NFL"
                        });
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.Team", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mascot")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("SportId")
                        .HasColumnType("binary(16)");

                    b.HasKey("TeamId");

                    b.HasIndex("SportId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = new Guid("327fa1ce-ebd2-42b5-8ae3-af4e1f85c31b"),
                            Location = "Atlanta",
                            Mascot = "Hawks",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("f4646032-8ce2-4115-aa17-6a3f829c48c6"),
                            Location = "Boston",
                            Mascot = "Celtics",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("51058c98-007a-4a03-a4dc-1678f39d0fe6"),
                            Location = "Brooklyn",
                            Mascot = "Nets",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("dba20e75-2763-45e0-8357-f7abdef5796e"),
                            Location = "Charlotte",
                            Mascot = "Hornets",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("9535fd86-0476-4267-964d-86b6ee59c5f1"),
                            Location = "Chicago",
                            Mascot = "Bulls",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("567d7281-3835-4ebe-9bbc-db22003ef4aa"),
                            Location = "Cleveland",
                            Mascot = "Cavaliers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("f3449c73-2bdf-45d6-a12a-5fcdcdba9c7a"),
                            Location = "Dallas",
                            Mascot = "Mavericks",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("cc3a3123-ffcc-4575-aaf6-908bf0a29ae2"),
                            Location = "Denver",
                            Mascot = "Nuggets",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("136ffb0e-e6db-447f-ac0b-d24d0972c63a"),
                            Location = "Detroit",
                            Mascot = "Pistons",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("a7d2b876-5c8f-40c0-a245-64009f1d6875"),
                            Location = "Golden State",
                            Mascot = "Warriors",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("9cb62c80-9eed-4778-9db9-c96a3f210548"),
                            Location = "Houston",
                            Mascot = "Rockets",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("e07441a3-7862-4aa9-b102-fa9eff3a3d32"),
                            Location = "Indiana",
                            Mascot = "Pacers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("a8427679-a566-4cb6-baf5-90f848a70ef1"),
                            Location = "Los Angeles",
                            Mascot = "Clippers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("d96a3350-0ee1-4ebb-a3c5-7e8d9ffbdbcf"),
                            Location = "Los Angeles",
                            Mascot = "Lakers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("0dcdcb0d-5a8f-4f06-ae40-e6c8f9405a2b"),
                            Location = "Memphis",
                            Mascot = "Grizzlies",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("553993e6-d5d2-41d1-9aa4-96282469b7f4"),
                            Location = "Miami",
                            Mascot = "Heat",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("faae94d4-821c-4089-abc9-00e59164cfe4"),
                            Location = "Milwaukee",
                            Mascot = "Bucks",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("49b08feb-f42e-4003-afea-14e5f967bf83"),
                            Location = "Minnesota",
                            Mascot = "Timberwolves",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("980e2d86-24f5-4db1-9e86-a24f69f64363"),
                            Location = "New Orleans",
                            Mascot = "Pelicans",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("aa91f18e-db7f-49b6-ae39-830232228741"),
                            Location = "New York",
                            Mascot = "Knicks",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("17c82efe-820f-47f1-beda-7ca67f77fffa"),
                            Location = "Oklahoma City",
                            Mascot = "Thunder",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("377a4678-f768-41f8-850e-437b87315b10"),
                            Location = "Orlando",
                            Mascot = "Magic",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("e3708fae-5fc1-40d6-b0bc-10330212eb46"),
                            Location = "Philadelphia",
                            Mascot = "76ers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("9490d52f-d1d1-4ac7-87d0-0ef922f4e3e2"),
                            Location = "Phoenix",
                            Mascot = "Suns",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("a0ada57d-419d-4fec-9d72-a6d6b96fcb34"),
                            Location = "Portland",
                            Mascot = "Trail Blazers",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("adb45183-40f4-4cba-adec-062976372d31"),
                            Location = "Sacramento",
                            Mascot = "Kings",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("2578493d-1735-4427-a2e1-492f8c43fdfd"),
                            Location = "San Antonio",
                            Mascot = "Spurs",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("4d89def6-375b-4b58-8385-858ea8957576"),
                            Location = "Toronto",
                            Mascot = "Raptors",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("104981bd-8e56-4d67-bbd0-f6f1bfd50a2d"),
                            Location = "Utah",
                            Mascot = "Jazz",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("261454ae-5f16-4707-ada1-bff5095f056b"),
                            Location = "Washington",
                            Mascot = "Wizards",
                            SportId = new Guid("2cbbd293-8627-447d-8b20-2c5a4fdaa024")
                        },
                        new
                        {
                            TeamId = new Guid("03f86ef9-e837-4d16-a869-1561dde61798"),
                            Location = "Arizona",
                            Mascot = "Cardinals",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("586fe718-6743-409a-969d-d19bd36d4254"),
                            Location = "Atlanta",
                            Mascot = "Falcons",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("3b88d60b-96a7-411b-a061-d4a581d7a5a6"),
                            Location = "Baltimore",
                            Mascot = "Ravens",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("b62aa542-7d3b-4a85-a4e8-8b6a2d8ebefa"),
                            Location = "Buffalo",
                            Mascot = "Bills",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("48259823-78c5-4c42-ace2-7d59fd6d5b67"),
                            Location = "Carolina",
                            Mascot = "Panthers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("0df55a06-1ce5-41f5-baa8-dedfc9982b14"),
                            Location = "Chicago",
                            Mascot = "Bears",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("3bfcc8bb-b87d-4a1a-adf1-bf1ed1c554f5"),
                            Location = "Cincinnati",
                            Mascot = "Bengals",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("450aa644-fcca-4e1e-9ed2-2eb8e87c6571"),
                            Location = "Cleveland",
                            Mascot = "Browns",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("e5e561ba-70c8-4b72-bd63-d14f9e2db12c"),
                            Location = "Dallas",
                            Mascot = "Cowboys",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("0b093a77-6b07-4207-b27c-848938ce522a"),
                            Location = "Denver",
                            Mascot = "Broncos",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("23390e8c-e70c-48aa-9fab-6a3770d91de4"),
                            Location = "Detroit",
                            Mascot = "Lions",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("7193bfbf-1aa8-480e-88e9-339312ea9da8"),
                            Location = "Green Bay",
                            Mascot = "Packers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("2f8cd4fe-dc9c-4ed1-84d7-1d0923e73ac3"),
                            Location = "Houston",
                            Mascot = "Texans",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("41f2f8a9-4671-41f1-86e5-c388423b5b04"),
                            Location = "Indianapolis",
                            Mascot = "Colts",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("6746d02f-0910-402b-86fc-e5a9a52d2e21"),
                            Location = "Jacksonville",
                            Mascot = "Jaguars",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("d728eb6a-8a28-4c21-a50e-a226b2d5b70f"),
                            Location = "Kansas City",
                            Mascot = "Chiefs",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("952efc18-905f-4ab9-8ac3-4f79b0e068e6"),
                            Location = "Los Angeles",
                            Mascot = "Chargers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("1cf88a9e-82cf-4506-8d3b-ac0b8e8915fd"),
                            Location = "Los Angeles",
                            Mascot = "Rams",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("ec9d7c36-7379-4d1d-8a22-156d4ee83b2a"),
                            Location = "Las Vegas",
                            Mascot = "Raiders",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("1c349295-7317-4ad8-ab5a-13275e3e03c6"),
                            Location = "Miami",
                            Mascot = "Dolphins",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("69d2e5de-9793-4faa-a2a8-9bcc54e656d3"),
                            Location = "Minnesota",
                            Mascot = "Vikings",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("0da464e1-f39c-4049-b312-f2968aa71ae4"),
                            Location = "New England",
                            Mascot = "Patriots",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("71245471-b0ff-4381-bf35-343f698ff077"),
                            Location = "New Orleans",
                            Mascot = "Saints",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("fd59c829-5712-450a-ac75-595757010acc"),
                            Location = "New York",
                            Mascot = "Giants",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("d3cadd00-d44a-4840-9632-5f24d72ef9d3"),
                            Location = "New York",
                            Mascot = "Jets",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("fb02cf5b-4ad9-4131-86ab-9a7f49aaad55"),
                            Location = "Philadelphia",
                            Mascot = "Eagles",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("a3629bd0-3c5b-4de6-a3e4-514333fc3fa5"),
                            Location = "Pittsburgh",
                            Mascot = "Steelers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("dd82688b-9c9d-42ac-975c-d4db4a211d29"),
                            Location = "Seattle",
                            Mascot = "Seahawks",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("8a7cdedd-a273-4320-b479-2eeae69694d2"),
                            Location = "San Francisco",
                            Mascot = "49ers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("360fd180-6f0e-4545-8d14-5f690944cfdc"),
                            Location = "Tampa Bay",
                            Mascot = "Buccaneers",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("4c713570-bf81-4b2f-b170-3258ca86d07e"),
                            Location = "Tennessee",
                            Mascot = "Titans",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        },
                        new
                        {
                            TeamId = new Guid("2bf36e69-9abd-40e5-92e3-3817e6c13253"),
                            Location = "Washington",
                            Mascot = "Football Team",
                            SportId = new Guid("6e972a45-6bd9-4085-9a78-faddf46294be")
                        });
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.GameLine", b =>
                {
                    b.HasOne("SportsbookAggregation.Data.Models.GamblingSite", "GamblingSite")
                        .WithMany()
                        .HasForeignKey("GamblingSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportsbookAggregation.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.GameResult", b =>
                {
                    b.HasOne("SportsbookAggregation.Data.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsbookAggregation.Data.Models.Team", b =>
                {
                    b.HasOne("SportsbookAggregation.Data.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
