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
using System.Data.Linq.Mapping;

namespace Com.Mobeelizer.Mobile.Wp7.Database
{
    [Table]
    public class MobeelizerModelMetadata
    {
        [Column(Name = "Id", DbType = "BigInt IDENTITY NOT NULL", IsPrimaryKey = true, IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
        public int Id { get; set; }

        [Column(CanBeNull= false)]
        public String Model { get; set; }

        [Column(CanBeNull = false)]
        public String Guid { get; set; }

        [Column(CanBeNull = false)]
        public String Owner { get; set; }

        [Column(CanBeNull = false)]
        public int Modyfied { get; set; }

        [Column(CanBeNull = false)]
        public int Deleted { get; set; }

        [Column(CanBeNull = false)]
        public int Conflicted { get; set; }
    }
}