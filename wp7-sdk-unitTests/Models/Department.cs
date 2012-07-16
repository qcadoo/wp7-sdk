﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Com.Mobeelizer.Mobile.Wp7.Api;
using System.Data.Linq.Mapping;

namespace wp7_sdk_unitTests.Models
{
    [Table]
    public class Department : MobeelizerWp7Model
    {
        [Column(IsPrimaryKey = true)]
        public override String guid { get; set; }

        [Column()]
        public String name { get; set; }

        [Column()]
        public int internalNumber { get; set; }
    }
}