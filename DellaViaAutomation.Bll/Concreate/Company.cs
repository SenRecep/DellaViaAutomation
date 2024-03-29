﻿using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.Concreate
{
    public static class Company
    {
        public static string Name { get { return "Della Via"; } }
        public static string Address { get { return "Antoniestræde 2"; } }
        public static ICollection<PostalCode> PostalCodes { get; set; } = new ObservableCollection<PostalCode>() {
            new PostalCode()
            {
                 City="Køge",
                 Code= 4600,
            },
        };

        public static TimeSpan  FirstOpenTime { get; set; } = new TimeSpan(0, 11, 0, 0);
        public static TimeSpan FirstCloseTime { get; set; } = new TimeSpan(0, 21, 0, 0);
        public static TimeSpan SecondCloseTime { get; set; } = new TimeSpan(0, 22, 0, 0);
        public static DayOfWeek[] DayOfWeeks { get; set; } = { DayOfWeek.Friday, DayOfWeek.Saturday };
    }
}
