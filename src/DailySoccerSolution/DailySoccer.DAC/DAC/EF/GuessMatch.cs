//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GuessMatch
    {
        public int Id { get; set; }
        public Nullable<int> GuessTeamId { get; set; }
        public int AccountId { get; set; }
        public int MatchId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Match Match { get; set; }
    }
}