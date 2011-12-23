using System;
using EzValidation.Core.Tests.Unit.Shared.Models;

namespace EzValidation.Core.Tests.Unit.Shared.ViewModels {

    public class ValidationViewModel {

        public EqualModelOfStrings EqualModelOfStrings_Valid { get; set; }
        public EqualModelOfStrings EqualModelOfStrings_Invalid { get; set; }
        public EqualModelOfLongs EqualModelOfLongs_Valid { get; set; }
        public EqualModelOfLongs EqualModelOfLongs_Invalid { get; set; }
        public EqualModelOfDates EqualModelOfDates_Valid { get; set; }
        public EqualModelOfDates EqualModelOfDates_Invalid { get; set; }

        public NotEqualModelOfStrings NotEqualModelOfStrings_Valid { get; set; }
        public NotEqualModelOfStrings NotEqualModelOfStrings_Invalid { get; set; }
        public NotEqualModelOfLongs NotEqualModelOfLongs_Valid { get; set; }
        public NotEqualModelOfLongs NotEqualModelOfLongs_Invalid { get; set; }
        public NotEqualModelOfDates NotEqualModelOfDates_Valid { get; set; }
        public NotEqualModelOfDates NotEqualModelOfDates_Invalid { get; set; }

        public GreaterModelOfDatesAsStrings GreaterModelOfDatesAsStrings_Valid { get; set; }
        public GreaterModelOfDatesAsStrings GreaterModelOfDatesAsStrings_Invalid { get; set; }
        public GreaterModelOfLongs GreaterModelOfLongs_Valid { get; set; }
        public GreaterModelOfLongs GreaterModelOfLongs_Invalid { get; set; }
        public GreaterModelOfDates GreaterModelOfDates_Valid { get; set; }
        public GreaterModelOfDates GreaterModelOfDates_Invalid { get; set; }
        public LessModelOfDatesAsStrings LessModelOfDatesAsStrings_Valid { get; set; }
        public LessModelOfDatesAsStrings LessModelOfDatesAsStrings_Invalid { get; set; }
        public LessModelOfLongs LessModelOfLongs_Valid { get; set; }
        public LessModelOfLongs LessModelOfLongs_Invalid { get; set; }
        public LessModelOfDates LessModelOfDates_Valid { get; set; }
        public LessModelOfDates LessModelOfDates_Invalid { get; set; }

        public GreaterOrEqualModelOfDatesAsStrings GreaterOrEqualModelOfDatesAsStrings_Valid { get; set; }
        public GreaterOrEqualModelOfDatesAsStrings GreaterOrEqualModelOfDatesAsStrings_Invalid { get; set; }
        public GreaterOrEqualModelOfLongs GreaterOrEqualModelOfLongs_Valid { get; set; }
        public GreaterOrEqualModelOfLongs GreaterOrEqualModelOfLongs_Invalid { get; set; }
        public GreaterOrEqualModelOfDates GreaterOrEqualModelOfDates_Valid { get; set; }
        public GreaterOrEqualModelOfDates GreaterOrEqualModelOfDates_Invalid { get; set; }
        public LessOrEqualModelOfDatesAsStrings LessOrEqualModelOfDatesAsStrings_Valid { get; set; }
        public LessOrEqualModelOfDatesAsStrings LessOrEqualModelOfDatesAsStrings_Invalid { get; set; }
        public LessOrEqualModelOfLongs LessOrEqualModelOfLongs_Valid { get; set; }
        public LessOrEqualModelOfLongs LessOrEqualModelOfLongs_Invalid { get; set; }
        public LessOrEqualModelOfDates LessOrEqualModelOfDates_Valid { get; set; }
        public LessOrEqualModelOfDates LessOrEqualModelOfDates_Invalid { get; set; }

        public ValidationViewModel() {
            EqualModelOfStrings_Valid = new EqualModelOfStrings { Val1 = "Hello World", Val2 = "Hello World", Val3 = DateTime.Now.ToShortDateString(), Val4 = DateTime.Now.AddDays(-1).ToShortDateString(), Val5 = DateTime.Now.AddDays(1).ToShortDateString() };
            EqualModelOfStrings_Invalid = new EqualModelOfStrings { Val1 = "Not Hello World", Val2 = "Hello World", Val3 = DateTime.Now.AddDays(-1).ToShortDateString(), Val4 = DateTime.Now.AddDays(-10).ToShortDateString(), Val5 = DateTime.Now.AddDays(10).ToShortDateString() };
            EqualModelOfLongs_Valid = new EqualModelOfLongs { Val1 = 99, Val2 = 99, Val3 = null, Val4 = null};
            EqualModelOfLongs_Invalid = new EqualModelOfLongs { Val1 = 100, Val2 = 101, Val3 = null, Val4 = 1};
            EqualModelOfDates_Valid = new EqualModelOfDates { Val1 = new DateTime(2010,12,31), Val2 = new DateTime(2010,12,31), Val3 = DateTime.Now.Date, Val4 = null, Val5 = null, Val6 = DateTime.Now.AddDays(-1).Date, Val7 = DateTime.Now.AddDays(1).Date };
            EqualModelOfDates_Invalid = new EqualModelOfDates { Val1 = new DateTime(2009,12,31), Val2 = new DateTime(2000,12,31), Val3 = DateTime.Now.Date.AddDays(1), Val4 = null, Val5 = DateTime.Now.Date, Val6 = DateTime.Now.AddDays(-10).Date, Val7 = DateTime.Now.AddDays(10).Date };

            NotEqualModelOfStrings_Invalid = new NotEqualModelOfStrings { Val1 = "Hello World", Val2 = "Hello World", Val3 = DateTime.Now.ToShortDateString() };
            NotEqualModelOfStrings_Valid = new NotEqualModelOfStrings { Val1 = "Not Hello World", Val2 = "Hello World", Val3 = DateTime.Now.AddDays(-1).ToShortDateString() };
            NotEqualModelOfLongs_Invalid = new NotEqualModelOfLongs { Val1 = 99, Val2 = 99, Val3 = null, Val4 = null };
            NotEqualModelOfLongs_Valid = new NotEqualModelOfLongs { Val1 = 100, Val2 = 101, Val3 = null, Val4 = 1 };
            NotEqualModelOfDates_Invalid = new NotEqualModelOfDates { Val1 = new DateTime(2010, 12, 31), Val2 = new DateTime(2010, 12, 31), Val3 = DateTime.Now.Date, Val4 = null, Val5 = null };
            NotEqualModelOfDates_Valid = new NotEqualModelOfDates { Val1 = new DateTime(2009, 12, 31), Val2 = new DateTime(2000, 12, 31), Val3 = DateTime.Now.Date.AddDays(1), Val4 = null, Val5 = DateTime.Now};

            GreaterModelOfDatesAsStrings_Valid = new GreaterModelOfDatesAsStrings { Val1 = new DateTime(2011, 12, 31).ToShortDateString(), Val2 = new DateTime(2012, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(1).ToShortDateString(), Val4 = DateTime.Now.Date.AddDays(1).ToShortDateString() };
            GreaterModelOfDatesAsStrings_Invalid = new GreaterModelOfDatesAsStrings { Val1 = new DateTime(2009, 12, 31).ToShortDateString(), Val2 = new DateTime(2000, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(-1).ToShortDateString(), Val4 = DateTime.Now.Date.AddDays(-1).ToShortDateString() };
            GreaterModelOfLongs_Valid = new GreaterModelOfLongs { Val1 = 99, Val2 = 100 };
            GreaterModelOfLongs_Invalid = new GreaterModelOfLongs { Val1 = -100, Val2 = -200, Val3 = -200 };
            GreaterModelOfDates_Valid = new GreaterModelOfDates { Val1 = new DateTime(2011, 12, 31), Val2 = new DateTime(2012, 12, 31), Val3 = DateTime.Now.Date.AddDays(1) };
            GreaterModelOfDates_Invalid = new GreaterModelOfDates { Val1 = new DateTime(2009, 12, 31), Val2 = new DateTime(2000, 12, 31), Val3 = DateTime.Now.Date.AddDays(-1), Val4 = DateTime.Now.Date.AddDays(-1) };

            LessModelOfDatesAsStrings_Invalid = new LessModelOfDatesAsStrings { Val1 = new DateTime(2011, 12, 31).ToShortDateString(), Val2 = new DateTime(2012, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(1).ToShortDateString(), Val4 = DateTime.Now.Date.AddDays(1).ToShortDateString() };
            LessModelOfDatesAsStrings_Valid = new LessModelOfDatesAsStrings { Val1 = new DateTime(2009, 12, 31).ToShortDateString(), Val2 = new DateTime(2000, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(-1).ToShortDateString() };
            LessModelOfLongs_Invalid = new LessModelOfLongs { Val1 = 99, Val2 = 100, Val3 = 100 };
            LessModelOfLongs_Valid = new LessModelOfLongs { Val1 = -100, Val2 = -200 };
            LessModelOfDates_Invalid = new LessModelOfDates { Val1 = new DateTime(2011, 12, 31), Val2 = new DateTime(2012, 12, 31), Val3 = DateTime.Now.Date.AddDays(1), Val4 = DateTime.Now.Date.AddDays(1) };
            LessModelOfDates_Valid = new LessModelOfDates { Val1 = new DateTime(2009, 12, 31), Val2 = new DateTime(2000, 12, 31), Val3 = DateTime.Now.Date.AddDays(-1), Val4 = DateTime.Now.Date.AddDays(-1) };

            GreaterOrEqualModelOfDatesAsStrings_Valid = new GreaterOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2011, 12, 31).ToShortDateString(), Val2 = new DateTime(2012, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(1).ToShortDateString(), Val4 = DateTime.Now.Date.AddDays(1).ToShortDateString() };
            GreaterOrEqualModelOfDatesAsStrings_Invalid = new GreaterOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2009, 12, 31).ToShortDateString(), Val2 = new DateTime(2000, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(-1).ToShortDateString()};
            GreaterOrEqualModelOfLongs_Valid = new GreaterOrEqualModelOfLongs { Val1 = 99, Val2 = 100, Val3 = 100 };
            GreaterOrEqualModelOfLongs_Invalid = new GreaterOrEqualModelOfLongs { Val1 = -100, Val2 = -200};
            GreaterOrEqualModelOfDates_Valid = new GreaterOrEqualModelOfDates { Val1 = new DateTime(2011, 12, 31), Val2 = new DateTime(2012, 12, 31), Val3 = DateTime.Now.Date.AddDays(1), Val4 = DateTime.Now.Date.AddDays(1) };
            GreaterOrEqualModelOfDates_Invalid = new GreaterOrEqualModelOfDates { Val1 = new DateTime(2009, 12, 31), Val2 = new DateTime(2000, 12, 31), Val3 = DateTime.Now.Date.AddDays(-1) };

            LessOrEqualModelOfDatesAsStrings_Invalid = new LessOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2011, 12, 31).ToShortDateString(), Val2 = new DateTime(2012, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(1).ToShortDateString(), Val4 = DateTime.Now.Date.AddDays(1).ToShortDateString() };
            LessOrEqualModelOfDatesAsStrings_Valid = new LessOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2009, 12, 31).ToShortDateString(), Val2 = new DateTime(2000, 12, 31).ToShortDateString(), Val3 = DateTime.Now.Date.AddDays(-1).ToShortDateString() };
            LessOrEqualModelOfLongs_Invalid = new LessOrEqualModelOfLongs { Val1 = 99, Val2 = 100};
            LessOrEqualModelOfLongs_Valid = new LessOrEqualModelOfLongs { Val1 = -100, Val2 = -200, Val3 = -200 };
            LessOrEqualModelOfDates_Invalid = new LessOrEqualModelOfDates { Val1 = new DateTime(2011, 12, 31), Val2 = new DateTime(2012, 12, 31), Val3 = DateTime.Now.Date.AddDays(1) };
            LessOrEqualModelOfDates_Valid = new LessOrEqualModelOfDates { Val1 = new DateTime(2009, 12, 31), Val2 = new DateTime(2000, 12, 31), Val3 = DateTime.Now.Date.AddDays(-1), Val4 = DateTime.Now.Date.AddDays(-1) };
        }

    }
}