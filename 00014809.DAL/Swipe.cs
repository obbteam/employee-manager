﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00014809.DAL
{
    public class Swipe
    {
        private DateTime swipeDate;
        private DateTime swipeIn;
        private DateTime swipeOut;

        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SwipeDate
        {
            get => swipeDate;
            set
            {
                if (value.Date > DateTime.Now) //time validation for future
                    throw new Exception("You can not choose from the future");
                swipeDate = value;
            }
        }
        public DateTime SwipeIn
        {
            get => swipeIn;
            set
            {
                if (value.Date > DateTime.Now) //time validation for future
                    throw new Exception("You can not choose from the future");
                swipeIn = value;
            }
        }
        public DateTime SwipeOut
        {
            get => swipeOut;
            set
            {
                if (value.Date > DateTime.Now) //time validation for future
                    throw new Exception("You can not choose from the future");
                swipeOut = value;
            }
        }

        
    }
}
