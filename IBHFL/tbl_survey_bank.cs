﻿// Decompiled with JetBrains decompiler
// Type: IBHFL.tbl_survey_bank
// Assembly: IBHFL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D5F13E8-66C2-4709-8C6B-C4D11A9CFC14
// Assembly location: D:\M2OST Desktop\console\bin\IBHFL.dll

using System;
using System.Collections.Generic;

namespace IBHFL
{
  public class tbl_survey_bank
  {
    public tbl_survey_bank()
    {
      this.tbl_survey_bank_link = (ICollection<IBHFL.tbl_survey_bank_link>) new HashSet<IBHFL.tbl_survey_bank_link>();
      this.tbl_survey_data = (ICollection<IBHFL.tbl_survey_data>) new HashSet<IBHFL.tbl_survey_data>();
    }

    public int ID_SURVEY_BANK { get; set; }

    public string SURVEY_QUESTION { get; set; }

    public string SURVEY_CHOICES { get; set; }

    public string STATUS { get; set; }

    public DateTime UPDATED_DATE_TIME { get; set; }

    public virtual ICollection<IBHFL.tbl_survey_bank_link> tbl_survey_bank_link { get; set; }

    public virtual ICollection<IBHFL.tbl_survey_data> tbl_survey_data { get; set; }
  }
}