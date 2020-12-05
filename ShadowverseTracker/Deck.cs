using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShadowverseTracker
{
    public class Deck
    {
        private Craft mCraft;
        private string mName;
        private int mID;

        public Deck()
        {
            //needed for XmlSerializer, do not use
        }

        public Deck(Craft craft, string name)
        {
            this.mCraft = craft;
            this.mName = name;
        }

        public Craft craft
        {
            get
            {
                return mCraft;
            }
            set
            {
                mCraft = value;
            }
        }

        public string name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public int id
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }
    }
}
