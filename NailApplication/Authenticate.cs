using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NailApplication
{
    public class Authenticate
    {
        private int code;

        private int admin;

        private bool goodToGo;

        private bool adTrue;

        public Authenticate()
        {
            admin = 2336;
            code = 9371;

        }

        public bool login(int temp)
        {
            if(temp == code)
            {
                goodToGo = true;
                return true;
            }
            else if(temp == admin)
            {
                goodToGo = true;
                adTrue = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool approved()
        {
            return goodToGo;
        }

        public bool ad()
        {
            return adTrue;
        }
    }
}