﻿using DailySoccer.Shared.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySoccer.Shared.Facades
{
    public class FacadeRepository
    {
        private static FacadeRepository _instance;

        public static FacadeRepository Instance
        {
            get
            {
                if (_instance == null) _instance = new FacadeRepository();
                return _instance;
            }
        }

        public IAccountDataAccess AccountDataAccess { get; private set; }
        public IMatchDataAccess MatchDataAccess { get; private set; }

        public MatchFacade MatchFacade { get; set; }
        public AccountFacade AccountFacade { get; set; }

        private FacadeRepository()
        {
            AccountDataAccess = new AccountDataAccess();
            MatchDataAccess = new MatchDataAccess();

            MatchFacade = new MatchFacade();
            AccountFacade = new AccountFacade();
        }

        internal void InitializeDataAccess(IAccountDataAccess accountDac, IMatchDataAccess matchDac)
        {
            AccountDataAccess = accountDac;
            MatchDataAccess = matchDac;
        }
    }
}
