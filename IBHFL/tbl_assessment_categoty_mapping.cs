﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.tbl_assessment_categoty_mapping
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System;

namespace IBHFL
{
  public class tbl_assessment_categoty_mapping
  {
    public int id_assessment_categoty_mapping { get; set; }

    public int id_assessment_sheet { get; set; }

    public int? id_assessment { get; set; }

    public int id_category { get; set; }

    public string status { get; set; }

    public DateTime? updated_date_time { get; set; }
  }
}