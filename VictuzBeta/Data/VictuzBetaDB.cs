﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using VictuzBeta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Connections;

namespace VictuzBeta.Data
{
    public class VictuzBetaDB : DbContext
    {
        public DbSet<Activity>? Activities { get; set; }
        public DbSet<Agenda>? Agendas { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Member>? Members { get; set; }
        public DbSet<News>? Newses { get; set; }
        public DbSet<Proposition>? Propositions { get; set; }
        public DbSet<Status>? Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Data Source=.;Initial Catalog=VictuzBetaDB;Integrated Security=true;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //specify Activity
            modelBuilder.Entity<Activity>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Agenda
            modelBuilder.Entity<Agenda>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //Specify Location
            modelBuilder.Entity<Location>()
                .Property(v => v.Name)
                .HasMaxLength(50);

            //specify Member
            modelBuilder.Entity<Member>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Proposition
            modelBuilder.Entity<Proposition>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Status
            modelBuilder.Entity<Status>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify News
            modelBuilder.Entity<News>()
                .Property(v => v.Title)
                .HasMaxLength(100);

            //specify Category
            modelBuilder.Entity<Category>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //data seed Activity
            Activity activityEntity = new Activity()
            {
                Id = 1,
                Name = "Test Name",
                Description = "Test Description",
                Date = DateTime.Now,
                LocationDisplay = "Test room",
                Category = "Workshop"
            };
            modelBuilder.Entity<Activity>()
                .HasData(activityEntity);

            //data seed Agenda
            Agenda agendaEntity = new Agenda()
            {
                Id = 1,
                Name = "Test",
                Date = DateTime.Now
            };
            modelBuilder.Entity<Agenda>()
                .HasData(agendaEntity);

            //Data seed Location
            Location locationEntity = new Location()
            {
                Id = 1,
                Name = "Test Name",
                Address = "Test adress",
                Room = "B3.210"
            };
            modelBuilder.Entity<Location>()
                .HasData(locationEntity);

            //data seed Member
            Member memberEntity = new Member()
            {
                Id = 1,
                Name = "Admin",
                LastName = "Istrator",
                Email = "administrator@gmail.com",
                Password = "admin",
                ScreenName = "Tester",
                Validated = true,
                Board = true
            };
            modelBuilder.Entity<Member>()
                .HasData(memberEntity);

            //data seed Proposition
            Proposition propositionEntity = new Proposition()
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Date = DateTime.Now,
                MemberName = "Test",
                StatusDisplay = "In behandeling"
            };
            modelBuilder.Entity<Proposition>()
                .HasData(propositionEntity);

            //data seed Status
            Status statusEntity = new Status()
            {
                Id = 1,
                Name = "In Progress",
                Description = "Test"
            };
            modelBuilder.Entity<Status>()
                .HasData(statusEntity);

            //data seed News
            News newsEntity = new News()
            {
                Id = 1,
                Title = "Test Title",
                Description= "Test description",
                CreatedDate = DateTime.Now
            };
            modelBuilder.Entity<News>()
                .HasData(newsEntity);

            //data seed Category
            Category categoryEntity = new Category()
            {
                Id = 1,
                Name = "Test Category",
                Description = "Test Description",
            };
        }
    }
}