﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailySoccer.DAC.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DailySoccerModelContainer : DbContext
    {
        public DailySoccerModelContainer()
            : base("name=DailySoccerModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<GuessMatch> GuessMatches { get; set; }
        public virtual DbSet<RewardGroup> RewardGroups { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<FavoriteTeam> FavoriteTeams { get; set; }
        public virtual DbSet<Winner> Winners { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<PhoneVerification> PhoneVerifications { get; set; }
        public virtual DbSet<GuestAccount> GuestAccounts { get; set; }
    }
}
