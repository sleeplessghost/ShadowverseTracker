using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ShadowverseTracker
{
    public class DataBase
    {
        private List<Deck> mDeckList;
        private List<Game> mGameList;

        public DataBase()
        {
            mDeckList = new List<Deck>();
            mGameList = new List<Game>();
        }

        public List<Deck> decks
        {
            get
            {
                return mDeckList;
            }
            set
            {
                mDeckList = value;
            }
        }

        public List<Game> games
        {
            get
            {
                return mGameList;
            }
            set
            {
                mGameList = value;
            }
        }
    }
}
